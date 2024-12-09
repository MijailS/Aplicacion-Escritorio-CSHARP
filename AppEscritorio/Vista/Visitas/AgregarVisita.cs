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

namespace AppEscritorio.Vista.Visitas
{
    public partial class AgregarVisita : Form
    {
        public AgregarVisita()
        {
            InitializeComponent();

            List<Models.Tecnico> tecnico = new TecnicoDAO().ListarTecnico().ToList();
            CboTecnico.DataSource = tecnico;
            CboTecnico.DisplayMember = "nombre_completo";
            CboTecnico.ValueMember = "id_tecnico";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
Models.Visita visita= new Models.Visita();

            visita.id_visita = 0;
            visita.fecha = DtFecha.Value;
            visita.hora = DtHora.Value;
            visita.descripcion = TxtDesc.Text;
            visita.tecnico_id_tecnico = Convert.ToInt32(CboTecnico.SelectedValue);


            if (new VisitaDAO().AgregarVisita(visita))
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

        private void AgregarVisita_Load(object sender, EventArgs e)
        {

        }
    }
}
