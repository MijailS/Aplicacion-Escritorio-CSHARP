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

namespace AppEscritorio.Vista.Servicio
{
    public partial class ModificarServicio : Form
    {
        public ModificarServicio()
        {
            InitializeComponent();
            List<Models.Servicio> servicio = new ServicioDAO().ListarServicio().ToList();
            comboBox1.DataSource = servicio;
            comboBox1.DisplayMember = "nombre_servicio";
            comboBox1.ValueMember = "id_servicio";
            metroGrid1.DataSource = servicio;

            List<Models.Tecnico> tecnico = new TecnicoDAO().ListarTecnico().ToList();
            CboTecnico.DataSource = tecnico;
            CboTecnico.DisplayMember = "nombre_completo";
            CboTecnico.ValueMember = "id_tecnico";
        
        
        
        }

        private void DateFeProgramada_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ModificarServicio_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombreServ.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtValor.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtObservacion.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateFeProgramada.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateFeRealizada.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CboTecnico.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                        List<Models.Servicio> servicio = new ServicioDAO().BuscarServicio(codigo);

                        if (servicio.Count > 0)
                        {
                            TxtID.Clear();
                            TxtNombreServ.Clear();
                            TxtObservacion.Clear();
                        
                            TxtValor.Clear();


                            Models.Servicio servicios = servicio[0]; // Acceder al primer objeto Boleta de la lista

                            TxtID.Text = servicios.id_servicio.ToString();
                            TxtNombreServ.Text = servicios.nombre_servicio.ToString();
                            TxtObservacion.Text =servicios.observacion.ToString();
                            CboTecnico.SelectedItem = servicios.tecnico_id_tecnico.ToString();
                            TxtNombreServ. Text = servicios.nombre_servicio.ToString();
                            TxtValor.Text =servicios.valor.ToString();
                            Console.WriteLine(3);



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
                Models.Servicio servicio = new Models.Servicio();
                servicio.nombre_servicio = TxtNombreServ.Text;
                servicio.valor = Convert.ToInt32(TxtValor.Text);
                servicio.observacion = TxtObservacion.Text;
                servicio.fecha_programada = DateFeProgramada.Value;
                servicio.fecha_programada = DateFeRealizada.Value;
                servicio.tecnico_id_tecnico = (int)Convert.ToInt32(CboTecnico.SelectedValue);
                servicio.id_servicio = (int)Convert.ToInt32(TxtID.Text);
                if (new ServicioDAO().EditarServicio(servicio))

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

                MessageBox.Show("Revise datos!");
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
