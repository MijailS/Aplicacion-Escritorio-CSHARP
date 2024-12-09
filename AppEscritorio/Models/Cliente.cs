using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string run { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }

        public int comuna_id { get; set; }
        public string email { get; set; }
  
        public Cliente() { 
        
        }
    }
}
