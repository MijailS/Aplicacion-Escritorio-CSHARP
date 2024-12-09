using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Despacho
    {
        public int id_despacho { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public int comuna_id_comuna { get; set; }
        public int envio_id_envio { get; set; }

        public int estado_id_estado { get; set; }
        public Despacho()
        {



        }
    }
}
