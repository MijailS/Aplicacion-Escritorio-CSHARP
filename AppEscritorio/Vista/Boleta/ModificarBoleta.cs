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

namespace AppEscritorio.Vista.Boleta
{
    public partial class ModificarBoleta : Form
    {
        public ModificarBoleta()
        {
            InitializeComponent();
            List<Models.Venta> listado = new VentaDAO().listar().ToList();
            CboVentaID.DataSource = listado;
            CboVentaID.DisplayMember = "id_venta";
            CboVentaID.ValueMember = "id_venta";


            List<Models.Insumo> Insumo = new InsumoDAO().ListarInsumos().ToList();
            CboInsumoID.DataSource = Insumo;
            CboInsumoID.DisplayMember = "nombre";
            CboInsumoID.ValueMember = "id";


            List<Models.Libro> libros = new LibroDAO().listar().ToList();
            CboLibroID.DataSource = libros;
            CboLibroID.DisplayMember = "titulo";
            CboLibroID.ValueMember = "id_libro";


            List<Models.Servicio> servicio = new ServicioDAO().ListarServicio().ToList();
            CboServicioID.DataSource = servicio;
            CboServicioID.DisplayMember = "nombre_servicio";
            CboServicioID.ValueMember = "id_servicio";

            List<Models.Boleta> boletas = new BoletaDAO().ListarBoleta().ToList();
            comboBox1.DataSource = boletas;
            comboBox1.DisplayMember = "numero";
            comboBox1.ValueMember = "numero";

            try
            {
                MgvListado.DataSource = new BoletaDAO().ListarBoleta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CboServicioID.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtSubtotal.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CboVentaID.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CboInsumoID.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CboLibroID.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TxtCantidad.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void ModificarBoleta_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
                        List<Models.Boleta> datos = new BoletaDAO().BuscarBoleta(codigo);

                        if (datos.Count > 0)
                        {
                            TxtCantidad.Clear();
                            //CboInsumoID.Items.Clear();
                            TxtSubtotal.Clear();
                            //CboServicioID.Items.Clear();
                            //CboLibroID.Items.Clear();
                            TxtNumero.Clear();
                            //CboVentaID.Items.Clear();
                            Models.Boleta boleta = datos[0]; // Acceder al primer objeto Boleta de la lista

                            TxtCantidad.Text = boleta.cantidad.ToString();
                            CboInsumoID.SelectedItem = boleta.insumo_id_sumo.ToString();
                            Console.WriteLine(1);
                            TxtSubtotal.Text = boleta.subtotal.ToString();
                            Console.WriteLine(2);
                            CboServicioID.SelectedItem= boleta.servicio_id_servicio.ToString();
                            Console.WriteLine(3);
                            CboLibroID.SelectedItem = boleta.libro_id_libro.ToString();
                            Console.WriteLine(4);
                            TxtNumero.Text = boleta.numero.ToString();
                            Console.WriteLine(5);
                            CboVentaID.SelectedItem = boleta.venta_id_venta.ToString();
                            Console.WriteLine(6);



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
                if (TxtNumero.TextLength != 0)
                {
                    Models.Boleta boleta = new Models.Boleta();


                    boleta.cantidad = Convert.ToInt32(TxtCantidad.Text);
                    boleta.insumo_id_sumo = Convert.ToInt32(CboInsumoID.SelectedValue);
                    boleta.libro_id_libro = Convert.ToInt32(CboLibroID.SelectedValue);
                    boleta.servicio_id_servicio = Convert.ToInt32(CboServicioID.SelectedValue);
                    boleta.venta_id_venta = Convert.ToInt32(CboVentaID.SelectedValue);
                    boleta.numero = Convert.ToInt32(TxtNumero.Text);
                    boleta.subtotal = Convert.ToInt32(TxtSubtotal.Text);

                    if (new BoletaDAO().ModificarBoleta(boleta))
                    {
                        MessageBox.Show("Modificado ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("revisar campos!");
                
            }
           
        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
