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

namespace AppEscritorio.Vista.Insumo
{
    public partial class ListarInsumos : Form
    {
        public ListarInsumos()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new InsumoDAO().ListarInsumos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void MgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarInsumos_Load(object sender, EventArgs e)
        {

        }
    }
}
