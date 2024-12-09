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

namespace AppEscritorio.Vista
{
    public partial class HacerVenta : Form
    {
        public HacerVenta()
        {
            List<Models.Boleta> bolet = new List<Models.Boleta>();
            InitializeComponent();

            //cboLibro
            List<Models.Insumo> Insumo = new InsumoDAO().ListarInsumos().ToList();
            CboInsumo.DataSource = Insumo;
            CboInsumo.DisplayMember = "nombre";
            CboInsumo.ValueMember = "id";

            

            List<Models.Libro> libros = new LibroDAO().listar().ToList();
            CbolibroID.DataSource = libros;
            CbolibroID.DisplayMember = "titulo";
            CbolibroID.ValueMember = "id_libro";


            List<Models.Servicio> servicio = new ServicioDAO().ListarServicio().ToList();
            CboServicio_Id.DataSource = servicio;
            CboServicio_Id.DisplayMember = "nombre_servicio";
            CboServicio_Id.ValueMember = "id_servicio";

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
        


        private void LinkRegistrarCliente_Click(object sender, EventArgs e)
        {
            using (AgregarCliente agregar= new AgregarCliente())
                agregar.ShowDialog();
        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {

                int precioInsumo = Convert.ToInt32(TxtPrecioInsumo.Text);
                int precioLibro = Convert.ToInt32(TxtPrecioLibro.Text);
                int precioServicio = Convert.ToInt32(TxtPrecioServicio.Text);

                int total = precioInsumo + precioLibro + precioServicio;
                double iva = (double)total * 0.19;
                Models.Boleta bo = new Models.Boleta();

                var rut = TxtRunCliente;
                bo.servicio_id_servicio = (int)Convert.ToInt32(CboServicio_Id.SelectedValue);
                bo.libro_id_libro = (int)Convert.ToInt32(CbolibroID.SelectedValue);
                bo.insumo_id_sumo = (int)Convert.ToInt32(CboInsumo.SelectedValue);
                int cantidad = 1;
                bo.cantidad = cantidad;
                

                Models.Venta ven = new Models.Venta();
                ven.cliente_run = TxtRunCliente.Text;
                ven.estado_id_estado = (int)Convert.ToInt32(CboEstado.SelectedValue);
                ven.fecha = DateTime.Now;
                ven.id_venta = 0;
                ven.iva = Convert.ToInt32(iva);
                ven.total_venta = total;
                ven.trabajador_run = Convert.ToString(CboTrabajador.SelectedValue);
                ven.tipo_id_venta = (int)Convert.ToInt32(CboTipoVenta.SelectedValue);
                int subtotal = (int)total - Convert.ToInt32(iva);
                bo.subtotal = subtotal;
               
                try
                {
                    if (new VentaDAO().GenerarVenta(ven))
                    {
                        try
                        {
                            int IdVenta = new VentaDAO().UltimaVenta();
                            if (IdVenta>0) {


                                try
                                {
                                    bo.venta_id_venta = IdVenta;
                                    if (new BoletaDAO().AgregarBoleta(bo))
                                    {
                                        MessageBox.Show("Boleta generada!");
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }

                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            catch (Exception)
            {

                throw;
            }

            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
           

        }

        private void CboInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var insumoSeleccionado = (Models.Insumo)CboInsumo.SelectedItem;

            TxtPrecioInsumo.Text = insumoSeleccionado.precio.ToString();
        }

        private void TxtPrecioInsumo_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrecioServicio_Click(object sender, EventArgs e)
        {

        }

        private void TxtPrecioLibro_Click(object sender, EventArgs e)
        {

        }

        private void CbolibroID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var libroSeleccionado = (Models.Libro)CbolibroID.SelectedItem;

            // Mostrar el precio del libro en el TextBox correspondiente
            TxtPrecioLibro.Text = libroSeleccionado.valor.ToString();
        }

        private void CboServicio_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            var servicioSeleccionado = (Models.Servicio)CboServicio_Id.SelectedItem;

            // Mostrar el precio del servicio en el TextBox correspondiente
            TxtPrecioServicio.Text = servicioSeleccionado.valor.ToString();
        }
    }
}
