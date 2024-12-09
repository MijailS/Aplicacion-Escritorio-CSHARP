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

namespace AppEscritorio.Vista.Boleta
{
    public partial class ListarBoletas : Form
    {
        public ListarBoletas()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new BoletaDAO().ListarBoleta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarBoletas_Load(object sender, EventArgs e)
        {

        }
    }
}
