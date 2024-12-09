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

namespace AppEscritorio.Vista.Tipo_trabajador
{
    public partial class ModificarTipo_Trabajador : Form
    {
        public ModificarTipo_Trabajador()
        {
            InitializeComponent();
            
                comboBox2.Items.Clear();

                List<Models.Tipo_Trab> listado = new Tipo_TrabDAO().ListarTipoTra();
            metroGrid1.DataSource = listado;
            comboBox2.DataSource = listado;
            comboBox2.ValueMember = "id_tipo_tra";
            comboBox2.DisplayMember = "nombre_tipo_tra";
              
        }

        private void ModificarTipo_Trabajador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombreTipo.Enabled = true;

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo=0;
            if (comboBox2.SelectedValue != null)
            {
                codigo = Convert.ToInt32(comboBox2.SelectedValue);

                Console.WriteLine(codigo);
                try
                {
                    List<Models.Tipo_Trab> tec = new Tipo_TrabDAO().BuscarTipó(codigo);

                    if (tec.Count > 0)
                    {
                        TxtNombreTipo.Text = "";
                        TxtID.Text = "";


                        Models.Tipo_Trab tecn = tec[0]; // Acceder al primer objeto Boleta de la lista

                        TxtNombreTipo.Text = tecn.nombre_tipo_tra.ToString();
                        TxtID.Text = tecn.id_tipo_tra.ToString();

                        tec.Clear();/// solucion para que no se caiga
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
Models.Tipo_Trab tipo = new Models.Tipo_Trab();
            tipo.id_tipo_tra = Convert.ToInt32(TxtID.Text);
            tipo.nombre_tipo_tra = TxtNombreTipo.Text;
            if (new Tipo_TrabDAO().EditarTipoTrab(tipo))
            {
                MessageBox.Show("Modificado");
            }
            else { MessageBox.Show("No Modificado"); }
            }
            catch (Exception)
            {

                MessageBox.Show("Revise datos!");
            }
            
        }
    }
    
}
