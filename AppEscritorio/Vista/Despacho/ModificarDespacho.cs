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

namespace AppEscritorio.Vista.Despacho
{
    public partial class ModificarDespacho : Form
    {
        public ModificarDespacho()
        {
            InitializeComponent();

            List<Models.Comuna> listado = new ComunaDAO().ListarComuna();
            CboComuna.DataSource = listado;
            CboComuna.ValueMember = "id_comuna";
            CboComuna.DisplayMember = "nombre_comuna";

            List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
            CboEnvio.DataSource = envio;
            CboEnvio.DisplayMember = "estado";
            CboEnvio.ValueMember = "id_envio";

            List<Models.Estado> estado = new EstadoDAO().ListarEstado().ToList();
            CboEstado.DataSource = estado;
            CboEstado.DisplayMember = "nombre_estado";
            CboEstado.ValueMember = "id_estado";

            List<Models.Despacho> lista = new DespachoDAO().ListarDespacho();
            metroGrid1.DataSource = lista;
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "id_despacho";
            comboBox1.ValueMember = "id_despacho";
        }

        private void ModificarDespacho_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0 ;
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox1.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Despacho> desp = new DespachoDAO().BuscarDespacho(codigo);

                        if (desp.Count > 0)
                        {


                            Models.Despacho despacho = desp[0]; // Acceder al primer objeto Boleta de la lista

                            TxtDireccion.Text = despacho.direccion.ToString();
                            TxtId.Text = despacho.id_despacho.ToString();
                            Console.WriteLine(1);
                            TxtTelefono.Text = despacho.telefono.ToString();
                            Console.WriteLine(2);
                            CboComuna.SelectedItem = despacho.comuna_id_comuna.ToString();
                            Console.WriteLine(3);
                            CboEnvio.SelectedItem = despacho.envio_id_envio.ToString();
                            CboEstado.SelectedItem = despacho.estado_id_estado.ToString();
                        


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
                Models.Despacho desp = new Models.Despacho();
                desp.comuna_id_comuna = Convert.ToInt32(CboComuna.SelectedValue);
                desp.telefono = Convert.ToInt32(TxtTelefono.Text);
                desp.direccion = TxtDireccion.Text;
                desp.envio_id_envio = Convert.ToInt32(CboEnvio.SelectedValue);
                desp.estado_id_estado = Convert.ToInt32(CboEstado.SelectedValue);
                desp.id_despacho = Convert.ToInt32(TxtId.Text);

                if (new DespachoDAO().EditarDespacho(desp))
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

                MessageBox.Show("revisar campos!");
            }
          
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CboComuna.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtTelefono.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtDireccion.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CboEnvio.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CboEstado.Enabled = true;
        }
    }
}
