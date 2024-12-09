using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Comuna
    {

        public int id_comuna { get; set; }
        public string nombre_comuna { get; set; }
        public int region_id_region { get; set; }

        public Comuna() { 
        
        }
    }
}
