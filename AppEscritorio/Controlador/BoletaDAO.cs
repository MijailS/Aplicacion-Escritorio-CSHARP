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
    public class BoletaDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");
        public bool AgregarBoleta (Boleta boleta)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_BOLETA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("subtotal", OracleType.Number).Value = boleta.subtotal;
                comando.Parameters.Add("venta_id_venta", OracleType.Number).Value = boleta.venta_id_venta;
                comando.Parameters.Add("servicio_id_servicio", OracleType.Number).Value = boleta.servicio_id_servicio;
                comando.Parameters.Add("insumo_id_insumo", OracleType.Number).Value = boleta.insumo_id_sumo;
                comando.Parameters.Add("libro_id_libro", OracleType.Number).Value = boleta.libro_id_libro;
                comando.Parameters.Add("catidad", OracleType.Number).Value = boleta.cantidad;
                comando.ExecuteNonQuery();

                Console.WriteLine("se pudo agregar ");
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                ora.Close();
            }return funciona;
        }

        public bool eliminarBoleta(int boleta)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_BOLETA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_numero", OracleType.Number).Value = boleta;
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

        public List<Boleta> ListarBoleta()
        {
            List<Boleta> listado = new List<Boleta>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_BOLETA", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("BOLETA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Boleta boletita = new Boleta()
                    {
                    subtotal = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                    venta_id_venta = dr.IsDBNull(1) ? 0 : dr.GetInt32(1),
                    servicio_id_servicio = dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                    insumo_id_sumo = dr.IsDBNull(3) ? 0 : dr.GetInt32(3),
                    libro_id_libro = dr.IsDBNull(4) ? 0 : dr.GetInt32(4),
                    numero = dr.IsDBNull(5) ? 0 : dr.GetInt32(5),
                    cantidad = dr.IsDBNull(6) ? 0 : dr.GetInt32(6) };

                    listado.Add(boletita);

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

        public List<Boleta> BuscarBoleta(int codigo)
        {
            List<Boleta> listado = new List<Boleta>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_BOLETA_ES", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("BOLETA", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("NUMERO", OracleType.Number).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Boleta boletita = new Boleta();

                    boletita.subtotal = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    boletita.venta_id_venta = dr.IsDBNull(1) ? 0 : dr.GetInt32(1);
                    boletita.servicio_id_servicio = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                    boletita.insumo_id_sumo = dr.IsDBNull(3) ? 0 : dr.GetInt32(3);
                    boletita.libro_id_libro = dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                    boletita.numero = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);
                    boletita.cantidad = dr.IsDBNull(6) ? 0 : dr.GetInt32(6);

                    listado.Add(boletita);
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
        public bool ModificarBoleta(Boleta boleta) {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_BOLETA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_subtotal", OracleType.Number).Value = boleta.subtotal;
                comando.Parameters.Add("p_venta_id_venta", OracleType.Number).Value = boleta.venta_id_venta;
                comando.Parameters.Add("p_servicio_id_servicio", OracleType.Number).Value = boleta.servicio_id_servicio;
                comando.Parameters.Add("p_insumo_id_insumo", OracleType.Number).Value = boleta.insumo_id_sumo;
                comando.Parameters.Add("p_libro_id_libro", OracleType.Number).Value = boleta.libro_id_libro;
                comando.Parameters.Add("p_cantidad", OracleType.Number).Value = boleta.cantidad;
                comando.Parameters.Add("p_numero", OracleType.Number).Value = boleta.numero;
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
