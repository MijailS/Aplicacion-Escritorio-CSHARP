using AppEscritorio.Vista.Boleta;
using AppEscritorio.Vista.Cliente;
using AppEscritorio.Vista.Insumo;
using AppEscritorio.Vista.Inventario;
using AppEscritorio.Vista.Libro;
using AppEscritorio.Vista.Pago;
using AppEscritorio.Vista.Region;
using AppEscritorio.Vista.Retiro_tienda;
using AppEscritorio.Vista.Servicio;
using AppEscritorio.Vista.Tecnico;
using AppEscritorio.Vista.Tipo_pago;
using AppEscritorio.Vista.Tipo_trabajador;
using AppEscritorio.Vista.Tipo_venta;
using AppEscritorio.Vista.Trabajador;
using AppEscritorio.Vista.Venta;
using AppEscritorio.Vista.Visitas;

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
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

    if (selectedIndex == 0)
    {
               
                Vista.Boleta.AgregarBoleta cliente = new Vista.Boleta.AgregarBoleta();
                cliente.Show();
            }
    else if (selectedIndex == 1)
    {
        // Acciones para el valor "Cliente"
        Vista.AgregarCliente cliente = new Vista.AgregarCliente();
        cliente.Show();
    }
    else if (selectedIndex == 2)
    {
        // Acciones para el valor "Insumo"
        Vista.AgregarInsumo insumo = new Vista.AgregarInsumo();
        insumo.Show();
    }
    else if (selectedIndex == 3)
    {
        // Acciones para el valor "Inventario"
        Vista.AgregarInventario inventario = new Vista.AgregarInventario();
        inventario.Show();
    }
    else if (selectedIndex == 4)
    {
        // Acciones para el valor "Libro"
        Vista.AgregarLibro libro = new Vista.AgregarLibro();
        libro.Show();
    }
    else if (selectedIndex == 5)
    {
        // Acciones para el valor "Pago"
        Vista.Pago.AgregarPago pago = new Vista.Pago.AgregarPago();
        pago.Show();
    }
    else if (selectedIndex == 6)
    {
        // Acciones para el valor "Region"
        Vista.Region.AgregarRegion region = new Vista.Region.AgregarRegion();
        region.Show();
    }
    else if (selectedIndex == 7)
    {
        // Acciones para el valor "Retiro_tienda"
        Vista.Retiro_tienda.AgregarRetiro_Tienda retiroTienda = new Vista.Retiro_tienda.AgregarRetiro_Tienda();
        retiroTienda.Show();
    }
    else if (selectedIndex == 8)
    {
        // Acciones para el valor "Servicio"
        Vista.Servicio.AgregarServicio servicio = new Vista.Servicio.AgregarServicio();
        servicio.Show();
    }
    else if (selectedIndex == 9)
    {
        // Acciones para el valor "Tecnico"
        Vista.Tecnico.AgregarTecnico tecnico = new Vista.Tecnico.AgregarTecnico();
        tecnico.Show();
    }
    else if (selectedIndex == 10)
    {
        // Acciones para el valor "Tipo_Pago"
        Vista.Tipo_pago.AgregarTipo_Pago tipoPago = new Vista.Tipo_pago.AgregarTipo_Pago();
        tipoPago.Show();
    }
    else if (selectedIndex == 11)
    {
        // Acciones para el valor "Tipo_Trabajador"
        Vista.Tipo_trabajador.AgregarTipo_Trabajador tipoTrabajador = new Vista.Tipo_trabajador.AgregarTipo_Trabajador();
        tipoTrabajador.Show();
    }
    else if (selectedIndex == 12)
    {
        // Acciones para el valor "Tipo_Venta"
        Vista.Tipo_venta.AgregarTipo_Venta tipoVenta = new Vista.Tipo_venta.AgregarTipo_Venta();
        tipoVenta.Show();
    }
    else if (selectedIndex == 13)
    {
        // Acciones para el valor "Trabajador"
        Vista.Trabajador.AgregarTrabajador trabajador = new Vista.Trabajador.AgregarTrabajador();
        trabajador.Show();
    }
    else if (selectedIndex == 14)
    {
        // Acciones para el valor "Venta"
        Vista.Venta.AgregarVenta venta = new Vista.Venta.AgregarVenta();
        venta.Show();
    }
    else if (selectedIndex == 15)
    {
        // Acciones para el valor "Visitas"
        Vista.Visitas.AgregarVisita visitas = new Vista.Visitas.AgregarVisita();
        visitas.Show();
    }
            else if (selectedIndex == 16)
            {
                // Acciones para el valor "Comuna"
                Vista.Comuna.AgregarComuna comuna = new Vista.Comuna.AgregarComuna();
                comuna.Show();
            }
            else if (selectedIndex == 17)
            {
                // Acciones para el valor "despacho"
                Vista.Despacho.AgregarDespacho visitas = new Vista.Despacho.AgregarDespacho();
                visitas.Show();
            }
            else if (selectedIndex == 18)
            {
                // Acciones para el valor "Envio"
                Vista.Envio.AgregarEnvio visitas = new Vista.Envio.AgregarEnvio();
                visitas.Show();
            }
            else if (selectedIndex == 19)
            {
                // Acciones para el valor "estado"
                Vista.Estado.AgregarEstado estado = new Vista.Estado.AgregarEstado();
                estado.Show();
            }
            

        }
        

        private void Administrar_Load(object sender, EventArgs e)
        {

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex == 0)
            {
                Vista.Boleta.ListarBoletas cliente = new Vista.Boleta.ListarBoletas();
                cliente.Show();
            }
            else if (selectedIndex == 1)
            {
                // Acciones para el valor "Cliente"
                Vista.Cliente.ListarClientes cliente = new Vista.Cliente.ListarClientes();
                cliente.Show();
            }
            else if (selectedIndex == 2)
            {
                // Acciones para el valor "Insumo"
                Vista.Insumo.ListarInsumos insumo = new Vista.Insumo.ListarInsumos();
                insumo.Show();
            }
            else if (selectedIndex == 3)
            {
                // Acciones para el valor "Inventario"
                Vista.Inventario.ListarInventario inventario = new Vista.Inventario.ListarInventario();
                inventario.Show();
            }
            else if (selectedIndex == 4)
            {
                // Acciones para el valor "Libro"
                Vista.ListadoLibros libro = new Vista.ListadoLibros();
                libro.Show();
            }
            else if (selectedIndex == 5)
            {
                // Acciones para el valor "Pago"
                Vista.Pago.ListarPago pago = new Vista.Pago.ListarPago();
                pago.Show();
            }
            else if (selectedIndex == 6)
            {
                // Acciones para el valor "Region"
                Vista.Region.ListarRegion region = new Vista.Region.ListarRegion();
                region.Show();
            }
            else if (selectedIndex == 7)
            {
                // Acciones para el valor "Retiro_tienda"
                Vista.Retiro_tienda.ListarRetiro_Tienda retiroTienda = new Vista.Retiro_tienda.ListarRetiro_Tienda();
                retiroTienda.Show();
            }
            else if (selectedIndex == 8)
            {
                // Acciones para el valor "Servicio"
                Vista.Servicio.ListarServicio servicio = new Vista.Servicio.ListarServicio();
                servicio.Show();
            }
            else if (selectedIndex == 9)
            {
                // Acciones para el valor "Tecnico"
                Vista.Tecnico.ListarTecnicos tecnico = new Vista.Tecnico.ListarTecnicos();
                tecnico.Show();
            }
            else if (selectedIndex == 10)
            {
                // Acciones para el valor "Tipo_Pago"
                Vista.Tipo_pago.ListarTipo_Pago tipoPago = new Vista.Tipo_pago.ListarTipo_Pago();
                tipoPago.Show();
            }
            else if (selectedIndex == 11)
            {
                // Acciones para el valor "Tipo_Trabajador"
                Vista.Tipo_trabajador.ListarTipo_Trabajador tipoTrabajador = new Vista.Tipo_trabajador.ListarTipo_Trabajador();
                tipoTrabajador.Show();
            }
            else if (selectedIndex == 12)
            {
                // Acciones para el valor "Tipo_Venta"
                Vista.Tipo_venta.ListarTipo_Venta tipoVenta = new Vista.Tipo_venta.ListarTipo_Venta();
                tipoVenta.Show();
            }
            else if (selectedIndex == 13)
            {
                // Acciones para el valor "Trabajador"
                Vista.Trabajador.ListarTrabajador trabajador = new Vista.Trabajador.ListarTrabajador();
                trabajador.Show();
            }
            else if (selectedIndex == 14)
            {
                // Acciones para el valor "Venta"
                Vista.Venta.ListarVentas venta = new Vista.Venta.ListarVentas();
                venta.Show();
            }
            else if (selectedIndex == 15)
            {
                // Acciones para el valor "Visitas"
                Vista.Visitas.ListarVisitas visitas = new Vista.Visitas.ListarVisitas();
                visitas.Show();
            }
            else if (selectedIndex == 16)
            {
                // Acciones para el valor "Comuna"
                Vista.Comuna.ListarComuna comuna = new Vista.Comuna.ListarComuna();
                comuna.Show();
            }
            else if (selectedIndex == 17)
            {
                // Acciones para el valor "despacho"
                Vista.Despacho.ListarDespacho visitas = new Vista.Despacho.ListarDespacho();
                visitas.Show();
            }
            else if (selectedIndex == 18)
            {
                // Acciones para el valor "Envio"
                Vista.Envio.ListarEnvio visitas = new Vista.Envio.ListarEnvio();
                visitas.Show();
            }
            else if (selectedIndex == 19)
            {
                // Acciones para el valor "estado"
                Vista.Estado.ListarEstado  estado = new Vista.Estado.ListarEstado();
                estado.Show();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex == 0)
            {
                Vista.Boleta.EliminarBoleta cliente = new Vista.Boleta.EliminarBoleta();
                cliente.Show();
            }
            else if (selectedIndex == 1)
            {
                // Acciones para el valor "Cliente"
                Vista.Cliente.EliminarCliente cliente = new Vista.Cliente.EliminarCliente();
                cliente.Show();
            }
            else if (selectedIndex == 2)
            {
                // Acciones para el valor "Insumo"
                Vista.EliminarInsumo insumo = new Vista.EliminarInsumo();
                insumo.Show();
            }
            else if (selectedIndex == 3)
            {
                // Acciones para el valor "Inventario"
                Vista.EliminarInventario inventario = new Vista.EliminarInventario();
                inventario.Show();
            }
            else if (selectedIndex == 4)
            {
                // Acciones para el valor "Libro"
                Vista.EliminarLibro libro = new Vista.EliminarLibro();
                libro.Show();
            }
            else if (selectedIndex == 5)
            {
                // Acciones para el valor "Pago"
                Vista.Pago.EliminarPago pago = new Vista.Pago.EliminarPago();
                pago.Show();
            }
            else if (selectedIndex == 6)
            {
                // Acciones para el valor "Region"
                Vista.Region.EliminarRegion_ region = new Vista.Region.EliminarRegion_();
                region.Show();
            }
            else if (selectedIndex == 7)
            {
                // Acciones para el valor "Retiro_tienda"
                Vista.Retiro_tienda.EliminarRetiro_Tienda retiroTienda = new Vista.Retiro_tienda.EliminarRetiro_Tienda();
                retiroTienda.Show();
            }
            else if (selectedIndex == 8)
            {
                // Acciones para el valor "Servicio"
                Vista.Servicio.EliminarServicio servicio = new Vista.Servicio.EliminarServicio();
                servicio.Show();
            }
            else if (selectedIndex == 9)
            {
                // Acciones para el valor "Tecnico"
                Vista.Tecnico.EliminarTecnico tecnico = new Vista.Tecnico.EliminarTecnico();
                tecnico.Show();
            }
            else if (selectedIndex == 10)
            {
                // Acciones para el valor "Tipo_Pago"
                Vista.Tipo_pago.EliminarTipo_Pago tipoPago = new Vista.Tipo_pago.EliminarTipo_Pago();
                tipoPago.Show();
            }
            else if (selectedIndex == 11)
            {
                // Acciones para el valor "Tipo_Trabajador"
                Vista.Tipo_trabajador.EliminarTipo_Trabajador tipoTrabajador = new Vista.Tipo_trabajador.EliminarTipo_Trabajador();
                tipoTrabajador.Show();
            }
            else if (selectedIndex == 12)
            {
                // Acciones para el valor "Tipo_Venta"
                Vista.Tipo_venta.EliminarTipo_Venta tipoVenta = new Vista.Tipo_venta.EliminarTipo_Venta();
                tipoVenta.Show();
            }
            else if (selectedIndex == 13)
            {
                // Acciones para el valor "Trabajador"
                Vista.Trabajador.EliminarTrabajador trabajador = new Vista.Trabajador.EliminarTrabajador();
                trabajador.TxtTipo.Text = TxtTipo.Text;
                trabajador.Show();
            }
            else if (selectedIndex == 14)
            {
                // Acciones para el valor "Venta"
                Vista.Venta.EliminarVenta venta = new Vista.Venta.EliminarVenta();
                venta.Show();
            }
            else if (selectedIndex == 15)
            {
                // Acciones para el valor "Venta"
                Vista.Visitas.EliminarVisita venta = new Vista.Visitas.EliminarVisita();
                venta.Show();
            }
            else if (selectedIndex == 16)
            {
                // Acciones para el valor "Comuna"
                Vista.Comuna.EliminarComuna comuna = new Vista.Comuna.EliminarComuna ();
                comuna.Show();
            }
            else if (selectedIndex == 17)
            {
                // Acciones para el valor "despacho"
                Vista.Despacho.EliminarDespacho visitas = new Vista.Despacho.EliminarDespacho();
                visitas.Show();
            }
            else if (selectedIndex == 18)
            {
                // Acciones para el valor "Envio"
                Vista.Envio.EliminarEnvio visitas = new Vista.Envio.EliminarEnvio();
                visitas.Show();
            }
            else if (selectedIndex == 19)
            {
                // Acciones para el valor "estado"
                Vista.Estado.EliminarEstado estado = new Vista.Estado.EliminarEstado();
                estado.Show();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex == 0)
            {

                Vista.Boleta.ModificarBoleta cliente = new Vista.Boleta.ModificarBoleta();
                cliente.Show();
            }
            else if (selectedIndex == 1)
            {
                // Acciones para el valor "Cliente"
                Vista.Cliente.ModificarCliente cliente = new Vista.Cliente.ModificarCliente();
                cliente.Show();
            }
            else if (selectedIndex == 2)
            {
                // Acciones para el valor "Insumo"
                Vista.Insumo.ModificarInsumos insumo = new Vista.Insumo.ModificarInsumos();
                insumo.Show();
            }
            else if (selectedIndex == 3)
            {
                // Acciones para el valor "Inventario"
                Vista.Inventario.ModificarInventario inventario = new Vista.Inventario.ModificarInventario();
                inventario.Show();
            }
            else if (selectedIndex == 4)
            {
                // Acciones para el valor "Libro"
                Vista.Libro.ModificarLibro libro = new Vista.Libro.ModificarLibro();
                libro.Show();
            }
            else if (selectedIndex == 5)
            {
                // Acciones para el valor "Pago"
                Vista.Pago.ModificarPago pago = new Vista.Pago.ModificarPago();
                pago.Show();
            }
            else if (selectedIndex == 6)
            {
                // Acciones para el valor "Region"
                Vista.Region.ModificarRegion region = new Vista.Region.ModificarRegion();
                region.Show();
            }
            else if (selectedIndex == 7)
            {
                // Acciones para el valor "Retiro_tienda"
                Vista.Retiro_tienda.ModificarRetiro_Tienda retiroTienda = new Vista.Retiro_tienda.ModificarRetiro_Tienda();
                retiroTienda.Show();
            }
            else if (selectedIndex == 8)
            {
                // Acciones para el valor "Servicio"
                Vista.Servicio.ModificarServicio servicio = new Vista.Servicio.ModificarServicio();
                servicio.Show();
            }
            else if (selectedIndex == 9)
            {
                // Acciones para el valor "Tecnico"
                Vista.Tecnico.ModificarTecnico tecnico = new Vista.Tecnico.ModificarTecnico();
                tecnico.Show();
            }
            else if (selectedIndex == 10)
            {
                // Acciones para el valor "Tipo_Pago"
                Vista.Tipo_pago.ModificarTipo_Pago tipoPago = new Vista.Tipo_pago.ModificarTipo_Pago();
                tipoPago.Show();
            }
            else if (selectedIndex == 11)
            {
                // Acciones para el valor "Tipo_Trabajador"
                Vista.Tipo_trabajador.ModificarTipo_Trabajador tipoTrabajador = new Vista.Tipo_trabajador.ModificarTipo_Trabajador();
                tipoTrabajador.Show();
            }
            else if (selectedIndex == 12)
            {
                // Acciones para el valor "Tipo_Venta"
                Vista.Tipo_venta.ModificarTipo_Venta tipoVenta = new Vista.Tipo_venta.ModificarTipo_Venta();
                tipoVenta.Show();
            }
            else if (selectedIndex == 13)
            {
                // Acciones para el valor "Trabajador"
                Vista.Trabajador.ModificarTrabajador trabajador = new Vista.Trabajador.ModificarTrabajador();
                trabajador.Show();
            }
            else if (selectedIndex == 14)
            {
                // Acciones para el valor "Venta"
                Vista.Venta.ModificarVenta venta = new Vista.Venta.ModificarVenta();
                venta.Show();
            }
            else if (selectedIndex == 15)
            {
                // Acciones para el valor "Visitas"
                Vista.Visitas.ModificarVisita visitas = new Vista.Visitas.ModificarVisita();
                visitas.Show();
            }
            else if (selectedIndex == 16)
            {
                // Acciones para el valor "Comuna"
                Vista.Comuna.ModificarComuna comuna = new Vista.Comuna.ModificarComuna();
                comuna.Show();
            }
            else if (selectedIndex == 17)
            {
                // Acciones para el valor "despacho"
                Vista.Despacho.ModificarDespacho visitas = new Vista.Despacho.ModificarDespacho();
                visitas.Show();
            }
            else if (selectedIndex == 18)
            {
                // Acciones para el valor "Envio"
                Vista.Envio.ModificarEnvio visitas = new Vista.Envio.ModificarEnvio();
                visitas.Show();
            }
            else if (selectedIndex == 19)
            {
                // Acciones para el valor "estado"
                Vista.Estado.ModificarEstado estado = new Vista.Estado.ModificarEstado();
                estado.Show();
            }
        }
    }
}
