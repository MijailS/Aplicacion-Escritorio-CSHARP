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

namespace AppEscritorio.Vista.Tipo_trabajador
{
    public partial class AgregarTipo_Trabajador : Form
    {
        public AgregarTipo_Trabajador()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
Models.Tipo_Trab tipo = new Models.Tipo_Trab();

            tipo.nombre_tipo_tra= TxtNombre.Text;
            tipo.id_tipo_tra= 0;


            if (new Tipo_TrabDAO().AgregarTipoTrab(tipo))
            {
                MessageBox.Show("EXITO AL GUARDAR :D");
            }
            else
            {
                MessageBox.Show("ERROR AL GUARDAR D:");
            };
            }
            catch (Exception)
            {

                MessageBox.Show("Revise datos!");
            }
            
        }
    }
}
