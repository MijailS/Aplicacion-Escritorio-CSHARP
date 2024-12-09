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
    public partial class AgregarBoleta : Form
    {
        public AgregarBoleta()
        {
            InitializeComponent();
            List<Models.Venta> listado = new VentaDAO().listar().ToList();
            CboVenta_Id.DataSource = listado;
            CboVenta_Id.DisplayMember = "id_venta";
            CboVenta_Id.ValueMember = "id_venta";
           

            List<Models.Insumo> Insumo = new InsumoDAO().ListarInsumos().ToList();
            CbOInsumo.DataSource = Insumo;
            CbOInsumo.DisplayMember = "nombre";
            CbOInsumo.ValueMember = "id";
           

            List<Models.Libro> libros = new LibroDAO().listar().ToList();
            CbolibroID.DataSource = libros;
            CbolibroID.DisplayMember = "titulo";
            CbolibroID.ValueMember = "id_libro";
       

            List<Models.Servicio> servicio= new ServicioDAO().ListarServicio().ToList();
            CboServicio_Id.DataSource = servicio;
            CboServicio_Id.DisplayMember = "nombre_servicio";
            CboServicio_Id.ValueMember = "id_servicio";
          
        }

       

        private void AgregarBoleta_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Models.Boleta boleta = new Models.Boleta();

                boleta.subtotal = Convert.ToInt32(TxtSubtotal.Text);
                boleta.venta_id_venta = Convert.ToInt32(CboVenta_Id.SelectedValue);
                boleta.servicio_id_servicio = Convert.ToInt32(CboServicio_Id.SelectedValue);
                boleta.insumo_id_sumo = Convert.ToInt32(CbOInsumo.SelectedValue);
                boleta.libro_id_libro = Convert.ToInt32(CbolibroID.SelectedValue);
                boleta.numero = 0;
                boleta.cantidad = Convert.ToInt32(TxtCantidad.Text);


                Console.WriteLine(boleta.servicio_id_servicio + " " + " " + boleta.venta_id_venta + " " + boleta.insumo_id_sumo + " " + boleta.libro_id_libro + " " + boleta.cantidad);

                if (new BoletaDAO().AgregarBoleta(boleta))
                {
                    MessageBox.Show("EXITO AL GUARDAR :D");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR :D");
                };
            }



            catch (Exception ex)
            {

                MessageBox.Show("revisar campos!: "+ ex.Message);
            }




        }

        private void CboVenta_Id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtSubtotal_KeyPress (object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;


        }

        private void TxtSubtotal_KeyPress_1(object sender, KeyPressEventArgs e)
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

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show("solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
            }


        }

        private void BtnUWU_Click(object sender, EventArgs e)
        {
            
        }
    }
}
