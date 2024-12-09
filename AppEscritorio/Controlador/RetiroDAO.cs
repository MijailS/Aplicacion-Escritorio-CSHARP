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
    class RetiroDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarRetiro(Retiro_Tienda retiro)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_RETIRO_TIENDA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
               
                comando.Parameters.Add("ENVIO_ID_ENVIO", OracleType.VarChar).Value = retiro.envio_id_envio;

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

        public bool eliminarRetiro(int retiro_Tienda)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_RETIRO_TIENDA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_retiro", OracleType.Number).Value = retiro_Tienda;
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

        public List<Retiro_Tienda> ListarRetiro()
        {
            List<Retiro_Tienda> listado = new List<Retiro_Tienda>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_RETIRO_TIENDA", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("RETIRO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Retiro_Tienda retiro_Tienda = new Retiro_Tienda()
                    {
                        id_retiro = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        envio_id_envio = dr.IsDBNull(1) ? 0 : dr.GetInt32(1)


                    };

                    listado.Add(retiro_Tienda);

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
        public List<Retiro_Tienda> Buscar(int codigo)
        {
            List<Retiro_Tienda> listado = new List<Retiro_Tienda>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_RETIRO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("RETIROS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_RETIRO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Retiro_Tienda retiro_Tienda = new Retiro_Tienda()
                    {
                        id_retiro = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        envio_id_envio = dr.IsDBNull(1) ? 0 : dr.GetInt32(1)


                    };

                    listado.Add(retiro_Tienda);

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
        public bool EditarRetiro(Retiro_Tienda retiro)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_RETIRO_TIENDA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_retiro", OracleType.Number).Value = retiro.id_retiro;
                comando.Parameters.Add("p_envio_id_envio", OracleType.Number).Value = retiro.envio_id_envio;

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
    }
}
