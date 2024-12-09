using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Libro
    {

        public int id_libro { get;set; }
        public int isbn { get; set; }
        public String titulo { get; set; }
        public int valor { get; set; }
        public int paginas { get; set; }
        public int stock { get; set; }
        public String imagen { get; set; }
        public String autor { get; set; }
        public int anio_edicion { get; set; }
       
        public String resenia { get; set; }
        
        


        public Libro() { 
        
        
        }
    }

}
