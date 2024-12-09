using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Boleta
    {
        public int subtotal { get; set; }
        public int venta_id_venta { get; set; }
        public int servicio_id_servicio { get; set; }
        public int insumo_id_sumo { get; set; }
        public int libro_id_libro { get; set; }
        public int numero { get; set; }
        public int cantidad { get; set; }

        public Boleta()
        {


        }
    }
}
