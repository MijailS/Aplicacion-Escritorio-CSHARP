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
    class ComunaDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");

        public bool AgregarComuna(Comuna comuna)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_COMUNA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nombre_comuna", OracleType.VarChar).Value = comuna.nombre_comuna;
                comando.Parameters.Add("region_id_region", OracleType.Number).Value = comuna.region_id_region;
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

        public bool eliminarComuna(int comuna)

        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_COMUNA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_comuna", OracleType.Number).Value = comuna;
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

        public List<Comuna> ListarComuna()
        {
            List<Comuna> listado = new List<Comuna>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_COMUNA", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("COMUNA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Models.Comuna comuna= new Models.Comuna()
                    {
                        id_comuna = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_comuna= dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        region_id_region= dr.IsDBNull(2) ? 0 : dr.GetInt32(2)

                    };

                    listado.Add(comuna);

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


        public bool EditarComuna(Comuna comuna)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_COMUNA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_comuna", OracleType.Number).Value = comuna.id_comuna;
                comando.Parameters.Add("p_nombre_comuna", OracleType.VarChar).Value = comuna.nombre_comuna;
                comando.Parameters.Add("p_region_id_region", OracleType.Number).Value = comuna.region_id_region;
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

        public List<Comuna> BuscarComuna(int codigo)
        {
            List<Comuna> listado = new List<Comuna>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_COMUNA", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("COMUNAS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_COMUNA", OracleType.Number).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Comuna comuna= new Comuna();

                    comuna.id_comuna = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    comuna.nombre_comuna = dr.IsDBNull(1) ? "0": dr.GetString(1);
                    comuna.region_id_region= dr.IsDBNull(2) ? 0 : dr.GetInt32(2);


                    listado.Add(comuna);
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
