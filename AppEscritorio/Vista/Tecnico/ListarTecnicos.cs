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

namespace AppEscritorio.Vista.Tecnico
{
    public partial class ListarTecnicos : Form
    {
        public ListarTecnicos()
        {
            InitializeComponent();
            try
            {
                MgvListado.DataSource = new TecnicoDAO().ListarTecnico();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ListarTecnicos_Load(object sender, EventArgs e)
        {

        }
    }
}
