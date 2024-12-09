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
    public partial class AgregarComuna : Form
    {
        public AgregarComuna()
        {
            InitializeComponent();
            List<Models.Region> listado = new RegionDAO().ListarRegion().ToList();
            comboBox1.DataSource = listado;
            comboBox1.ValueMember = "id_region";
            comboBox1.DisplayMember = "nombre_region";

        }

        private void AgregarComuna_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Comuna comuna = new Models.Comuna();
                comuna.id_comuna = 0;
                comuna.nombre_comuna = textBox1.Text;
                comuna.region_id_region = Convert.ToInt32(comboBox1.SelectedValue);

                if (new ComunaDAO().AgregarComuna(comuna))
                {
                    MessageBox.Show("AGREGADO");
                }
                else { MessageBox.Show("No agregado"); }
            }


            catch (Exception)
            {

                throw;
            }

        }
    }
}
