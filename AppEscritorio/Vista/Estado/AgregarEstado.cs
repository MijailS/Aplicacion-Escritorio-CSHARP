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
    public partial class AgregarEstado : Form
    {
        public AgregarEstado()
        {
            InitializeComponent();
        }

        private void AgregarEstado_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Estado estado = new Models.Estado();

                estado.nombre_estado = textBox1.Text;
                estado.id_estado = 1;


                if (new EstadoDAO().AgregarEstado(estado))
                {
                    MessageBox.Show("Agregado");
                }
                else
                {
                    MessageBox.Show("No Agregado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }
          
        }
    }
}
