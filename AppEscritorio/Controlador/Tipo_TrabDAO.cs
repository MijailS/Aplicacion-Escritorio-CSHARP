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
    class Tipo_TrabDAO
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarTipoTrab(Tipo_Trab tipo_Trab)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TIPO_TRAB", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                
                comando.Parameters.Add("NOMBRE_TIPO_TRA", OracleType.VarChar).Value = tipo_Trab.nombre_tipo_tra;
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

        public bool eliminarTipoTra(int tipo_Trab)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TIPO_TRAB", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_tipo_tra", OracleType.Number).Value = tipo_Trab;
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

        public List<Tipo_Trab> ListarTipoTra()
        {
            List<Tipo_Trab> listado = new List<Tipo_Trab>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_TIPO_TRAB", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TIPO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tipo_Trab tipo = new Tipo_Trab()
                    {
                        id_tipo_tra = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_tipo_tra = dr.IsDBNull(1) ? "0" : dr.GetString(1),

                    };

                    listado.Add(tipo);

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

        public List<Tipo_Trab> BuscarTipó(int codigo)
        {
            List<Tipo_Trab> listado = new List<Tipo_Trab>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_TIPO_TRABAJADOR", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TRABAJADORES", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_TIPO_TRA", OracleType.Int32).Value = codigo;

                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tipo_Trab tipo = new Tipo_Trab()
                    {
                        id_tipo_tra = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_tipo_tra = dr.IsDBNull(1) ? "0" : dr.GetString(1),

                    };

                    listado.Add(tipo);

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

        public bool EditarTipoTrab(Tipo_Trab tipo_Trab)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_TIPO_TRAB", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO_TRA", OracleType.Number).Value = tipo_Trab.id_tipo_tra;
                comando.Parameters.Add("P_NOMBRE_TIPO_TRA", OracleType.VarChar).Value = tipo_Trab.nombre_tipo_tra;
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
