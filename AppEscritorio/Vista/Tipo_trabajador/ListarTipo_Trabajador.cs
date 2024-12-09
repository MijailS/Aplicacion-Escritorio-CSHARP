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

namespace AppEscritorio.Vista.Tipo_trabajador
{
    public partial class ListarTipo_Trabajador : Form
    {
        public ListarTipo_Trabajador()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new Tipo_TrabDAO().ListarTipoTra();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarTipo_Trabajador_Load(object sender, EventArgs e)
        {

        }
    }
}
