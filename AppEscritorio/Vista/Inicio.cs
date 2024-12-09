using AppEscritorio.Controlador;
using AppEscritorio.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Inicio : MetroFramework.Forms.MetroForm
    {
        public Inicio()
        {
            InitializeComponent();

            try
            {
                MGVSolicitudes.DataSource = new SolicitudDAO().ListarSolicitudes();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Solicitudes_Click(object sender, EventArgs e)
        {
            using (HacerVenta venta  = new HacerVenta())
                venta.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BcerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Binicio_Click(object sender, EventArgs e)
        {

        }

        private void Bbodega_Click(object sender, EventArgs e)
        {
            using (Bodega ventanaBodega = new Bodega())
                ventanaBodega.ShowDialog();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Balphilia_Click(object sender, EventArgs e)
        {

            if (TxtTipo.Text.Equals("500"))
            {
                Administrar administrar = new Administrar();

                administrar.TxtTipo.Text = TxtRun.Text;
                administrar.Show();
            }
            else
            {
                MessageBox.Show("ERROR NO TIENES PERMISOS NECESARIOS");

            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BinventarioLibros_Click(object sender, EventArgs e)
        {
            using (Alphilia alph = new Alphilia())
                alph.ShowDialog();
        }

        private void MGVSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGestionar_Click(object sender, EventArgs e)
        {
            using (GestionarSolicitudes gestionar = new GestionarSolicitudes())
                gestionar.ShowDialog();
        }

        private void TxtRun_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            Administrar admin = new Administrar();
            admin.ShowDialog();
        }
    }
}
