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

namespace AppEscritorio.Vista.Despacho
{
    public partial class ListarDespacho : Form
    {
        public ListarDespacho()
        {
         
            InitializeComponent();
            List<Models.Despacho> listado = new DespachoDAO().ListarDespacho();
            metroGrid1.DataSource = listado;
   
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarDespacho_Load(object sender, EventArgs e)
        {

        }
    }
}
