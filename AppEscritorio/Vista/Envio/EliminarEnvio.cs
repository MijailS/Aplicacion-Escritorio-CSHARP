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
    public partial class EliminarEnvio : Form
    {
        public EliminarEnvio()
        {
            InitializeComponent();
            List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
            comboBox1.DataSource = envio;
            comboBox1.DisplayMember = "estado";
            comboBox1.ValueMember = "id_envio";
        }

        private void EliminarEnvio_Load(object sender, EventArgs e)
        {
          
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(comboBox1.SelectedValue);


            try
            {
                if (new EnvioDAO().EliminarEnvio(codigo))
                {
                    MessageBox.Show("Eliminado");
                    comboBox1.Items.Clear();
                   

                }
                else
                {
                    MessageBox.Show(" No Eliminado");

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
