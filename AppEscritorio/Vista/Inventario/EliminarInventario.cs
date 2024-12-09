using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio.Vista
{
    public partial class EliminarInventario : Form
    {
        public EliminarInventario()
        {
            InitializeComponent();
        }

        private void BtnEliminarLibros_Click(object sender, EventArgs e)
        {
            EliminarLibro EliminarLibros = new EliminarLibro();
            
            EliminarLibros.Show();
            
        }

        private void BtnEliminarInsumos_Click(object sender, EventArgs e)
        {
            EliminarInsumo eliminarInsumo = new EliminarInsumo();
            
            eliminarInsumo.Show();
        }
    }
}
