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

namespace AppEscritorio.Vista.Tipo_pago
{
    public partial class AgregarTipo_Pago : Form
    {
        public AgregarTipo_Pago()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
 Models.Tipo_pago tipo = new Models.Tipo_pago();

            tipo.nombre_tipo_pago = TxtNombre.Text;
            tipo.id_tipo_pago= 0;


            if (new TipoPagoDAO().AgregarTipoPago(tipo))
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

                throw;
            }
           
        }
    }
}
