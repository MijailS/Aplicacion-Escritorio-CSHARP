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

namespace AppEscritorio.Vista.Trabajador
{
    public partial class EliminarTrabajador : Form
    {
        public EliminarTrabajador()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtTipo.Text != txtID.Text)
                {

                    string codigo = txtID.Text;

                    if (new TrabajadorDAO().eliminarTrabajador(codigo))
                    {
                        MessageBox.Show("EXITO AL ELIMINAR :D");
                    }
                    else
                    {
                        MessageBox.Show("FALLO AL ELIMINAR!!");

                    }
                }
                else {
                    MessageBox.Show("NO TE PUEDES ELIMINAR A TI MISMO D:");
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
