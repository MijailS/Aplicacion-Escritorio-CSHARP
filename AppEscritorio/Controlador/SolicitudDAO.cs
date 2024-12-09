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
    class SolicitudDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public List<Solicitud> ListarSolicitudes() {
            List<Solicitud> Listado = new List<Solicitud>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_LISTAR_SOLICITUDES", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("SOLICITUD", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read()) {

                    Solicitud solicitud = new Solicitud();
                    solicitud.id_venta = dr.GetInt32(0);
                    solicitud.fecha = dr.GetDateTime(1);
                    solicitud.total_venta = dr.GetInt32(2);
                    solicitud.iva = dr.GetInt32(3);
                    solicitud.cliente_run = dr.GetString(4);
                    solicitud.tipo_venta_id = dr.GetInt32(5);
                    solicitud.estado_id_estado = dr.GetInt32(6);
                    solicitud.trabajador_run = dr.GetString(7);

                    Listado.Add(solicitud);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL LISTAR"+  ex.Message);
            }
            finally {
                ora.Close();
            }
            return Listado;
        }

       

        public  int  AceptarSolicitud(int codigo)
        {
            int aceptado = 0;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ACTUALIZAR_SOLICITUD", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("IDEN", OracleType.Number).Value = codigo;
                if (comando.ExecuteNonQuery() > 0)
                {
                   aceptado = 1;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL CONFIRMAR PEDIDO"+ex.Message);
            }
            finally {
                ora.Close();
            
            }

            return aceptado;
        }
    }
}
