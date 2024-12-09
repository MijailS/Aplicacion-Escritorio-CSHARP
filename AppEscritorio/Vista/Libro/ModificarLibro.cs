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

namespace AppEscritorio.Vista.Libro
{
    public partial class ModificarLibro : Form
    {
        public ModificarLibro()
        {
            InitializeComponent();
            try
            {
                comboBox1.Items.Clear();

                List<Models.Libro> Libro= new LibroDAO().listar();
                metroGrid1.DataSource = Libro;
                comboBox1.DataSource = Libro;
                comboBox1.DisplayMember = "titulo";
                comboBox1.ValueMember = "id_libro";

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ModificarLibro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtIsbn.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtTitulo.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtValor.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtStock.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtImg.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtAutor.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtAnio.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TxtResenia.Enabled = true;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox1.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Libro> librito = new LibroDAO().listarLibro(codigo);

                        if (librito.Count > 0)
                        {
                            TxtAnio.Clear();
                            TxtAutor.Clear();
                            TxtImg.Clear();
                            TxtIsbn.Clear();
                            TxtPaginas.Clear();
                            TxtResenia.Clear();
                            TxtStock.Clear();
                            TxtTitulo.Clear();
                            TxtValor.Clear();

                            Models.Libro libro= librito[0]; // Acceder al primer objeto Boleta de la lista

                            TxtAnio.Text = libro.anio_edicion.ToString();
                            TxtAutor.Text = libro.autor.ToString();
                            Console.WriteLine(1);
                            TxtImg.Text= libro.imagen.ToString();
                            Console.WriteLine(2);
                            TxtIsbn.Text= libro.isbn.ToString();
                            Console.WriteLine(3);
                            TxtPaginas.Text = libro.paginas.ToString();
                            Console.WriteLine(4);
                            TxtResenia.Text = libro.resenia.ToString();
                            Console.WriteLine(5);
                            TxtStock.Text = libro.stock.ToString();
                            Console.WriteLine(4);
                            TxtTitulo.Text = libro.titulo.ToString();
                            Console.WriteLine(5);
                            TxtValor.Text = libro.valor.ToString();
                            TxtID.Text = libro.id_libro.ToString();
                            
                        }


                        else
                        {
                            Console.WriteLine("No se encontraron datos para el código seleccionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR INESPERADO!: " + ex.Message);
                    }
                }
            }
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Libro libro = new Models.Libro();
                libro.isbn = Convert.ToInt32(TxtIsbn.Text);
                libro.titulo = TxtTitulo.Text;
                libro.valor = Convert.ToInt32(TxtValor.Text);
                libro.paginas = Convert.ToInt32(TxtPaginas.Text);
                libro.stock = Convert.ToInt32(TxtStock.Text);
                libro.imagen = TxtImg.Text;
                libro.autor = TxtAutor.Text;
                libro.anio_edicion = Convert.ToInt32(TxtAnio.Text);
                libro.resenia = TxtResenia.Text;
                libro.id_libro = Convert.ToInt32(TxtID.Text); ;
                if (new LibroDAO().EditarLibros(libro))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("NO Modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("REVISE DATOS!");
            }
          
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

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtAnio_KeyPress(object sender, KeyPressEventArgs e)
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
