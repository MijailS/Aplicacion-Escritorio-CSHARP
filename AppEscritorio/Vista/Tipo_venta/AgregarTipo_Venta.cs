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

namespace AppEscritorio.Vista.Tipo_venta
{
    public partial class AgregarTipo_Venta : Form
    {
        public AgregarTipo_Venta()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
 Models.Tipo_Venta venta = new Models.Tipo_Venta();

            venta.nombre_tipo = TxtNombre.Text;
            venta.id_tipo= 0;


            if (new Tipo_VentaDAO().AgregarTipoVenta (venta))
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
                MessageBox.Show("revise datos!");
               
            }
           
        }

        private void AgregarTipo_Venta_Load(object sender, EventArgs e)
        {

        }
    }
}
