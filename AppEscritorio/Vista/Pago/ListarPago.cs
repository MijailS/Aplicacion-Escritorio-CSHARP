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

namespace AppEscritorio.Vista.Pago
{
    public partial class ListarPago : Form
    {
        public ListarPago()
        {
            InitializeComponent();
            try
            {
                gridListado.DataSource = new PagoDAO().ListarPago();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarPago_Load(object sender, EventArgs e)
        {

        }
    }
}
