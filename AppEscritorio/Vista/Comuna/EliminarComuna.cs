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
    public partial class EliminarComuna : Form
    {
        public EliminarComuna()
        {
            InitializeComponent();
            List<Models.Comuna> listado = new ComunaDAO().ListarComuna().ToList();
            comboBox1.DataSource = listado;
            comboBox1.ValueMember = "id_comuna";
            comboBox1.DisplayMember = "nombre_comuna";
            
        }

        private void EliminarComuna_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(comboBox1.SelectedValue);

            if (new ComunaDAO().eliminarComuna(codigo))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MessageBox.Show("No eliminado");

            }
            }
    }
}
