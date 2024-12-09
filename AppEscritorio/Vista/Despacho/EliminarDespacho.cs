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
    public partial class EliminarDespacho : Form
    {
        public EliminarDespacho()
        {
            InitializeComponent();
            List<Models.Despacho> listado = new DespachoDAO().ListarDespacho();
            comboBox1.DataSource = listado;
            comboBox1.ValueMember = "id_despacho";
            comboBox1.DisplayMember = "id_despacho";

        }

        private void EliminarDespacho_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(comboBox1.SelectedValue);


            try
            {
                if (new DespachoDAO().eliminarDespacho(codigo))
                {
                    MessageBox.Show("Eliminado");
                    comboBox1.Items.Clear();

                }
                else
                {
                    MessageBox.Show(" No Eliminado");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
