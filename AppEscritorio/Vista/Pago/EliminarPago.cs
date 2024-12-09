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
    public partial class EliminarPago : Form
    {
        public EliminarPago()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);

                if (new PagoDAO().eliminarPago(codigo))
                {
                    MessageBox.Show("EXITO AL ELIMINAR :D");
                }
                else
                {
                    MessageBox.Show("FALLO AL ELIMINAR!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar u.u + " + ex.Message);
                throw;
            }
            finally
            {

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
