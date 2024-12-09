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

namespace AppEscritorio.Vista.Tipo_pago
{
    public partial class ListarTipo_Pago : Form
    {
        public ListarTipo_Pago()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new TipoPagoDAO().ListarTipoPago();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarTipo_Pago_Load(object sender, EventArgs e)
        {

        }
    }
}
