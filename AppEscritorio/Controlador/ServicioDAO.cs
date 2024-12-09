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
    class ServicioDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarServicio(Servicio servicio)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_SERVICIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.Add("nombre_servicio", OracleType.VarChar).Value = servicio.nombre_servicio;
                comando.Parameters.Add("valor", OracleType.Number).Value = servicio.valor;
                comando.Parameters.Add("observacion", OracleType.VarChar).Value = servicio.observacion;
                comando.Parameters.Add("fecha_programada", OracleType.DateTime).Value = servicio.fecha_programada;
                comando.Parameters.Add("fecha_realizado", OracleType.DateTime).Value = servicio.fecha_realizado;
                comando.Parameters.Add("tecnico_id_tecnico", OracleType.Number).Value = servicio.tecnico_id_tecnico;


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

        public bool eliminarServicio(int servicio)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_SERVICIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_servicio", OracleType.Number).Value = servicio;
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

        public List<Servicio> ListarServicio()
        {
            List<Servicio> listado = new List<Servicio>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_SERVICIO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("SERVICIO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Servicio servicio = new Servicio()
                    {
                        id_servicio = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_servicio = dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        valor = dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                        observacion = dr.IsDBNull(3) ? "0" : dr.GetString(3),
                        fecha_programada = dr.GetDateTime(4),
                        fecha_realizado = dr.GetDateTime(5),
                        tecnico_id_tecnico = dr.IsDBNull(6) ? 0 : dr.GetInt32(6),
                    };

                    listado.Add(servicio);

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

        public List<Servicio> BuscarServicio(int codigo)
        {
            List<Servicio> listado = new List<Servicio>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_SERVICIO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("SERVICIOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_SERVICIO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Servicio servicio = new Servicio()
                    {
                        id_servicio = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_servicio = dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        valor = dr.IsDBNull(2) ? 0 : dr.GetInt32(2),
                        observacion = dr.IsDBNull(3) ? "0" : dr.GetString(3),
                        fecha_programada = dr.GetDateTime(4),
                        fecha_realizado = dr.GetDateTime(5),
                        tecnico_id_tecnico = dr.IsDBNull(6) ? 0 : dr.GetInt32(6),
                    };

                    listado.Add(servicio);

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
        public bool EditarServicio(Servicio servicio)
        {


            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_SERVICIO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_SERVICIO", OracleType.Number).Value = servicio.id_servicio;
                comando.Parameters.Add("P_NOMBRE_SERVICIO", OracleType.VarChar).Value = servicio.nombre_servicio;
                comando.Parameters.Add("P_VALOR", OracleType.Number).Value = servicio.valor;
                comando.Parameters.Add("P_OBSERVACION", OracleType.VarChar).Value = servicio.observacion;
                comando.Parameters.Add("P_FECHA_PROGRAMADA", OracleType.DateTime).Value = servicio.fecha_programada;
                comando.Parameters.Add("P_FECHA_REALIZADO", OracleType.DateTime).Value = servicio.fecha_realizado;
                comando.Parameters.Add("P_TECNICO_ID_TECNICO", OracleType.Number).Value = servicio.tecnico_id_tecnico;

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
