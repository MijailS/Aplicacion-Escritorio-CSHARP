using AppEscritorio.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Controlador
{
    class DespachoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");

        public bool AgregarDespacho( Despacho despacho)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_DESPACHO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
         
                comando.Parameters.Add("direccion", OracleType.VarChar).Value = despacho.direccion;
                comando.Parameters.Add("telefono", OracleType.Number).Value = despacho.telefono;
                comando.Parameters.Add("comuna_id_comuna", OracleType.Number).Value = despacho.comuna_id_comuna;
                comando.Parameters.Add("envio_id_envio", OracleType.Number).Value = despacho.envio_id_envio;
                comando.Parameters.Add("estado_id_estado", OracleType.Number).Value = despacho.estado_id_estado;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

                Console.WriteLine("agregado");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                ora.Close();
            } return funciona;
        }

        public bool eliminarDespacho(int despacho)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_DESPACHO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_despacho", OracleType.Number).Value = despacho;
                comando.ExecuteNonQuery();

                Console.WriteLine("se pudo eliminar ");
                funciona = true;
                return funciona;
            }
            catch (Exception e)
            {

                Console.WriteLine("No se pudo eliminar debido a :" + e.Message);
            }
            finally
            {

                ora.Close();

            }
            return funciona;
        }

        public List<Despacho> ListarDespacho()
        {
            List<Despacho> listado = new List<Despacho>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_DESPACHO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("DESPACHO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Despacho despacho = new Despacho()
                    {
                        id_despacho = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        direccion = dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        telefono= dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                        comuna_id_comuna= dr.IsDBNull(3) ? 0 : dr.GetInt32(3),
                        envio_id_envio= dr.IsDBNull(4) ? 0 : dr.GetInt32(4)
                        ,estado_id_estado = dr.GetInt32(5)
                    };

                    listado.Add(despacho);

                }




            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR AL LISTAR: " + e.Message);
            }
            finally
            {
                ora.Close();
            }

            return listado;
        }

        public bool EditarDespacho(Despacho despacho)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_DESPACHO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_DESPACHO", OracleType.Number).Value = despacho.id_despacho;
                comando.Parameters.Add("P_DIRECCION", OracleType.VarChar).Value = despacho.direccion;
                comando.Parameters.Add("P_TELEFONO", OracleType.Number).Value = despacho.telefono;
                comando.Parameters.Add("P_COMUNA_ID_COMUNA", OracleType.Number).Value = despacho.comuna_id_comuna;
                comando.Parameters.Add("P_ENVIO_ID_ENVIO", OracleType.Number).Value = despacho.envio_id_envio;
                comando.Parameters.Add("P_ESTADO_ID_ESTADO", OracleType.Number).Value = despacho.estado_id_estado;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return funciona;
            }
            finally
            {
                ora.Close();
            }
        }

        public List<Despacho> BuscarDespacho(int codigo)
        {
            List<Despacho> listado = new List<Despacho>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_DESPACHO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("DESPACHOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_DESPACHO", OracleType.Number).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Despacho despacho = new Despacho();

                    despacho.id_despacho= dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    despacho.direccion= dr.IsDBNull(1) ? "0" : dr.GetString(1);
                    despacho.telefono= dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                    despacho.comuna_id_comuna= dr.IsDBNull(3) ? 0 : dr.GetInt32(3);
                    despacho.envio_id_envio= dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                    despacho.estado_id_estado= dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
              

                    listado.Add(despacho);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR AL LISTAR" + e.Message);
            }
            finally
            {

                ora.Close();
            }


            return listado;

        }

    }
}
