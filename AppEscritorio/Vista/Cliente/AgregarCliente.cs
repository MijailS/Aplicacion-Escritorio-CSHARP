using AppEscritorio.Controlador;
using AppEscritorio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio.Vista
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
            //cboComuna

            List<Models.Comuna> listado = new ComunaDAO().ListarComuna().ToList();
            CboListado.DataSource = listado;
            CboListado.ValueMember = "id_comuna";
            CboListado.DisplayMember = "nombre_comuna";





        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           

            try
            {
                string nom = TxtNombre.Text;
                int comuna = Convert.ToInt32(CboListado.SelectedValue);
                string ape = TxtApellido.Text;
                string run = TxtRun.Text;
                int tele = Convert.ToInt32(TxtTelefono.Text);
                string dire = TxtDireccion.Text;
                string email = TxtEmail.Text;

                Models.Cliente cliente = new Models.Cliente();
                cliente.nombre = nom;
                cliente.apellido = ape;
                cliente.run = run;
                cliente.telefono = tele;
                cliente.direccion = dire;
                cliente.comuna_id = comuna;
                cliente.email = email;


                if (new VentaDAO().AgregarCliente(cliente))
                {
                    MessageBox.Show("EXITO AL AGREGAR");

                    TxtNombre.Clear();

                    TxtApellido.Clear();
                    TxtRun.Clear();
                    TxtTelefono.Clear();
                    TxtDireccion.Clear();
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR ");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
            }

        }

        private void CboListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void TxtTelefono_Click(object sender, EventArgs e)
        {

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
