using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Controlador
{
    class AlphiliaDAO
    {
        public List<Models.Libro> ListarLibros()
        {
            wsAlphilia.wsAlphiliaClient cliente = new wsAlphilia.wsAlphiliaClient();
            var array = cliente.ListaAlphiliaLi();

            List<Models.Libro> listado = new List<Models.Libro>();

            List<Models.Libro> libro = new List<Models.Libro>();
 
            
            foreach (var item in array)
            {
                Models.Libro li = new Models.Libro();
                li.id_libro = item.id_libro;
                li.titulo = item.titulo;
                li.paginas = item.paginas;
                li.imagen = item.img;
                li.isbn = item.isbn;
                li.resenia = item.resenia;
                li.valor = item.valor;
                li.stock = item.stock;
                li.anio_edicion = item.anio_edicion;
                li.autor = item.autor;

                libro.Add(li);
            }

            return libro;
        }

        public List<Models.Insumo> ListarInsumos()
        {
            wsAlphilia.wsAlphiliaClient cliente = new wsAlphilia.wsAlphiliaClient();
            var array = cliente.ListaAlphiliaIn();

            List<Models.Insumo> listado = new List<Models.Insumo>();

            List<Models.Insumo> insumito = new List<Models.Insumo>();


            foreach (var item in array)
            {
                Models.Insumo insumo = new Models.Insumo();

                insumo.id = item.id_insumo;
                insumo.nombre = item.nombre;
                insumo.img = item.img;
                insumo.precio = item.valor;
                insumo.stock = item.stock;

                insumito.Add(insumo);
            }

            return insumito;
        }
    }
}
