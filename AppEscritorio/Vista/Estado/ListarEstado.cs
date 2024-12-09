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

namespace AppEscritorio.Vista.Estado
{
    public partial class ListarEstado : Form
    {
        public ListarEstado()
        {
            InitializeComponent();
            List<Models.Estado> listado = new EstadoDAO().ListarEstado();
            metroGrid1.DataSource = listado;
         
        }

        private void ListarEstado_Load(object sender, EventArgs e)
        {

        }
    }
}
