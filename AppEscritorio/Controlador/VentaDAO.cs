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
    class VentaDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");
        public bool GenerarBoleta(Boleta boleta)
        {
             bool funciona = false;

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_AGREGAR_BOLETA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("subtota", OracleType.Number).Value = boleta.subtotal;
                comando.Parameters.Add("venta_id_venta", OracleType.Number).Value = boleta.venta_id_venta;
                comando.Parameters.Add("servicio_id_servicio", OracleType.Number).Value = boleta.servicio_id_servicio;
                comando.Parameters.Add("insumo_id_insumo", OracleType.Number).Value = boleta.insumo_id_sumo;
                comando.Parameters.Add("libro_id_libro", OracleType.Number).Value = boleta.libro_id_libro;
                comando.Parameters.Add("catidad", OracleType.Number).Value = boleta.cantidad;
                comando.ExecuteNonQuery();
                funciona = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error en Agregar boleta : "+ ex.Message);
            }
            finally {
                ora.Close();
            }

            return funciona;


        }

        public bool GenerarVenta(Venta venta) {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("fecha", OracleType.DateTime).Value= venta.fecha;
                comando.Parameters.Add("total_venta", OracleType.Number).Value = venta.total_venta;
                comando.Parameters.Add("iva", OracleType.Number).Value = venta.iva;
                comando.Parameters.Add("cliente_run", OracleType.VarChar).Value = venta.cliente_run;
                comando.Parameters.Add("tipo_venta_id_tipo", OracleType.Number).Value = venta.tipo_id_venta;
                comando.Parameters.Add("estado_id_estado", OracleType.Number).Value = venta.estado_id_estado;
                comando.Parameters.Add("trabajador_run", OracleType.VarChar).Value = venta.trabajador_run ;
                comando.ExecuteNonQuery();

                funciona = true;
                return funciona;
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL GENERAR VENTA : "+ex.Message);


            }
            finally {

                ora.Close();
            }




            return funciona;
        }



        public bool AgregarCliente(Cliente cliente)
        {
            bool funciona = false;


            try
            {
                ora.Open();
                
                OracleCommand comando = new OracleCommand("SP_AGREGAR_CLIENTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nombre_cli", OracleType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("apellido_cli", OracleType.VarChar).Value = cliente.apellido;
                comando.Parameters.Add("run", OracleType.VarChar).Value = cliente.run;
                comando.Parameters.Add("email", OracleType.VarChar).Value = cliente.email;
                comando.Parameters.Add("telefono", OracleType.Number).Value = cliente.telefono;
                comando.Parameters.Add("direccion", OracleType.VarChar).Value = cliente.direccion;
                comando.Parameters.Add("comuna_id_comuna", OracleType.Number).Value = cliente.comuna_id;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL AGREGAR CLIENTE :"+ex.Message);
            }
            finally
            {
                ora.Close();
            }

            return funciona;
        }

        public bool EditarVenta(Venta venta)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_venta", OracleType.Number).Value = venta.id_venta;
                comando.Parameters.Add("p_trabajador_run", OracleType.VarChar).Value = venta.trabajador_run;
                comando.Parameters.Add("p_estado_id_estado", OracleType.Number).Value = venta.estado_id_estado;
                comando.Parameters.Add("p_tipo_venta_id_tipo", OracleType.Number).Value = venta.tipo_id_venta;
                comando.Parameters.Add("p_cliente_run", OracleType.VarChar).Value = venta.cliente_run;
                comando.Parameters.Add("p_iva", OracleType.Float).Value = venta.iva;
                comando.Parameters.Add("p_total_venta", OracleType.Number).Value = venta.total_venta;
                comando.Parameters.Add("p_fecha", OracleType.DateTime).Value = venta.fecha;
                
                
                
                
                
                              
                comando.ExecuteNonQuery();

                funciona = true;
                return funciona;
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL EDITAR VENTA : " + ex.Message);


            }
            finally
            {

                ora.Close();
            }




            return funciona;
        }


        public List<Venta> listar()
        {
            List<Venta> listado = new List<Venta>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_VENTA", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("VENTA", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Venta venta = new Venta()
                    {


                        id_venta = dr.GetInt32(0),
                        fecha= dr.GetDateTime(1),
                        total_venta = dr.GetInt32(2),
                        iva= dr.GetInt32(3),
                        cliente_run= dr.GetString(4),
                        tipo_id_venta= dr.GetInt32(5),
                        estado_id_estado= dr.GetInt32(6),
                        trabajador_run= dr.GetString(7),

                    };

                    listado.Add(venta);
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

        public List<Venta> BuscarVenta(int codigo)
        {
            List<Venta> listado = new List<Venta>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_VENTA", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("VENTAS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_VENTA", OracleType.Int32).Value = codigo ;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Venta venta = new Venta()
                    {


                        id_venta = dr.GetInt32(0),
                        fecha = dr.GetDateTime(1),
                        total_venta = dr.GetInt32(2),
                        iva = dr.GetInt32(3),
                        cliente_run = dr.GetString(4),
                        tipo_id_venta = dr.GetInt32(5),
                        estado_id_estado = dr.GetInt32(6),
                        trabajador_run = dr.GetString(7),

                    };

                    listado.Add(venta);
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

        public bool eliminarVenta( int venta)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_venta", OracleType.Number).Value = venta;
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
        public int UltimaVenta() {

            int codigo = 0;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ULTIMA_VENTA", ora);
                comando.Parameters.Add("VENTA", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                OracleDataReader dr = comando.ExecuteReader();

                if (dr.Read()) {

                    codigo = dr.GetInt32(0);
                    return codigo;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally {
                ora.Close();
            }
            return codigo;
        }
    }

    
}
