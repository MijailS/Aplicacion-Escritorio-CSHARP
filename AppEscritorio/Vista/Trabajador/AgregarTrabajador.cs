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

namespace AppEscritorio.Vista.Trabajador
{
    public partial class AgregarTrabajador : Form
    {
        public AgregarTrabajador()
        {
            InitializeComponent();
            List<Models.Comuna> comunas= new ComunaDAO().ListarComuna().ToList();
            CboComuna.DataSource = comunas;
            CboComuna.DisplayMember = "nombre_comuna";
            CboComuna.ValueMember = "id_comuna";

            List<Models.Tipo_Trab> tipo_Trabs= new Tipo_TrabDAO().ListarTipoTra().ToList();
            CboTipoTrab.DataSource = tipo_Trabs;
            CboTipoTrab.DisplayMember = "nombre_tipo_tra";
            CboTipoTrab.ValueMember = "id_tipo_tra";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Trabajador trabajador = new Models.Trabajador();

                trabajador.nombre_trab = TxtNombre.Text;
                trabajador.apellido = TxtApellido.Text;
                trabajador.rut = TxtRun.Text;
                trabajador.password = TxtPass.Text;
                trabajador.fec_nac = DtFec_Nac.Value;
                trabajador.email = TxtEmail.Text;
                trabajador.telefono = Convert.ToInt32(TxtTelefono.Text);
                trabajador.direccion = TxtApellido.Text;
                trabajador.comuna_id_comuna = Convert.ToInt32(CboComuna.SelectedValue);
                trabajador.tipo_trab = Convert.ToInt32(CboTipoTrab.SelectedValue);


                if (new TrabajadorDAO().AgregarTrabajador(trabajador))
                {
                    MessageBox.Show("EXITO AL GUARDAR :D");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR :D");
                };
            }
            catch (Exception)
            {

                MessageBox.Show("Revise datos!");
            }
            
        }

        private void AgregarTrabajador_Load(object sender, EventArgs e)
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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
