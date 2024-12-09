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
    public partial class ListarRetiro_Tienda : Form
    {
        public ListarRetiro_Tienda()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new RetiroDAO().ListarRetiro();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarRetiro_Tienda_Load(object sender, EventArgs e)
        {

        }
    }
}
