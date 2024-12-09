using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscritorio.Controlador;
using AppEscritorio.Models;

namespace AppEscritorio.Vista
{
    public partial class ListadoLibros : Form
    {
        public ListadoLibros()
        {
            InitializeComponent();

            try
            {
              gridListado.DataSource = new LibroDAO().listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR"+ ex );
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoLibros_Load(object sender, EventArgs e)
        {

        }

        private void gridListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
