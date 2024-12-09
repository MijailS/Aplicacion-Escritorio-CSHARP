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

namespace AppEscritorio.Vista.Estado
{
    public partial class ModificarEstado : Form
    {
        public ModificarEstado()
        {
            InitializeComponent();
            List<Models.Estado> listado = new EstadoDAO().ListarEstado().ToList();
            comboBox1.DataSource = listado;
            comboBox1.ValueMember = "id_estado";
            comboBox1.DisplayMember = "nombre_estado";
            metroGrid1.DataSource = listado;

        }

        private void ModificarEstado_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedValue!= null)
                {
                    codigo = Convert.ToInt32(comboBox1.SelectedValue); /// error

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Estado> estado = new EstadoDAO().BuscarEstado(codigo);

                        if (estado.Count > 0)
                        {


                            Models.Estado est= estado[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = est.nombre_estado.ToString();
                            TxtId.Text = est.id_estado.ToString();
                            Console.WriteLine(1);
                         
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Estado estado = new Models.Estado();
                estado.id_estado = Convert.ToInt32(TxtId.Text);
                estado.nombre_estado = TxtNombre.Text;

                if (new EstadoDAO().EditarEstado(estado))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show(" NO Modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }
    }
}
