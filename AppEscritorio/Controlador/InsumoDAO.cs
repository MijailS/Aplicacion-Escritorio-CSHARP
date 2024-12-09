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
   public class InsumoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");



        public bool AgregarInsumos(Insumo insumo) {
            bool funciona = false;

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_AGREGAR_INSUMO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nombre", OracleType.VarChar).Value = insumo.nombre;
                comando.Parameters.Add("stock", OracleType.Number).Value = insumo.stock;
                comando.Parameters.Add("valor", OracleType.Number).Value = insumo.precio;
                comando.Parameters.Add("img", OracleType.VarChar).Value = insumo.img;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine("error al agregar : "+ex.Message);
                return funciona;
            }
            finally {

                ora.Close();
            
            }
            return funciona;
        }

        public bool EliminarInsumos(int insumo) 
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_INSUMO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_INSUMO", OracleType.Number).Value = insumo;
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

        public List<Insumo> ListarInsumos() {

            List<Insumo> insumos = new List<Insumo>() ;


            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_INSUMOS", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("INSUMOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();


                while (dr.Read())
                {

                    Insumo listado = new Insumo()
                    {
                        id = dr.GetInt32(0),
                        nombre = dr.GetString(1),
                        stock = dr.GetInt32(2),
                        precio = dr.GetInt32(3),
                        img = dr.GetString(4)
                    };

                    insumos.Add(listado);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR AL LISTAR: " + e.Message);
            }
            finally {

                ora.Close();

            }

            return insumos;
        }
        public List<Insumo> ListarInsumo(int codigo)
        {

            List<Insumo> insumos = new List<Insumo>();


            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_INSUMO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("INSUMOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_INSUMO", OracleType.Int32).Value =  codigo;
                OracleDataReader dr = comando.ExecuteReader();


                while (dr.Read())
                {

                    Insumo listado = new Insumo()
                    {
                        id = dr.GetInt32(0),
                        nombre = dr.GetString(1),
                        stock = dr.GetInt32(2),
                        precio = dr.GetInt32(3),
                        img = dr.GetString(4)
                    };

                    insumos.Add(listado);
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

            return insumos;
        }
        public bool EditarInsumos(Insumo insumo)
        {
            bool funciona = false;

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_EDITAR_INSUMO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_insumo", OracleType.Number).Value = insumo.id;
                comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = insumo.nombre;
                comando.Parameters.Add("p_stock", OracleType.Number).Value = insumo.stock;
                comando.Parameters.Add("p_valor", OracleType.Number).Value = insumo.precio;
                comando.Parameters.Add("p_img", OracleType.VarChar).Value = insumo.img;
                
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine("error al agregar : " + ex.Message);
                return funciona;
            }
            finally
            {

                ora.Close();

            }
            return funciona;
        }
       

    }
}
