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
    class Tipo_VentaDAO
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarTipoVenta(Models.Tipo_Venta tipo_venta)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TIPO_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE_TIPO", OracleType.VarChar).Value = tipo_venta.nombre_tipo;
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

        public bool eliminarTipoVenta(int tipo_Venta)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TIPO_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_tipo", OracleType.Number).Value = tipo_Venta;
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

        public List<Tipo_Venta> ListarTipoVenta()
        {
            List<Tipo_Venta> listado = new List<Tipo_Venta>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_TIPO_VENTA", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TIPO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tipo_Venta tipo_Venta= new Tipo_Venta()
                    {
                        id_tipo = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_tipo = dr.IsDBNull(1) ? "0" : dr.GetString(1),

                    };

                    listado.Add(tipo_Venta);

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

        public List<Tipo_Venta> BuscarTipoVenta(int codigo)
        {
            List<Tipo_Venta> listado = new List<Tipo_Venta>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_TIPO_VENTA", ora);

                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TIPO_VENTAS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tipo_Venta tipo_Venta = new Tipo_Venta()
                    {
                        id_tipo = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_tipo = dr.IsDBNull(1) ? "0" : dr.GetString(1),

                    };

                    listado.Add(tipo_Venta);

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
        public bool editarTipoVenta(Models.Tipo_Venta tipo_venta)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_TIPO_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO", OracleType.Number).Value = tipo_venta.id_tipo;
                comando.Parameters.Add("P_NOMBRE_TIPO", OracleType.VarChar).Value = tipo_venta.nombre_tipo;
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
    }
}
