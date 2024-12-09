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

using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Formatting;
using AppEscritorio.Controlador;

namespace AppEscritorio.Vista
{
    public partial class Alphilia : Form
    {
       

        public Alphilia()
        {
          

            InitializeComponent();

            dgvlibros.DataSource = new AlphiliaDAO().ListarLibros();
            DgvInsumosAlphilia.DataSource = new AlphiliaDAO().ListarInsumos();
            
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Alphilia_Load(object sender, EventArgs e)
        {
         

 
           
        }

      
    }
}
