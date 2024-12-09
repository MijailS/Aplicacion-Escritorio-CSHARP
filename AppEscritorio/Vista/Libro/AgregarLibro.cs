using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscritorio.Controlador;
using AppEscritorio.Models;

namespace AppEscritorio.Vista
{
    public partial class AgregarLibro : Form
    {
        
        public AgregarLibro()
        {
            InitializeComponent();
        }

      
        private void agregarFormulario(Object formulario)
        {

     
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                int Visbn = Convert.ToInt32(TxtIsbn.Text);
                string Vtitulo = TxtTitulo.Text;
                int Vvalor = Convert.ToInt32(TxtValor.Text);
                int Vpagin = Convert.ToInt32(TxtPaginas.Text);
                int Vstock = Convert.ToInt32(TxtStock.Text);
                String Vimg = TxtIMG.Text;
                String Vautor = Txtauid.Text;
                int Vanio = Convert.ToInt32(txtanio.Text);
                String Vresenia = TxtResenia.Text;

                Models.Libro librito = new Models.Libro();
                librito.id_libro = 0;
                librito.isbn = Visbn;
                librito.titulo = Vtitulo;
                librito.paginas = Vpagin;
                librito.stock = Vstock;
                librito.imagen = Vimg;
                librito.autor = Vautor;
                librito.anio_edicion = Vanio;
                librito.resenia = Vresenia;
                librito.valor = Vvalor;
                if (new LibroDAO().AgregarLibros(librito))
                {
                    MessageBox.Show("EXITO AL GUARDAR :D");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR :D");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL GUARDAR :" + ex.Message);
            }
        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {
          

            
        }

        private void TxtIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtanio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtanio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtStock_TextChanged(object sender, EventArgs e)
        {

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
    }
}
