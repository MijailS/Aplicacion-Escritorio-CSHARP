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
    class TrabajadorDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");





        public bool AgregarTrabajador(Trabajador trabajador)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TRABAJADOR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nombre_trab", OracleType.VarChar).Value = trabajador.nombre_trab;
                comando.Parameters.Add("apellido_trab", OracleType.VarChar).Value = trabajador.apellido;
                comando.Parameters.Add("run", OracleType.VarChar).Value = trabajador.rut;
                comando.Parameters.Add("password", OracleType.VarChar).Value = trabajador.password;
                comando.Parameters.Add("fec_nac", OracleType.DateTime).Value = trabajador.fec_nac;
                comando.Parameters.Add("email", OracleType.VarChar).Value = trabajador.email;
                comando.Parameters.Add("telefono", OracleType.Number).Value = trabajador.telefono;
                comando.Parameters.Add("direccion", OracleType.VarChar).Value = trabajador.direccion;
                comando.Parameters.Add("comuna_id_comuna", OracleType.Number).Value = trabajador.comuna_id_comuna;
                comando.Parameters.Add("tipo_trab_id_tipo_tra", OracleType.Number).Value = trabajador.tipo_trab;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;
                Console.WriteLine("Guardo");
            }
            catch (Exception ex)
            {

                return funciona;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ora.Close();
            }
        }


        public int BuscarTrabajador(string rut, string contrasenia )
        {
            int centinela = 0;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_TRABAJADORTIPO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("trabajadores", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_RUN", OracleType.VarChar).Value = rut;
                comando.Parameters.Add("P_PASS", OracleType.VarChar).Value = contrasenia;
                OracleDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                   
                    centinela = dr.GetInt32(0);
                }

            }
            
            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN CONSOLA : " + ex.Message);

            }
            finally {

                ora.Close();
            }

            return centinela; 
        }


        public bool eliminarTrabajador(string trabajador)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_TRABAJADOR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_run", OracleType.VarChar).Value = trabajador;
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

        public List<Trabajador> ListarTrabajador(){
        {
            List<Trabajador> listado = new List<Trabajador>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_TRABAJADOR", ora);
                comando.CommandType = CommandType.StoredProcedure;

                // pasamos el cursor del procedimiento

                comando.Parameters.Add("TRABAJADOR", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Trabajador tipo = new Trabajador()
                    {
                        nombre_trab = dr.IsDBNull(0) ? "0" : dr.GetString(0),
                        apellido = dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        rut= dr.IsDBNull(2) ? "0" : dr.GetString(2),
                        password= dr.IsDBNull(3) ? "0" : dr.GetString(3),
                        fec_nac=  dr.GetDateTime(4),
                        email= dr.IsDBNull(5) ? "0" : dr.GetString(5),
                        telefono= dr.IsDBNull(6) ? 0 : dr.GetInt32(6),
                        direccion= dr.IsDBNull(7) ? "0" : dr.GetString(7),
                        comuna_id_comuna= dr.IsDBNull(8) ? 0 : dr.GetInt32(8),
                        tipo_trab = dr.IsDBNull(9) ? 0 : dr.GetInt32(9)

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


        public bool EditarTrabajador(Trabajador trabajador)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_TRABAJADOR", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_nombre_trab", OracleType.VarChar).Value = trabajador.nombre_trab;
                comando.Parameters.Add("p_apellido_trab", OracleType.VarChar).Value = trabajador.apellido;
                comando.Parameters.Add("p_run", OracleType.VarChar).Value = trabajador.rut;
                comando.Parameters.Add("p_password", OracleType.VarChar).Value = trabajador.password;
                comando.Parameters.Add("p_fec_nac", OracleType.DateTime).Value = trabajador.fec_nac;
                comando.Parameters.Add("p_email", OracleType.VarChar).Value = trabajador.email;
                comando.Parameters.Add("p_telefono", OracleType.Number).Value = trabajador.telefono;
                comando.Parameters.Add("p_direccion", OracleType.VarChar).Value = trabajador.direccion;
                comando.Parameters.Add("p_comuna_id_comuna", OracleType.Number).Value = trabajador.comuna_id_comuna;
                comando.Parameters.Add("p_tipo_id_trab_tipo_tra", OracleType.Number).Value = trabajador.tipo_trab;
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

        public List<Trabajador> BuscarTrabajadorMod(string rut)
        {
            List<Trabajador> listado = new List<Trabajador>();

            try
            {
                

                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_TRABAJADOR", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("trabajadores", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_RUN", OracleType.VarChar).Value = rut;
              
                OracleDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    Trabajador tipo = new Trabajador()
                    {
                        nombre_trab = dr.IsDBNull(0) ? "0" : dr.GetString(0),
                        apellido = dr.IsDBNull(1) ? "0" : dr.GetString(1),
                        rut = dr.IsDBNull(2) ? "0" : dr.GetString(2),
                        password = dr.IsDBNull(3) ? "0" : dr.GetString(3),
                        fec_nac = dr.GetDateTime(4),
                        email = dr.IsDBNull(5) ? "0" : dr.GetString(5),
                        telefono = dr.IsDBNull(6) ? 0 : dr.GetInt32(6),
                        direccion = dr.IsDBNull(7) ? "0" : dr.GetString(7),
                        comuna_id_comuna = dr.IsDBNull(8) ? 0 : dr.GetInt32(8),
                        tipo_trab = dr.IsDBNull(9) ? 0 : dr.GetInt32(9)

                    };

                    listado.Add(tipo);
                    return listado;
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("ERROR EN CONSOLA : " + ex.Message);

            }
            finally
            {

                ora.Close();
                
            }
            return listado;
        }
    }



    


}
