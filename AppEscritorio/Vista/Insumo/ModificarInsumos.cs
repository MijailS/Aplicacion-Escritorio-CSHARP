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
    public partial class ModificarInsumos : Form
    {
        public ModificarInsumos()
        {
            InitializeComponent();

            try
            {
                comboBox1.Items.Clear();

                List<Models.Insumo> Insumo= new InsumoDAO().ListarInsumos();
                MgvListado.DataSource = Insumo;
                comboBox1.DataSource = Insumo;
                comboBox1.ValueMember = "id";
                comboBox1.DisplayMember = "nombre";
            

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ModificarInsumos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtStock.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtValor.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtImg.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
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
                        List<Models.Insumo> insu= new InsumoDAO().ListarInsumo(codigo);

                        if (insu.Count > 0)
                        {
                            TxtNombre.Clear();

                            TxtImg.Clear();
                            TxtStock.Clear();
                            TxtValor.Clear();
                            TxtID.Clear();

                            Models.Insumo insumos= insu[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = insumos.nombre.ToString();
                            TxtImg.Text = insumos.img.ToString();
                            Console.WriteLine(1);
                            TxtID.Text = insumos.id.ToString();
                            Console.WriteLine(2);
                                           Console.WriteLine(3);
                            TxtStock.Text = insumos.stock.ToString();
                            Console.WriteLine(4);
                            TxtValor.Text = insumos.precio.ToString();
                            Console.WriteLine(5);

                            insu.Clear() ;/// solucion para que no se caiga
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

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Insumo insumo = new Models.Insumo();
                insumo.nombre = TxtNombre.Text;
                insumo.stock = Convert.ToInt32(TxtStock.Text);
                insumo.precio = Convert.ToInt32(TxtValor.Text);
                insumo.img = TxtImg.Text;
                insumo.id = Convert.ToInt32(TxtID.Text);

                if (new InsumoDAO().EditarInsumos(insumo))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("no Modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
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
