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
    public partial class AgregarEnvio : Form
    {
        public AgregarEnvio()
        {
            InitializeComponent();
            comboBox1.DataSource = new VentaDAO().listar().ToList();
            comboBox1.DisplayMember = "id_venta";
            comboBox1.DisplayMember = "id_venta";
        }

        private void AgregarEnvio_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Envio envio = new Models.Envio();

                envio.estado = txtNombre.Text;
                envio.venta_id_venta = ((AppEscritorio.Models.Venta)comboBox1.SelectedValue).id_venta;
                envio.id_envio = 1;

                if (new EnvioDAO().AgregarEnvio(envio))
                {
                    MessageBox.Show("Agregado");
                }
                else
                {
                    MessageBox.Show(" No Agregado");
                }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
