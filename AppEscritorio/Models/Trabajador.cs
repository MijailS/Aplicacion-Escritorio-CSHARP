using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
   public class Trabajador
    {
        public string nombre_trab { get; set; }
        public string apellido { get; set; }
        public string rut { get; set; }
        public string password { get; set; }
        public DateTime fec_nac { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int comuna_id_comuna { get; set; }
        public int tipo_trab { get; set; }
        public Trabajador()
        {


        }

}
    
}
