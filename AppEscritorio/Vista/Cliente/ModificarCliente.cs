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

namespace AppEscritorio.Vista.Cliente
{
    public partial class ModificarCliente : Form
    {
        public ModificarCliente()
        {
            InitializeComponent();
            try
            {
                comboBox1.Items.Clear();

                List<Models.Cliente> clientes= new ClienteDAO().ListarClientes().ToList();
                comboBox1.DataSource = clientes;
                comboBox1.DisplayMember = "run";
                comboBox1.ValueMember = "run";

                metroGrid1.DataSource = clientes;
                List<Models.Comuna> comuna= new ComunaDAO().ListarComuna().ToList();
                CboComuna.DataSource = comuna;
                CboComuna.DisplayMember = "nombre_comuna";
                CboComuna.ValueMember = "id_comuna";

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }



        }

        private void ModificarCliente_Load(object sender, EventArgs e)
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
            TxtTelefono.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TxtDireccion.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CboComuna.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
           string codigo = "";
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedValue is string selectItem)
                {
                  codigo =  Convert.ToString(comboBox1.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Cliente> clientes = new ClienteDAO().BuscarCliente(codigo);

                        if (clientes.Count > 0)
                        {
                            TxtNombre.Clear();

                            TxtApellido.Clear();
                    
                            TxtRun.Clear();
                            TxtDireccion.Clear();

                            Models.Cliente cliente= clientes[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = cliente.nombre.ToString();
                            TxtApellido.Text = cliente.apellido.ToString();
                            Console.WriteLine(1);
                            TxtTelefono.Text = cliente.telefono.ToString();
                            Console.WriteLine(2);
                            CboComuna.SelectedItem = cliente.comuna_id.ToString();
                            Console.WriteLine(3);
                            TxtDireccion.Text = cliente.direccion.ToString();
                            TxtEmail.Text = cliente.email.ToString();
                            TxtRun.Text = cliente.run.ToString();
                            Console.WriteLine(5);
                    

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
                Models.Cliente cliente = new Models.Cliente();
                cliente.nombre = TxtNombre.Text;
                cliente.apellido = TxtApellido.Text;
                cliente.direccion = TxtDireccion.Text;
                cliente.email = TxtEmail.Text;
                cliente.comuna_id = Convert.ToInt32(CboComuna.SelectedValue);
                cliente.run = TxtRun.Text;
                cliente.telefono = Convert.ToInt32(TxtTelefono.Text);

                if (new ClienteDAO().ModificarCliente(cliente))
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

                MessageBox.Show("revisar campos!");
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtEmail.Enabled = true;
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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
