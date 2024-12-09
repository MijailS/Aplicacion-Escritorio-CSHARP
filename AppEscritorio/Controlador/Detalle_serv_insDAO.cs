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
    class Detalle_serv_insDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");
        public bool AgregarDetalle_Serv(Detalle_serv_ins detalle)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_DETALLE_SERV_INS", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("SERVICIO_ID_SERVICIO", OracleType.Number).Value =detalle.servicio_id_servicio;
                comando.Parameters.Add("INSUMO_ID_SERVICIO", OracleType.Number).Value = detalle.insumo_id_insumo;
                
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

        public bool eliminarDetalle_ins(int codigo)
        {
            bool funciona = false;

            try
            {

                ora.Open();
                OracleCommand comando = new OracleCommand("DELETE FROM DETALLE_SERV_INS WHERE SERVICIO_ID_SERVICIO  =" + codigo, ora);

                if (comando.ExecuteNonQuery() > 0)
                {
                    funciona = true;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("No se pudo Eliminar debido a :" + e.Message);
            }
            finally
            {

                ora.Close();

            }
            return funciona;


        }

        public List<Detalle_serv_ins> Listardetalle_Serv_Ins()
        {
            List<Detalle_serv_ins> listado = new List<Detalle_serv_ins>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_DETALLE_INS", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("DETALLE", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Detalle_serv_ins detalle= new Detalle_serv_ins()
                    {
                        servicio_id_servicio = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        insumo_id_insumo = dr.IsDBNull(1) ? 0 : dr.GetInt32(1)
                       

                    };

                    listado.Add(detalle);

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
    }
}
