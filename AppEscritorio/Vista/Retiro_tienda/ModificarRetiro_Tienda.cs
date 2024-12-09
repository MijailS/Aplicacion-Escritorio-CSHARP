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

namespace AppEscritorio.Vista.Retiro_tienda
{
    public partial class ModificarRetiro_Tienda : Form
    {
        public ModificarRetiro_Tienda()
        {
            InitializeComponent();
            try
            {
                comboBox2.Items.Clear();

                List<Models.Retiro_Tienda> listado = new RetiroDAO().ListarRetiro();
                comboBox2.DataSource = listado;
                comboBox2.DisplayMember = "id_retiro";
                comboBox2.ValueMember = "id_retiro";
                metroGrid1.DataSource = listado;

                List<Models.Envio> lista = new EnvioDAO().ListarEnvio().ToList();
                CboVentaID.DataSource = lista;
                CboVentaID.DisplayMember = "estado";
                CboVentaID.ValueMember = "id_envio";


            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL LISTAR" + ex);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarRetiro_Tienda_Load(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            if (comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedValue != null)
                {
                    codigo = Convert.ToInt32(comboBox2.SelectedValue);

                    Console.WriteLine(codigo);
                    try
                    {
                        List<Models.Retiro_Tienda> retiro= new RetiroDAO().Buscar(codigo);

                        if (retiro.Count > 0)
                        {
                            TxtRetiroID.Clear();

                           

                            Models.Retiro_Tienda retiros= retiro[0]; // Acceder al primer objeto Boleta de la lista

                            TxtRetiroID.Text = retiros.id_retiro.ToString();
                            CboVentaID.SelectedItem = retiros.envio_id_envio.ToString();
                            Console.WriteLine(3);



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
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            CboVentaID.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Retiro_Tienda retiro = new Models.Retiro_Tienda();

                retiro.id_retiro = Convert.ToInt32(TxtRetiroID.Text);
                retiro.envio_id_envio = Convert.ToInt32(CboVentaID.SelectedValue);

                if (new RetiroDAO().EditarRetiro(retiro))
                {
                    MessageBox.Show("Modificado");
                }
                else { MessageBox.Show("No Modificado"); }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
