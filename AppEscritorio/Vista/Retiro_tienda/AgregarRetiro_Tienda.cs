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

namespace AppEscritorio.Vista.Retiro_tienda
{
    public partial class AgregarRetiro_Tienda : Form
    {
        public AgregarRetiro_Tienda()
        {
            InitializeComponent();
            ///CboIdEnvio
            try
            {
                List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
                CboIdEnvio.DataSource = envio;
                CboIdEnvio.DisplayMember = "id_envio";
                CboIdEnvio.ValueMember = "id_envio";


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
            ///CboIdRetiroTienda
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Models.Retiro_Tienda retiro = new Models.Retiro_Tienda();

            retiro.id_retiro = 1;

            retiro.envio_id_envio = (int) Convert.ToInt32(CboIdEnvio.SelectedValue);

            if (new RetiroDAO().AgregarRetiro(retiro))
            {
                MessageBox.Show("EXITO AL GUARDAR :D");
            }
            else
            {
                MessageBox.Show("ERROR AL GUARDAR :D");
            };
        }

        private void AgregarRetiro_Tienda_Load(object sender, EventArgs e)
        {

        }

        private void CboIdEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
