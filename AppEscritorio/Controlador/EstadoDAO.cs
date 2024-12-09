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
    class EstadoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarEstado(Estado estado)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_ESTADO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("nombre_estado", OracleType.VarChar).Value = estado.nombre_estado;

                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                return funciona;
            }
            finally
            {
                ora.Close();
            }
        }

        public bool eliminarEstado(int estado)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_ESTADO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_estado", OracleType.Number).Value = estado;
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

        public List<Estado> ListarEstado()
        {
            List<Estado> listado = new List<Estado>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_ESTADO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("ESTADO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Estado estado = new Estado()
                    {
                        id_estado = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_estado = dr.IsDBNull(1) ? "0" : dr.GetString(1)


                    };

                    listado.Add(estado);

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
        public bool EditarEstado(Estado estado)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_ESTADO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_estado", OracleType.Number).Value = estado.id_estado;
                comando.Parameters.Add("p_nombre_estado", OracleType.VarChar).Value = estado.nombre_estado;

                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                return funciona;
            }
            finally
            {
                ora.Close();
            }
        }

        public List<Estado> BuscarEstado(int codigo)
        {
            List<Estado> listado = new List<Estado>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_ESTADO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("ESTADOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_ESTADO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Estado estado = new Estado()
                    {
                        id_estado = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_estado = dr.IsDBNull(1) ? "0" : dr.GetString(1)


                    };

                    listado.Add(estado);

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
    }
}

