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

namespace AppEscritorio.Vista.Tecnico
{
    public partial class AgregarTecnico : Form
    {
        public AgregarTecnico()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Tecnico tecnico = new Models.Tecnico();

                tecnico.nombre_completo = TxtNombre.Text;
                tecnico.id_tecnico = 0;


                if (new TecnicoDAO().AgregarTecnico(tecnico))
                {
                    MessageBox.Show("EXITO AL GUARDAR :D");
                }
                else
                {
                    MessageBox.Show("ERROR AL GUARDAR :D");
                };
            }
            catch (Exception)
            {

                MessageBox.Show("Revise datos!");
            }
            
        }
    }
}
