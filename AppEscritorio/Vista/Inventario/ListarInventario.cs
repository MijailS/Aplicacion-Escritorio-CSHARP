using AppEscritorio.Vista.Insumo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio.Vista.Inventario
{
    public partial class ListarInventario : Form
    {
        public ListarInventario()
        {
            InitializeComponent();
        }

        private void BtnInsumos_Click(object sender, EventArgs e)
        {
            ListarInsumos listarInsumos = new ListarInsumos();
            
            listarInsumos.Show();
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            ListadoLibros listadoLibros = new ListadoLibros();
            
            listadoLibros.Show();
        }
    }
}
