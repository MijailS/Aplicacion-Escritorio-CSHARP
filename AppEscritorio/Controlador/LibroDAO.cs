using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using AppEscritorio.Models;

namespace AppEscritorio.Controlador
{
    class LibroDAO
    {


        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=BASE_DATOS_CSHARP");



        public bool AgregarLibros(Libro libro) {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_LIBRO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("isbn", OracleType.Number).Value = libro.isbn;
                comando.Parameters.Add("titulo", OracleType.VarChar).Value = libro.titulo;
                comando.Parameters.Add("valor", OracleType.Number).Value = libro.valor;
                comando.Parameters.Add("paginas", OracleType.Number).Value = libro.paginas;
                comando.Parameters.Add("stock", OracleType.Number).Value = libro.stock;
                comando.Parameters.Add("img", OracleType.VarChar).Value = libro.imagen;
                comando.Parameters.Add("autor", OracleType.VarChar).Value = libro.autor;
                comando.Parameters.Add("anio_edicion", OracleType.Number).Value = libro.anio_edicion;
                comando.Parameters.Add("resenia", OracleType.VarChar).Value = libro.resenia;

                comando.ExecuteNonQuery();
                funciona = true;
                return funciona;

            }
            catch (Exception ex)
            {

                return funciona;
            }
            finally {
                ora.Close();
            }
        }

        public bool eliminarLibro(int libro)
        {
            bool funciona = false;

            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ELIMINAR_LIBRO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_libro", OracleType.Number).Value = libro;
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

        public List<Libro> listar()
        {
            List<Libro> listado = new List<Libro>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_LISTAR_LIBROS", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("LIBROS", OracleType.Cursor).Direction = ParameterDirection.Output;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                 
                    Libro librito = new Libro()
                    {


                        id_libro = dr.GetInt32(0),
                        isbn = dr.GetInt32(1),
                        titulo = dr.GetString(2),
                        valor = dr.GetInt32(3),
                        paginas = dr.GetInt32(4),
                        stock = dr.GetInt32(5),
                        imagen = dr.GetString(6),
                        autor = dr.GetString(7),
                        anio_edicion = dr.GetInt32(8),
                        resenia = dr.GetString(9)
                    };
                    
                    listado.Add(librito);
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

        public List<Libro> listarLibro(int Vcodigo)
        {
            List<Libro> listado = new List<Libro>();

            try
            {
                ora.Open();

                OracleCommand comando = new OracleCommand("SP_BUSCAR_LIBRO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                // pasamos el cursor del procedimiento
                comando.Parameters.Add("LIBROS", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("P_ID_LIBRO", OracleType.Int32).Value = Vcodigo;
                OracleDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    Libro librito = new Libro()
                    {


                        id_libro= dr.GetInt32(0),
                        isbn = dr.GetInt32(1),
                        titulo = dr.GetString(2),
                        valor = dr.GetInt32(3),
                        paginas = dr.GetInt32(4),
                        stock = dr.GetInt32(5),
                        imagen = dr.GetString(6),
                        autor = dr.GetString(7),
                        anio_edicion = dr.GetInt32(8),
                        resenia = dr.GetString(9)
                    };

                    listado.Add(librito);
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

        public bool EditarLibros(Libro libro)
        {

            bool funciona = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_EDITAR_LIBRO", ora);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_id_libro", OracleType.Number).Value = libro.id_libro;
                comando.Parameters.Add("p_isbn", OracleType.Number).Value = libro.isbn;
                comando.Parameters.Add("p_titulo", OracleType.VarChar).Value = libro.titulo;
                comando.Parameters.Add("p_valor", OracleType.Number).Value = libro.valor;
                comando.Parameters.Add("p_paginas", OracleType.Number).Value = libro.paginas;
                comando.Parameters.Add("p_stock", OracleType.Number).Value = libro.stock;
                comando.Parameters.Add("p_img", OracleType.VarChar).Value = libro.imagen;
                comando.Parameters.Add("p_autor", OracleType.VarChar).Value = libro.autor;
                comando.Parameters.Add("p_anio_edicion", OracleType.Number).Value = libro.anio_edicion;
                comando.Parameters.Add("p_resenia", OracleType.VarChar).Value = libro.resenia;

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
