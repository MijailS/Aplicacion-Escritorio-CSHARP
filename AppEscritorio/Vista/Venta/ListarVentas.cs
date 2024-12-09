using AppEscritorio.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio.Vista.Venta
{
    public partial class ListarVentas : Form
    {
        public ListarVentas()
        {
            InitializeComponent();


            List<Models.Venta> venta = new VentaDAO().listar();
            MgvListado.DataSource = venta;
            
        }

        private void ListarVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
