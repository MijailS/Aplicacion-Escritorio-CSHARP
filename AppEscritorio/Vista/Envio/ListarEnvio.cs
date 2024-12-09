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
    public partial class ListarEnvio : Form
    {
        public ListarEnvio()
        {
            InitializeComponent();

            List<Models.Envio> envio = new EnvioDAO().ListarEnvio().ToList();
            metroGrid1.DataSource = envio;
        }

        private void ListarEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
