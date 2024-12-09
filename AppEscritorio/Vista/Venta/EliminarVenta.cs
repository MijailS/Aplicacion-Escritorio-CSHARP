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
    public partial class EliminarVenta : Form
    {
        public EliminarVenta()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);

                if (new VentaDAO().eliminarVenta(codigo))
                {

                    MessageBox.Show("eliminado");
                }
                else
                {
                    MessageBox.Show("no eliminado");
                }
            }
            catch (Exception)
            {


                MessageBox.Show("Revise datos!");
            }
           
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
