using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
   public class Insumo
    {

        public int id { get; set; }
        public String nombre { get; set; }

        public int stock { get; set; }

        public int precio { get; set; }
        public string img { get; set; }
        public Insumo() { 
        
        
        }
    }
}
