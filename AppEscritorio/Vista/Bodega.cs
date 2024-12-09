using AppEscritorio.Vista;
using AppEscritorio.Vista.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Bodega : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE =orcl; PASSWORD= 1234 ;USER ID=REPARTO"); ///SE DEBE CAMBIAR ESTOS PARAMETROS SEGUN LAS ESPECIFICACIONES DE LA BASE DE DATOS

        public Bodega()
        {

            InitializeComponent();
        }

      

        private void Binicio_Click(object sender, EventArgs e)
        {
            
        }

        private void Bbodega_Click(object sender, EventArgs e)
        {

        }

        private void Balphilia_Click(object sender, EventArgs e)
        {
            
        }

        private void BSolicitudes_Click(object sender, EventArgs e)
        {

        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (AgregarInventario agregarinventario= new AgregarInventario())
                agregarinventario.ShowDialog();
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarInventario eliminarInventario = new EliminarInventario();
            eliminarInventario.Show();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarInventario listarInventario = new ListarInventario();
            
            listarInventario.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ModificarInventario listarInventario = new ModificarInventario();

            listarInventario.Show();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
