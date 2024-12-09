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

namespace AppEscritorio.Vista.Visitas
{
    public partial class ListarVisitas : Form
    {
        public ListarVisitas()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new VisitaDAO().ListarVisitas();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarVisitas_Load(object sender, EventArgs e)
        {

        }
    }
}
