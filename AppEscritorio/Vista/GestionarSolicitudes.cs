using AppEscritorio.Controlador;
using AppEscritorio.Models;
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
    public partial class GestionarSolicitudes : Form
    {
        public GestionarSolicitudes()
        {
            InitializeComponent();

            try
            {
                CboListado.Items.Clear();

                List<Solicitud> soli = new SolicitudDAO().ListarSolicitudes().ToList();
                CboListado.DataSource = soli;
                CboListado.ValueMember = "id_venta";
                CboListado.DisplayMember = "id_venta";
                MGVSolicitudes.DataSource = new SolicitudDAO().ListarSolicitudes().ToList() ;

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = 0;

            if (CboListado.SelectedItem != null)
            {
                codigo =(int) Convert.ToInt32(CboListado.SelectedValue);


                try
                {
                    List<Models.Boleta> datos = new BoletaDAO().BuscarBoleta(codigo);

                    if (datos.Count > 0)
                    {
                        TxtCantidad.Clear();
                        TxtInsumo_id_Insumo.Clear();
                        TxtSubtotal.Clear();
                        TxtServicio_id_Servicio.Clear();
                        TxtLibro_id_libro.Clear();
                        TxtNumero.Clear();
                        TxtVenta_id_venta.Clear();
                        Models.Boleta boleta = datos[0]; // Acceder al primer objeto Boleta de la lista

                        TxtCantidad.Text = boleta.cantidad.ToString();
                        TxtInsumo_id_Insumo.Text = boleta.insumo_id_sumo.ToString();
                        TxtSubtotal.Text = boleta.subtotal.ToString();
                        TxtServicio_id_Servicio.Text = boleta.servicio_id_servicio.ToString();
                        TxtLibro_id_libro.Text = boleta.libro_id_libro.ToString();
                        TxtNumero.Text = boleta.numero.ToString();
                        TxtVenta_id_venta.Text = boleta.venta_id_venta.ToString();

                        int code = (int) new WsDespachoDAO().BuscarEnvio(Convert.ToInt32(TxtVenta_id_venta.Text)); 
                        List<Models.Despacho> des = new WsDespachoDAO().BuscarDespacho(code);
                        Models.Despacho despa = des.First();
                        TxtDespacho.Text = Convert.ToString(despa.id_despacho);
                        TxtDireccion.Text = despa.direccion;
                        TxtTelefono.Text = Convert.ToString(despa.telefono);
                        TxtComunaID.Text = Convert.ToString(despa.comuna_id_comuna);
                        TxtEstadoID.Text = Convert.ToString(despa.estado_id_estado);
                        TxtEnvioID.Text = Convert.ToString(despa.envio_id_envio);
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

        private void MGVSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CboListado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (CboListado.SelectedItem != null)
            {

                int codigo = (int)Convert.ToInt32(CboListado.SelectedValue);

                try
                {
                   if( new SolicitudDAO().AceptarSolicitud(codigo)==1) { 
                    MessageBox.Show("PEDIDO CONFIRMADO!");

                        wsDespacho.despacho desp = new wsDespacho.despacho();
                        desp.id_despacho =Convert.ToInt32( TxtDespacho.Text);
                        desp.direccion = Convert.ToString(TxtDireccion.Text);
                        desp.telefono = Convert.ToInt32(TxtTelefono.Text);
                        desp.comuna_id_comuna = Convert.ToInt32(TxtComunaID.Text);
                        desp.envio_id_envio = Convert.ToInt32(TxtDespacho.Text);
                        desp.estado_id_estado = Convert.ToInt32(TxtEstadoID.Text);




                        ////MANDAR SOLICITUD ACA A WS DE DESPACHO  :D
                        try
                        {
                            if (new WsDespachoDAO().EntregarDespacho(desp)==true)
                            {
                                MessageBox.Show("Envio De peticion de despacho!");
                            }
                            else {
                                MessageBox.Show("Envio De peticion de despacho!");
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(" ERROR !! Envio De peticion de despacho!" + ex.Message);
                        }
                       
                    }
                } 
                catch (Exception ex)
                {

                    MessageBox.Show(" ERROR !! Envio De peticion de despacho!" + ex.Message);
                }
                finally { 
                
                }
            }
            else {
                MessageBox.Show("ERROR AL CONFIRMAR PEDIDO");
            }

        }

        private void CboListado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void GestionarSolicitudes_Load(object sender, EventArgs e)
        {

        }
    }
}
