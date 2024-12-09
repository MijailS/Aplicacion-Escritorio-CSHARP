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
    public partial class AgregarServicio : Form
    {
        public AgregarServicio()
        {
            InitializeComponent();
            List<Models.Tecnico> listado = new TecnicoDAO().ListarTecnico();
            CboTecnicoID.DataSource = listado;
            CboTecnicoID.DisplayMember = "nombre_completo";
            CboTecnicoID.ValueMember = "id_tecnico";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Servicio servicio = new Models.Servicio();

                servicio.nombre_servicio = TxtNombreServ.Text;
                servicio.id_servicio = 1;
                servicio.valor = Convert.ToInt32(TxtValor.Text);
                servicio.observacion = TxtObservacion.Text;
                servicio.fecha_programada = DtFechaProgramada.Value;
                servicio.fecha_realizado = DtFechaRealizadaa.Value;
                servicio.tecnico_id_tecnico = Convert.ToInt32(CboTecnicoID.SelectedValue);

                if (new ServicioDAO().AgregarServicio(servicio))
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

        private void CboTecnicoID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {

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
