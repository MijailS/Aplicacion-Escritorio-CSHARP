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
    class ClienteDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");
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

                Console.WriteLine("ERROR AL AGREGAR CLIENTE :" + ex.Message);
            }
            finally
            {
                ora.Close();
            }

            return funciona;
        }

        public bool eliminarCliente(string cliente)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_CLIENTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_run", OracleType.VarChar).Value = cliente;
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


    
        public List<Cliente> ListarClientes()
        {
            List<Cliente> listado = new List<Cliente>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_CLIENTE", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("CLIENTE", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                   Cliente  cliente = new Cliente()
                    {


                        nombre = dr.GetString(0),
                        apellido= dr.GetString(1),
                        run =dr.GetString(2),
                        email=dr.GetString(3),
                        telefono =dr.GetInt32(4),
                        direccion= dr.GetString(5),
                        comuna_id = dr.GetInt32(6)

                    };

                    listado.Add(cliente);
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
        public bool ModificarCliente(Cliente cliente)
        {
            bool funciona = false;


            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_EDITAR_CLIENTE", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("P_NOMBRE_CLI", OracleType.VarChar).Value = cliente.nombre;
                comando.Parameters.Add("P_APELLIDO_CLI_", OracleType.VarChar).Value = cliente.apellido;
                comando.Parameters.Add("P_RUN", OracleType.VarChar).Value = cliente.run;
                comando.Parameters.Add("P_EMAIL", OracleType.VarChar).Value = cliente.email;
                comando.Parameters.Add("P_TELEFONO", OracleType.Number).Value = cliente.telefono;
                comando.Parameters.Add("P_DIRECCION", OracleType.VarChar).Value = cliente.direccion;

                comando.Parameters.Add("P_COMUNA_ID_COMUNA", OracleType.Number).Value = cliente.comuna_id;
                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR AL AGREGAR CLIENTE :" + ex.Message);
            }
            finally
            {
                ora.Close();
            }

            return funciona;
        }
        public List<Cliente> BuscarCliente(string codigo)
        {
            List<Cliente> listado = new List<Cliente>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_CLIENTE", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("clientes", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_RUN", OracleType.VarChar).Value = codigo;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.nombre = dr.IsDBNull(0) ? "0" : dr.GetString(0);
                    cliente.apellido= dr.IsDBNull(1) ? "0" : dr.GetString(1);
                    cliente.run= dr.IsDBNull(2) ? "0" : dr.GetString(2);
                    cliente.email= dr.IsDBNull(3) ? "0" : dr.GetString(3);
                    cliente.telefono= dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                    cliente.direccion = dr.IsDBNull(5) ? "0" : dr.GetString(5);
                    cliente.comuna_id = dr.IsDBNull(6) ? 0 : dr.GetInt32(6);

                    listado.Add(cliente);
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
    }
}
