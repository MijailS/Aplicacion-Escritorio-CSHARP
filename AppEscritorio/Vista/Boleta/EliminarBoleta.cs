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
    public partial class EliminarBoleta : Form
    {
        public EliminarBoleta()
        {
            InitializeComponent();
        }

        private void EliminarBoleta_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(TxtNumero.Text);
            if (new BoletaDAO().eliminarBoleta(codigo))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No Eliminado");

            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }



        private void TxtNumero_Click(object sender, EventArgs e)
        {

        }
    }
}

