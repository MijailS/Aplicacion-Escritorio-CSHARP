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

namespace AppEscritorio.Vista.Tipo_venta
{
    public partial class ListarTipo_Venta : Form
    {
        public ListarTipo_Venta()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new Tipo_VentaDAO().ListarTipoVenta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarTipo_Venta_Load(object sender, EventArgs e)
        {

        }
    }
}
