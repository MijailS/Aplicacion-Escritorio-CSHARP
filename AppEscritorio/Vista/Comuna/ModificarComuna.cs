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

namespace AppEscritorio.Vista.Comuna
{
    public partial class ModificarComuna : Form
    {
        public ModificarComuna()
        {
            InitializeComponent();
            List<Models.Comuna> listado = new ComunaDAO().ListarComuna();
            comboBox1.DataSource = listado;
            comboBox1.ValueMember = "id_comuna";
            comboBox1.DisplayMember = "nombre_comuna";
            metroGrid1.DataSource = listado;
            List<Models.Region> lista = new RegionDAO().ListarRegion();
            CboRegion.DataSource = lista;
            CboRegion.ValueMember = "id_region";
            CboRegion.DisplayMember = "nombre_region";
        }

        private void ModificarComuna_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            try
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
                            List<Models.Comuna> comuna = new ComunaDAO().BuscarComuna(codigo);

                            if (comuna.Count > 0)
                            {


                                Models.Comuna comu = comuna[0]; // Acceder al primer objeto Boleta de la lista

                                TxtNombre.Text = comu.nombre_comuna.ToString();
                                TxtId.Text = comu.id_comuna.ToString();
                                Console.WriteLine(1);
                                CboRegion.SelectedValue = comu.region_id_region;
                                Console.WriteLine(2);


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
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Comuna comuna = new Models.Comuna();
            comuna.id_comuna= Convert.ToInt32(TxtId.Text);
            comuna.nombre_comuna = TxtNombre.Text;
            comuna.id_comuna = Convert.ToInt32(CboRegion.SelectedValue);
            if (new ComunaDAO().EditarComuna(comuna))
            {
                MessageBox.Show("Modificado");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CboRegion.Enabled = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }
    }
}
