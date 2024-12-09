using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
   public class Envio
    {

        public int id_envio { get; set; }
        public string estado { get; set; }
        public int venta_id_venta { get; set; }
        public Envio() { 
        
        }

    }
}
