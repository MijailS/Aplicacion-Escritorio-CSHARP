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

namespace AppEscritorio.Vista.Region
{
    public partial class ListarRegion : Form
    {
        public ListarRegion()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new RegionDAO().ListarRegion();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarRegion_Load(object sender, EventArgs e)
        {

        }
    }
}
