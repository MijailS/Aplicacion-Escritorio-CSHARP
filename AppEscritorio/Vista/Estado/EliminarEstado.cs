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

namespace AppEscritorio.Vista.Estado
{
    public partial class EliminarEstado : Form
    {
        public EliminarEstado()
        {
            InitializeComponent();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(TxtNumero.Text);

                if (new EstadoDAO().eliminarEstado(codigo))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MessageBox.Show("No eliminado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }
           
        }
    }
}
