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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();

            this.BackColor = Color.Red;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = TxtRut.Text;
                string pass = TxtContrasenia.Text;

                 int tipotrab = new TrabajadorDAO().BuscarTrabajador(rut, pass);
                if(tipotrab == 500/* admin */ || tipotrab ==502/* Trabajador*/)
                {
                    
                    Inicio inicio = new Inicio();
                    inicio.TxtTipo.Text = Convert.ToString(tipotrab);
                    inicio.TxtRun.Text = TxtRut.Text;
                    this.Hide();
                    inicio.Show();
                    
                }
                else {
                    MessageBox.Show("ERROR EN CREDENCIALES");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR EN : " + ex.Message);
                
            }
            
            }

        private void Login_Load(object sender, EventArgs e)
        {
           

        }
    }
    
}
