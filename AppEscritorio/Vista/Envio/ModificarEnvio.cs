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

namespace AppEscritorio.Vista.Envio
{
    public partial class ModificarEnvio : Form
    {
        public ModificarEnvio()
        {
            InitializeComponent();
            List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
            CboEnvio.DataSource = envio;
            CboEnvio.DisplayMember = "id_envio";
            CboEnvio.ValueMember = "id_envio";
            metroGrid1.DataSource = envio;

            comboBox1.DataSource = new VentaDAO().listar().ToList();
            comboBox1.DisplayMember = "id_venta";
            comboBox1.DisplayMember = "id_venta";
        }

        private void ModificarEnvio_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (CboEnvio.SelectedItem != null)
            {
                if (CboEnvio.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(CboEnvio.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Envio> envios = new EnvioDAO().BuscarEnvio(codigo);

                        if (envios.Count > 0)
                        {


                            Models.Envio env = envios[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = env.estado.ToString();
                            TxtId.Text = env.id_envio.ToString();
                            comboBox1.SelectedItem = env.venta_id_venta;
                      


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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Envio envio = new Models.Envio();
                envio.estado = TxtNombre.Text;
                envio.id_envio = Convert.ToInt32(TxtId.Text);///ERROR
                envio.venta_id_venta = ((AppEscritorio.Models.Venta)comboBox1.SelectedValue).id_venta;

                if (new EnvioDAO().EditarEnvio(envio))
                {
                    MessageBox.Show("Modificado");
                }
                else { MessageBox.Show("No Modificado"); }

            }
            catch (Exception)
            {
                MessageBox.Show("revisar campos!");
                throw;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
    }
}
