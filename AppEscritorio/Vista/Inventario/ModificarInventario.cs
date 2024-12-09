using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscritorio.Vista;
using AppEscritorio.Vista.Insumo;
using AppEscritorio.Vista.Libro;

namespace AppEscritorio.Vista.Inventario
{
    public partial class ModificarInventario : Form
    {
        public ModificarInventario()
        {
            InitializeComponent();
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            ModificarLibro libro = new ModificarLibro();
            libro.Show();
           
        }

        private void BtnAgregarInsumos_Click(object sender, EventArgs e)
        {
            ModificarInsumos libro = new ModificarInsumos();
            libro.Show();
           
        }
    }
}
