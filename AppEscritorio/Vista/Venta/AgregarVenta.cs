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

namespace AppEscritorio.Vista.Venta
{
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
            List<Models.Cliente> clientes= new ClienteDAO().ListarClientes().ToList();
            CboRutCliente.DataSource = clientes;
            CboRutCliente.DisplayMember = "run";
            CboRutCliente.ValueMember = "run";
          

            List<Models.Tipo_Venta> tipo_Ventas = new Tipo_VentaDAO().ListarTipoVenta().ToList();
            CboTipoVenta.DataSource = tipo_Ventas;
            CboTipoVenta.DisplayMember = "nombre_tipo";
            CboTipoVenta.ValueMember = "id_tipo";
          

           
            

            List<Models.Estado> estado = new EstadoDAO().ListarEstado().ToList();
            CboEstado.DataSource = estado;
            CboEstado.DisplayMember = "nombre_estado";
            CboEstado.ValueMember = "id_estado";
           


            List<Models.Trabajador> trabajadores = new TrabajadorDAO().ListarTrabajador().ToList();
            CboTrabajador.DataSource = trabajadores;
            CboTrabajador.DisplayMember = "nombre_trab";
            CboTrabajador.ValueMember = "rut";
          
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Models.Venta venta = new Models.Venta();


                int Mventa = (int)Convert.ToDecimal(TxtTotalVenta.Text);
                int iva = (int)(Mventa * 0.19);
                venta.id_venta = 0;
                venta.fecha = dateTimePicker1.Value;
                venta.total_venta = Convert.ToInt32(TxtTotalVenta.Text);
                venta.iva = iva;
                venta.cliente_run = Convert.ToString(CboRutCliente.SelectedValue);
                venta.tipo_id_venta = Convert.ToInt32(CboTipoVenta.SelectedValue);
                venta.estado_id_estado = Convert.ToInt32(CboEstado.SelectedValue);
                venta.trabajador_run = Convert.ToString(CboTrabajador.SelectedValue);



                if (new VentaDAO().GenerarVenta(venta))
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

        private void AgregarVenta_Load(object sender, EventArgs e)
        {

        }

        private void TxtTotalVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotalVenta_KeyPress(object sender, KeyPressEventArgs e)
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
