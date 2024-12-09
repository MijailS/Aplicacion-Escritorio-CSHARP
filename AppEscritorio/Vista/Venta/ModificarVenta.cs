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
    public partial class ModificarVenta : Form
    {
        public ModificarVenta()
        {
            InitializeComponent();
            
                comboBox2.Items.Clear();

                List<Models.Venta> listado = new VentaDAO().listar();
            comboBox2.DataSource = listado;
            metroGrid1.DataSource = listado;
            comboBox2.ValueMember = "id_venta";
            comboBox2.DisplayMember = "id_venta";

            List<Models.Tipo_Venta> lista = new Tipo_VentaDAO().ListarTipoVenta().ToList();
            CboVenta.DataSource = lista;
            CboVenta.DisplayMember = "nombre_tipo";
            CboVenta.ValueMember = "id_tipo";

            List<Models.Cliente> cliente = new ClienteDAO().ListarClientes().ToList();
            CboCliente.DataSource = cliente;
            CboCliente.ValueMember = "run";
            CboCliente.DisplayMember = "run";

         

            List<Models.Estado> estado = new EstadoDAO().ListarEstado().ToList();
            CboEstado.DataSource = estado;
            CboEstado.DisplayMember = "nombre_estado";
            CboEstado.ValueMember = "id_estado";

            List<Models.Trabajador> traba = new TrabajadorDAO().ListarTrabajador().ToList();
            CboTrabaRun.DataSource = traba;
            CboTrabaRun.DisplayMember = "Nombre";
            CboTrabaRun.ValueMember = "rut";
        }

        private void ModificarVenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CboTrabaRun.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CboEstado.Enabled = true;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            CboVenta.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CboCliente.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TxtIva.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TxtTotalVenta.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DateFecha.Enabled = true;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox2.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Venta> tec = new VentaDAO().BuscarVenta(codigo);

                        if (tec.Count > 0)
                        {



                            Models.Venta venta = tec[0]; // Acceder al primer objeto Boleta de la lista

                            CboTrabaRun.SelectedItem = venta.trabajador_run.ToString();
                            CboEstado.SelectedItem = venta.estado_id_estado.ToString();
                          
                            CboVenta.SelectedItem = venta.id_venta.ToString();
                            CboCliente.SelectedItem = venta.cliente_run.ToString();
                            TxtIva.Text = venta.iva.ToString();
                            TxtTotalVenta.Text = venta.total_venta.ToString();
                            DateFecha.Value = venta.fecha;
                            TxtIDVenta.Text = venta.id_venta.ToString();

                            tec.Clear();
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
Models.Venta venta = new Models.Venta();
            venta.trabajador_run = Convert.ToString(CboTrabaRun.SelectedValue);
            venta.estado_id_estado = Convert.ToInt32(CboEstado.SelectedValue);
            venta.tipo_id_venta = Convert.ToInt32(CboVenta.SelectedValue);
            venta.cliente_run = Convert.ToString(CboCliente.SelectedValue);
            venta.iva = Convert.ToInt32(TxtIva.Text);
            venta.total_venta = Convert.ToInt32(TxtTotalVenta.Text);
            venta.fecha = DateFecha.Value;
            venta.id_venta = Convert.ToInt32(TxtIDVenta.Text);

            if (new VentaDAO().EditarVenta(venta))
            {
                MessageBox.Show("Modificado");
            }
            else {
                MessageBox.Show("No Modificado");
            }
            }
            catch (Exception)
            {

                MessageBox.Show("Revise los datos!");
            }
                
        }

        private void TxtIva_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
