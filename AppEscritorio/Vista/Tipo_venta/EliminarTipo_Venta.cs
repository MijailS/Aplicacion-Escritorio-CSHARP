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
    public partial class EliminarTipo_Venta : Form
    {
        public EliminarTipo_Venta()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtID.Text);

                if (new Tipo_VentaDAO().eliminarTipoVenta(codigo))
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
    }
}
