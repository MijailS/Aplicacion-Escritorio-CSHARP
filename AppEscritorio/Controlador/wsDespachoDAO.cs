using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEscritorio.Models;
using System.Data;
using System.Data.OracleClient;

namespace AppEscritorio.Controlador
{
    class WsDespachoDAO
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD=1234 ;USER ID=BASE_DATOS_CSHARP");
        wsDespacho.wsSeguimientoClient cli = new wsDespacho.wsSeguimientoClient();

        public int BuscarEnvio(int codigo)
        {
            int id = 0;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_ENVIO_VENTA", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("ENVIO", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_VENTA", OracleType.Number).Value = codigo;

                OracleDataReader dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    id = dr.GetInt32(0);
                    
                    Console.WriteLine("este es mi valor!"+ id); /////// 
                    return id;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("ERROR al buscar " + e.Message);
            }
            finally
            {

                ora.Close();
            }

            return id;

        }


        public List<Despacho> BuscarDespacho(int id_envio)
        {

            List<Despacho> listado = new List<Despacho>();

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_BUSCAR_DESPACHO_VENTA", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("DESPACHOS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_ENVIO", OracleType.Number).Value = id_envio;
                OracleDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Despacho despacho = new Despacho();

                    despacho.id_despacho = dr.IsDBNull(0) ? 0 : dr.GetInt32(0);
                    despacho.direccion = dr.IsDBNull(1) ? "0" : dr.GetString(1);
                    despacho.telefono = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                    despacho.comuna_id_comuna = dr.IsDBNull(3) ? 0 : dr.GetInt32(3);
                    despacho.envio_id_envio = dr.IsDBNull(4) ? 0 : dr.GetInt32(4);
                    despacho.estado_id_estado = dr.IsDBNull(5) ? 0 : dr.GetInt32(5);


                    listado.Add(despacho);
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

    public bool EntregarDespacho(wsDespacho.despacho despacho)
        {
            bool funciona = false;
            wsDespacho.despacho array = new wsDespacho.despacho();

            try
            {
                if (despacho.id_despacho != 0)
                {



                    array.id_despacho = despacho.id_despacho;
                    Console.WriteLine(despacho.id_despacho);
                    array.direccion = despacho.direccion;
                    Console.WriteLine(despacho.direccion);
                    array.telefono = despacho.telefono;
                    Console.WriteLine(despacho.telefono);
                    array.comuna_id_comuna = despacho.comuna_id_comuna;
                    Console.WriteLine(despacho.comuna_id_comuna);
                    array.envio_id_envio = despacho.envio_id_envio;
                    Console.WriteLine(despacho.envio_id_envio);
                    array.estado_id_estado = despacho.estado_id_estado;
                    Console.WriteLine(despacho.estado_id_estado);
                    if (cli.agregarDespacho(array))
                    {
                        funciona = true;
                        return funciona;
                    }
                    else
                    {
                        return funciona;
                    }

                    return funciona;
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);

            }
            finally {



            }
            return funciona;
        }
                
               
        


       
    }
}
