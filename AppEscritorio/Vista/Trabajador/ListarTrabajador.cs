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
    public partial class ListarTrabajador : Form
    {
        public ListarTrabajador()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new TrabajadorDAO().ListarTrabajador();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarTrabajador_Load(object sender, EventArgs e)
        {

        }
    }
}
