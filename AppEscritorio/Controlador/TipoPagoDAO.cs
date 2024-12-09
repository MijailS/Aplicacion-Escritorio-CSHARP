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
    class TipoPagoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarTipoPago(Tipo_pago tipo_Pago)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TIPO_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("NOMBRE_TIPO_PAGO", OracleType.VarChar).Value = tipo_Pago.nombre_tipo_pago;
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

        public bool eliminarTipoPago(int tipo_Pago)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TIPO_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_tipo_pago", OracleType.Number).Value = tipo_Pago;
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

        public List<Tipo_pago> ListarTipoPago()
        {
            List<Tipo_pago> listado = new List<Tipo_pago>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_TIPO_PAGO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TIPO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tipo_pago tipo = new Tipo_pago()
                    {
                        id_tipo_pago = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_tipo_pago= dr.IsDBNull(1) ? "0" : dr.GetString(1),
                   
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
    

    public List<Tipo_pago> BuscarTipo(int codigo)
    {
        List<Tipo_pago> listado = new List<Tipo_pago>();

        try
        {
            ora.Open();

            OracleCommand comando = new OracleCommand("SP_BUSCAR_TIPO_PAGO", ora);
            comando.CommandType = CommandType.StoredProcedure;

            // pasamos el cursor del procedimiento

            comando.Parameters.Add("TIPO_PAGOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_TIPO_PAGO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                Tipo_pago tipo = new Tipo_pago()
                {
                    id_tipo_pago = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                    nombre_tipo_pago = dr.IsDBNull(1) ? "0" : dr.GetString(1),

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

    public bool EditarTipo(Tipo_pago tipo_Pago)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_TIPO_PAGO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TIPO_PAGO", OracleType.Number).Value = tipo_Pago.id_tipo_pago;
                comando.Parameters.Add("P_NOMBRE_TIPO_PAGO", OracleType.VarChar).Value = tipo_Pago.nombre_tipo_pago;

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

