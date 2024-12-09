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

namespace AppEscritorio.Vista.Cliente
{
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               string codigo = Convert.ToString(TxtNumero.Text);

                if (new ClienteDAO().eliminarCliente(codigo))
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
    }
}
