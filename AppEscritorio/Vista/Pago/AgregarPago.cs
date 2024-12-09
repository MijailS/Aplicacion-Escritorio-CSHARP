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

namespace AppEscritorio.Vista.Pago
{
    public partial class AgregarPago : Form
    {
        public AgregarPago()
        {
            InitializeComponent();
            ///CboIDVenta
            try
            {
                CboIDVenta.Items.Clear();

                List<Models.Venta> venta = new VentaDAO().listar();
                foreach (Models.Venta solic in venta)
                {

                    CboIDVenta.Items.Add(solic.id_venta);
                }

                CboIDVenta.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }

            ///CboTipoPago
            try
            {
                CboTipoPago.Items.Clear();

                List<Models.Tipo_pago> tipo = new TipoPagoDAO().ListarTipoPago();
                foreach (Models.Tipo_pago solic in tipo)
                {

                    CboTipoPago.Items.Add(solic.id_tipo_pago);
                }

                CboTipoPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Models.Pago pago = new Models.Pago();

            pago.monto= Convert.ToInt32(TxtMonto.Text);
            pago.venta_id_venta= Convert.ToInt32(CboIDVenta.SelectedItem);
            pago.tipo_pago_id_tipo_pago= Convert.ToInt32(CboTipoPago.SelectedItem);
            pago.id_pago= 0;


            if (new PagoDAO().AgregarPago(pago))
            {
                MessageBox.Show("EXITO AL GUARDAR :D");
            }
            else
            {
                MessageBox.Show("ERROR AL GUARDAR :D");
            };
        }

        private void CboIDVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarPago_Load(object sender, EventArgs e)
        {

        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
    
}
