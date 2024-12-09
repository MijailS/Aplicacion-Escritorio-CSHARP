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
    class RegionDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarRegion(Region region)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_REGION", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE_REGION", OracleType.VarChar).Value = region.nombre_region;

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

        public bool eliminarRegion(int region)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_REGION", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_region", OracleType.Number).Value = region;
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

        public List<Region> ListarRegion()
        {
            List<Region> listado = new List<Region>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_REGION", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("REGION", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                   Region  region = new Region()
                    {
                        id_region = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_region = dr.IsDBNull(1) ? "0" : dr.GetString(1)


                    };

                    listado.Add(region);

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
        public List<Region> BuscarRegion(int codigo)
        {
            List<Region> listado = new List<Region>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_REGION", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("REGIONES", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_REGION", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Region region = new Region()
                    {
                        id_region = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_region = dr.IsDBNull(1) ? "0" : dr.GetString(1)


                    };

                    listado.Add(region);

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
        public bool EditarRegion(Region region)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_REGION", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_REGION", OracleType.Number).Value = region.id_region;
                comando.Parameters.Add("P_NOMBRE_REGION", OracleType.VarChar).Value = region.nombre_region;

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
