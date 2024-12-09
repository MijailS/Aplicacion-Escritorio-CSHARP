using AppEscritorio.Controlador;
using AppEscritorio.Models;
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
    public partial class AgregarInsumo : Form
    {
        public AgregarInsumo()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
string nombre = TxtNombre.Text;
            int precio = Convert.ToInt32(TxtPrecio.Text);
            int stock = Convert.ToInt32(TxtStock.Text);
            string img = TxtImg.Text;

            Models.Insumo insumo = new Models.Insumo();

            insumo.id = 0;
            insumo.nombre = nombre;
            insumo.stock = stock;
            insumo.stock = precio;
            insumo.img = img;
            if (new InsumoDAO().AgregarInsumos(insumo))
            {

                MessageBox.Show("EXITO AL GUARDAR :D");
                TxtNombre.Clear();
                TxtPrecio.Clear();
                TxtStock.Clear();
                TxtImg.Clear();

            }
            else
            {
                MessageBox.Show("ERROR AL GUARDAR :D");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
