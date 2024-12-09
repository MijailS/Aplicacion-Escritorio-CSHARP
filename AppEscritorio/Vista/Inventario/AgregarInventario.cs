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
    public partial class AgregarInventario : Form
    {
        public AgregarInventario()
        {
            InitializeComponent();
        }

        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro libro = new AgregarLibro();
            libro.Show();
            
        }

        private void BtnAgregarInsumos_Click(object sender, EventArgs e)
        {
            AgregarInsumo insumo = new AgregarInsumo();
            insumo.Show();
            
        }
    }
}
