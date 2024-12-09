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
    public partial class ModificarPago : Form
    {
        public ModificarPago()
        {
            InitializeComponent();
            try
            {
                comboBox1.Items.Clear();

                List<Models.Pago> listado = new PagoDAO().ListarPago();
                comboBox1.DataSource = listado;
                metroGrid1.DataSource = listado;
                comboBox1.DisplayMember = "id_pago";
                comboBox1.ValueMember = "id_pago";


                List<Models.Venta> ventas = new VentaDAO().listar();
                List<Models.Tipo_pago> tipo = new TipoPagoDAO().ListarTipoPago();
                CboVenta.DataSource = ventas;
                CboVenta.DisplayMember = "fecha";
                CboVenta.ValueMember = "id_venta";

                cboTipo.DataSource = tipo;
                cboTipo.DisplayMember = "nombre_tipo_pago";
                cboTipo.ValueMember = "id_tipo_pago";


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void ModificarPago_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtMonto.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             CboVenta.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cboTipo.Enabled = true;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox1.SelectedItem != null)
            {
                if (comboBox1.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox1.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Pago> paguito= new PagoDAO().BuscarPago(codigo);

                        if (paguito.Count > 0)
                        {
                            TxtIdPago.Clear();

                            TxtMonto.Clear();
                        

                            Models.Pago pago = paguito[0]; // Acceder al primer objeto Boleta de la lista

                            TxtIdPago.Text = pago.id_pago.ToString();
                            TxtMonto.Text = pago.monto.ToString();
                            Console.WriteLine(1);
                            cboTipo.SelectedItem= pago.tipo_pago_id_tipo_pago.ToString();
                            Console.WriteLine(2);
                            CboVenta.SelectedItem= pago.venta_id_venta.ToString();
                            Console.WriteLine(3);
                 


                        }


                        else
                        {
                            Console.WriteLine("No se encontraron datos para el código seleccionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR INESPERADO!: " + ex.Message);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                Models.Pago pago = new Models.Pago();
                pago.monto = Convert.ToInt32(TxtMonto.Text);
                pago.venta_id_venta = Convert.ToInt32(CboVenta.SelectedValue);
                pago.tipo_pago_id_tipo_pago = Convert.ToInt32(cboTipo.SelectedValue);
                pago.id_pago = Convert.ToInt32(TxtIdPago.Text);

                if (new PagoDAO().EditarPago(pago))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("No Modificado");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("revisar datos!");
            }
            
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
