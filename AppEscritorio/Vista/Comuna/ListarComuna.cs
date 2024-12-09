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

namespace AppEscritorio.Vista.Comuna
{
    public partial class ListarComuna : Form
    {
        public ListarComuna()
        {
            InitializeComponent();
            List<Models.Comuna> listado = new ComunaDAO().ListarComuna();
            metroGrid1.DataSource = listado;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
