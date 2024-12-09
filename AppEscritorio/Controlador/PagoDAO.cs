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
    class PagoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarPago(Pago pago)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
              
                comando.Parameters.Add("MONTO", OracleType.Number).Value = pago.monto;
                comando.Parameters.Add("VENTA_ID_VENTA", OracleType.Number).Value = pago.venta_id_venta;
                comando.Parameters.Add("TIPO_PAGO_ID_TIPO_PAGO", OracleType.Number).Value = pago.tipo_pago_id_tipo_pago;
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

        public bool eliminarPago(int pago)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_pago", OracleType.Number).Value = pago;
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

        public List<Pago> ListarPago()
        {
            List<Pago> listado = new List<Pago>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_PAGO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("PAGO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Pago pago = new Pago()
                    {
                        id_pago = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        monto = dr.IsDBNull(1) ? 0 : dr.GetInt32(1),
                        venta_id_venta = dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                        tipo_pago_id_tipo_pago = dr.IsDBNull(3) ? 0 : dr.GetInt32(3)

                    };

                    listado.Add(pago);

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
        public List<Pago> BuscarPago(int codigo)
        {
            List<Pago> listado = new List<Pago>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_PAGO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("PAGOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_PAGO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Pago pago = new Pago()
                    {
                        id_pago = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        monto = dr.IsDBNull(1) ? 0 : dr.GetInt32(1),
                        venta_id_venta = dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                        tipo_pago_id_tipo_pago = dr.IsDBNull(3) ? 0 : dr.GetInt32(3)

                    };

                    listado.Add(pago);

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
        public bool EditarPago(Pago pago)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_PAGO", OracleType.Number).Value = pago.id_pago;
                comando.Parameters.Add("P_MONTO", OracleType.Number).Value = pago.monto;
                comando.Parameters.Add("P_VENTA_ID_VENTA", OracleType.Number).Value = pago.venta_id_venta;
                comando.Parameters.Add("P_TIPO_PAGO_ID_TIPO_PAGO", OracleType.Number).Value = pago.tipo_pago_id_tipo_pago;
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

