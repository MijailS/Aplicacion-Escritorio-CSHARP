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

namespace AppEscritorio.Vista.Trabajador
{
    public partial class ModificarTrabajador : Form
    {
        public ModificarTrabajador()
        {
            InitializeComponent();
            
                comboBox2.Items.Clear();

                List<Models.Trabajador> listado = new TrabajadorDAO().ListarTrabajador();
            comboBox2.DataSource = listado;
            comboBox2.ValueMember = "rut";
            comboBox2.DisplayMember = "rut";
            metroGrid1.DataSource = listado;

            List<Models.Comuna> lista = new ComunaDAO().ListarComuna();
            CboComuna.DataSource = lista;
            CboComuna.ValueMember = "id_comuna";
            CboComuna.DisplayMember = "nombre_comuna";

            List<Models.Tipo_Trab> list = new Tipo_TrabDAO().ListarTipoTra();
            CboTipo.DataSource = list;
            CboTipo.ValueMember = "id_tipo_tra";
            CboTipo.DisplayMember = "nombre_tipo_tra";
        }

        private void ModificarTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtApellido.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtPass.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateFeNac.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TxtEmail.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtTelefono.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtDireccion.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CboComuna.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CboTipo.Enabled = true;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            string codigo = "";
            if (comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedValue != null)
                {
                    codigo = Convert.ToString(comboBox2.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Trabajador> tec = new TrabajadorDAO().BuscarTrabajadorMod(codigo);

                        if (tec.Count > 0)
                        {
                           



                            Models.Trabajador tecn = tec[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = tecn.nombre_trab.ToString();
                            TxtApellido.Text = tecn.apellido.ToString();
                            TxtDireccion.Text = tecn.direccion.ToString();
                            TxtEmail.Text = tecn.email.ToString();
                            TxtPass.Text = tecn.password.ToString();
                            TxtTelefono.Text = tecn.telefono.ToString();
                            DateFeNac.Value = tecn.fec_nac;
                            CboComuna.SelectedValue = tecn.comuna_id_comuna;
                            CboTipo.SelectedValue = tecn.tipo_trab;
                            TxtRut.Text = tecn.rut.ToString();
                           

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
                Models.Trabajador trabajador = new Models.Trabajador();
                trabajador.nombre_trab = TxtNombre.Text;
                trabajador.apellido = TxtApellido.Text;
                trabajador.password = TxtPass.Text;
                trabajador.fec_nac = DateFeNac.Value;
                trabajador.email = TxtEmail.Text;
                trabajador.telefono = Convert.ToInt32(TxtTelefono.Text);
                trabajador.direccion = TxtDireccion.Text;
                trabajador.comuna_id_comuna = Convert.ToInt32(CboComuna.SelectedValue);
                trabajador.tipo_trab = Convert.ToInt32(CboTipo.SelectedValue);
                trabajador.rut = TxtRut.Text;
                if (new TrabajadorDAO().EditarTrabajador(trabajador))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("No modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Revise datos!");
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
    }
}
    

