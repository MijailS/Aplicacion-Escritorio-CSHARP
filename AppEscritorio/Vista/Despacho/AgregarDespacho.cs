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

namespace AppEscritorio.Vista.Despacho
{
    public partial class AgregarDespacho : Form
    {
        public AgregarDespacho()
        {
            InitializeComponent();
            List<Models.Comuna> listado = new ComunaDAO().ListarComuna().ToList();
            CboComuna.DataSource = listado;
            CboComuna.ValueMember = "id_comuna";
            CboComuna.DisplayMember = "nombre_comuna";

            List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
            CboEnvio.DataSource = envio;
            CboEnvio.DisplayMember = "estado";
            CboEnvio.ValueMember = "id_envio";

            List<Models.Estado> estado = new EstadoDAO().ListarEstado().ToList();
            CboEstado.DataSource = estado;
            CboEstado.DisplayMember = "nombre_estado";
            CboEstado.ValueMember = "id_estado";
        }

        private void AgregarDespacho_Load(object sender, EventArgs e)
        {

        }

        private void AgregarDespacho_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                Models.Despacho despacho = new Models.Despacho();
                despacho.id_despacho = 0;
                despacho.comuna_id_comuna = Convert.ToInt32(CboComuna.SelectedValue);
                despacho.direccion = TxtDireccion.Text;
                despacho.envio_id_envio = Convert.ToInt32(CboEnvio.SelectedValue);
                despacho.estado_id_estado = Convert.ToInt32(CboEstado.SelectedValue);
                despacho.telefono = Convert.ToInt32(TxtTelefono.Text);

                if (new DespachoDAO().AgregarDespacho(despacho))
                {
                    MessageBox.Show("Agregado");
                }
                else
                {
                    MessageBox.Show("No agregado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar campos!");
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

        private void CboEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
