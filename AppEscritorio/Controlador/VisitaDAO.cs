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
    class VisitaDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");



        public bool AgregarVisita(Visita visita)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_VISITA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("FECHA", OracleType.DateTime ).Value = visita .fecha;
                comando.Parameters.Add("HORA", OracleType.DateTime ).Value = visita.hora;
                comando.Parameters.Add("DESCRIPCION", OracleType.VarChar ).Value = visita.descripcion;
                comando.Parameters.Add("TECNICO_ID_TECNICO", OracleType.Number).Value = visita.tecnico_id_tecnico;

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


        public bool eliminarVisita(int visita)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_VISITA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_visita", OracleType.Number).Value = visita;
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

        public List<Visita > ListarVisitas()
        {
            {
                List<Visita> listado = new List<Visita>();

                try
                {
                    ora.Open();

                    OracleCommand comando = new OracleCommand("SP_LISTAR_VISITA", ora);
                    comando.CommandType = CommandType.StoredProcedure;

                    // pasamos el cursor del procedimiento

                    comando.Parameters.Add("VISITA", OracleType.Cursor).Direction = ParameterDirection.Output;
                    OracleDataReader dr = comando.ExecuteReader();

                    while (dr.Read())
                    {

                        Visita tipo = new Visita()
                        {
                            id_visita = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                            fecha = dr.GetDateTime(1),
                            hora = dr.GetDateTime(2),
                            descripcion = dr.GetString(3),
                            tecnico_id_tecnico = dr.GetInt32(4)




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
        }

        public List<Visita> BuscarVisita(int codigo)
        {
            {
                List<Visita> listado = new List<Visita>();

                try
                {
                    ora.Open();

                    OracleCommand comando = new OracleCommand("SP_BUSCAR_VISITA", ora);
                    comando.CommandType = CommandType.StoredProcedure;

                    // pasamos el cursor del procedimiento

                    comando.Parameters.Add("VISITAS", OracleType.Cursor).Direction = ParameterDirection.Output;
                    comando.Parameters.Add("P_ID_VISITA", OracleType.Int32).Value = codigo;
                    OracleDataReader dr = comando.ExecuteReader();

                    while (dr.Read())
                    {

                        Visita tipo = new Visita()
                        {
                            id_visita = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                            fecha = dr.GetDateTime(1),
                            hora = dr.GetDateTime(2),
                            descripcion = dr.GetString(3),
                            tecnico_id_tecnico = dr.GetInt32(4)




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
        }
        public bool EditarVisita(Visita visita)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_VISITA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_VISITA", OracleType.Number).Value = visita.id_visita;
                comando.Parameters.Add("P_FECHA", OracleType.DateTime).Value = visita.fecha;
                comando.Parameters.Add("P_HORA", OracleType.DateTime).Value = visita.hora;
                comando.Parameters.Add("P_DESCRIPCION", OracleType.VarChar).Value = visita.descripcion;
                comando.Parameters.Add("P_TECNICO_ID_TECNICO", OracleType.Number).Value = visita.tecnico_id_tecnico;
              
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
