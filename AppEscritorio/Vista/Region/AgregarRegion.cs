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
    public partial class AgregarRegion : Form
    {
        public AgregarRegion()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Region region = new Models.Region();

                region.nombre_region = TxtNombre.Text;
                region.id_region = 0;


                if (new RegionDAO().AgregarRegion(region))
                {
                    MessageBox.Show("EXITO AL GUARDAR :D");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR :D");
                };
            }
            catch (Exception)
            {

                MessageBox.Show("REVISE DATOS!");
            }
            
        }

        private void AgregarRegion_Load(object sender, EventArgs e)
        {

        }
    }
}
