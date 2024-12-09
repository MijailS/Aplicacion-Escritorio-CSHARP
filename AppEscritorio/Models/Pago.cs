using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio.Models
{
    public class Pago
    {
        public int id_pago { get; set; }
        public int monto { get; set; }
        public int venta_id_venta { get; set; }
        public int tipo_pago_id_tipo_pago { get; set; }
   
        public Pago() { }
    
    }
}
