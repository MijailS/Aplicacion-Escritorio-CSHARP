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
    class TecnicoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");


        public bool AgregarTecnico(Tecnico tecnico)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TECNICO", ora);
               comando.CommandType = System.Data.CommandType.StoredProcedure;
               comando.Parameters.Add("NOMBRE_COMPLETO", OracleType.VarChar).Value = tecnico.nombre_completo;
               comando.ExecuteNonQuery();
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
            } return funciona;
        }

        public bool eliminarTecnico(int tecnico)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TECNICO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_tecnico", OracleType.Number).Value = tecnico;
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

        public List<Tecnico> ListarTecnico()
        {
            List<Tecnico> listado = new List<Tecnico>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_TECNICO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TECNICO", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tecnico  tecnico= new Tecnico()
                    {
                        id_tecnico = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_completo= dr.IsDBNull(1) ?" 0 ": dr.GetString(1),
                        
                    };

                    listado.Add(tecnico);

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



        public List<Tecnico> BuscarTecnico(int codigo)
        {
            List<Tecnico> listado = new List<Tecnico>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_TECNICO", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TECNICOS", OracleType.Cursor).Direction = ParameterDirection.Output;

                comando.Parameters.Add("P_ID_TECNICO", OracleType.Int32).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Tecnico tecnico = new Tecnico()
                    {
                        id_tecnico = dr.IsDBNull(0) ? 0 : dr.GetInt32(0),
                        nombre_completo = dr.IsDBNull(1) ? " 0 " : dr.GetString(1),

                    };

                    listado.Add(tecnico);

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
        public bool EditarTecnico(Tecnico tecnico)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_TECNICO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_ID_TECNICO", OracleType.Number).Value = tecnico.id_tecnico;
                comando.Parameters.Add("P_NOMBRE_COMPLETO", OracleType.VarChar).Value = tecnico.nombre_completo;
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

