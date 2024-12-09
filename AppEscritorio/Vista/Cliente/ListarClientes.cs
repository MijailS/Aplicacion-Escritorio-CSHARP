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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new ClienteDAO().ListarClientes();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
