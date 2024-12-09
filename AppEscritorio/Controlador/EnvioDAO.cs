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
    class EnvioDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarEnvio(Envio envio)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_ENVIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("venta_id_venta", OracleType.Number).Value = envio.venta_id_venta;
                comando.Parameters.Add("estado", OracleType.VarChar).Value = envio.estado;
                
              
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

        public bool EliminarEnvio(int envio)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_ENVIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ENVIO", OracleType.Number).Value = envio;
                comando.ExecuteNonQuery();

                Console.WriteLine("se pudo eliminar ");
                funciona = true;
                return funciona;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("No se pudo eliminar debido a :" + e.Message);
            }
            finally
            {

                ora.Close();

            }
            return funciona;
        }

        public List<Envio> ListarEnvio()
        {
            List<Envio> listado = new List<Envio>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_ENVIO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("ENVIO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Envio envio = new Envio()
                    {
                        id_envio = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        estado= dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        venta_id_venta = dr.IsDBNull(2) ? 0 : dr.GetInt32(2)
                        

                    };

                    listado.Add(envio);

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
        public bool EditarEnvio(Envio envio)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_ENVIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_ENVIO", OracleType.Number).Value = envio.id_envio;
                comando.Parameters.Add("P_ESTADO", OracleType.VarChar).Value = envio.estado;
                comando.Parameters.Add("P_VENTA_ID_VENTA", OracleType.Number).Value = envio.venta_id_venta;

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

        public List<Envio> BuscarEnvio(int codigo)
        {
            List<Envio> listado = new List<Envio>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_ENVIO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("ENVIOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_ENVIO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Envio envio= new Envio();

                    envio.id_envio= dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    envio.estado= dr.IsDBNull(1) ? "0" : dr.GetString(1);
                    envio.venta_id_venta= dr.IsDBNull(2) ? 0 : dr.GetInt32(2);


                    listado.Add(envio);
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
