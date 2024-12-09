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

namespace AppEscritorio.Vista.Visitas
{
    public partial class ModificarVisita : Form
    {
        public ModificarVisita()
        {
            InitializeComponent();

            List<Models.Visita> listado = new VisitaDAO().ListarVisitas().ToList();
            comboBox2.DataSource = listado;
            metroGrid1.DataSource = listado;
            comboBox2.DisplayMember = "id_visita";
            comboBox2.ValueMember = "id_visita";
            List<Models.Tecnico> tec = new TecnicoDAO().ListarTecnico().ToList();
            CboTecnico.DataSource = tec;
            CboTecnico.DisplayMember = "nombre_completo";
            CboTecnico.ValueMember = "id_tecnico";
        }

        private void ModificarVisita_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateFecha.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateHora.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtDescripcion.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CboTecnico.Enabled = true;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox2.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Visita> vi = new VisitaDAO().BuscarVisita(codigo);

                        if (vi.Count > 0)
                        {
                            

                            Models.Visita visi = vi[0]; // Acceder al primer objeto Boleta de la lista

                            DateFecha.Value = visi.fecha;
                            DateHora.Value=visi.hora;
                            TxtDescripcion.Text = visi.descripcion.ToString();
                            CboTecnico.SelectedItem = visi.tecnico_id_tecnico.ToString();
                            TxtVisitaID.Text = visi.id_visita.ToString();
                            vi.Clear();/// solucion para que no se caiga
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

                Models.Visita visita = new Models.Visita();
                visita.fecha = DateFecha.Value;
                visita.hora = DateHora.Value;
                visita.descripcion = TxtDescripcion.Text;
                visita.tecnico_id_tecnico = Convert.ToInt32(CboTecnico.SelectedValue);
                visita.id_visita = Convert.ToInt32(TxtVisitaID.Text);

                if (new VisitaDAO().EditarVisita(visita))
                {
                    MessageBox.Show("Modificado");
                }
                else { MessageBox.Show("No Modificado"); }
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
        }
    }
}
