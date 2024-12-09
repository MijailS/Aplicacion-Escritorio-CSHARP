using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    class Servicio
    {
        public int id_servicio { get; set; }
        public string nombre_servicio { get; set; }
        public int valor { get; set; }
        public string observacion { get; set; }
        public DateTime fecha_programada { get; set; }
        public DateTime fecha_realizado{ get; set; }
        public int tecnico_id_tecnico { get; set; }


        public Servicio() { 
        
        
        }


    }
}
