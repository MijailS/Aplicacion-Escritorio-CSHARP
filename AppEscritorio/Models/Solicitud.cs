using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Solicitud
    {

        public int id_venta { get; set; }
        public DateTime fecha    { get; set; }
        public int total_venta { get; set; }
        public int iva { get; set; }
        public string cliente_run { get; set; }
        public int tipo_venta_id { get; set; }
        public int estado_id_estado { get; set; }
        public string trabajador_run { get; set; }

        public Solicitud()
        {

        }
    }

    
}
