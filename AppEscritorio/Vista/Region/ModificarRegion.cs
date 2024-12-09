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

namespace AppEscritorio.Vista.Region
{
    public partial class ModificarRegion : Form
    {
        public ModificarRegion()
        {
            InitializeComponent();
            try
            {
                comboBox1.Items.Clear();

                List<Models.Region> listado = new RegionDAO().ListarRegion();
                comboBox1.DataSource = listado;
                comboBox1.ValueMember = "id_region";
                comboBox1.DisplayMember = "nombre_region";
                metroGrid1.DataSource = listado;

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ModificarRegion_Load(object sender, EventArgs e)
        {

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
                        List<Models.Region> regions = new RegionDAO().BuscarRegion(codigo);

                        if (regions.Count > 0)
                        {
                            TxtNombre.Clear();

                            TxtID.Clear();
                       

                            Models.Region region= regions[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = region.nombre_region.ToString();
                            TxtID.Text = region.id_region.ToString();
                            Console.WriteLine(1);



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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Region region = new Models.Region();

                region.id_region = Convert.ToInt32(TxtID.Text);
                region.nombre_region = TxtNombre.Text;

                if (new RegionDAO().EditarRegion(region))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("No Modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("REVISE DATOS!");
            }
          
        }
    }
}
