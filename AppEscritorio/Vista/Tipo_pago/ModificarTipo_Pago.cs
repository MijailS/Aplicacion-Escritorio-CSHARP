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

namespace AppEscritorio.Vista.Tipo_pago
{
    public partial class ModificarTipo_Pago : Form
    {
        public ModificarTipo_Pago()
        {
            InitializeComponent();
           
               

                List<Models.Tipo_pago> listado = new TipoPagoDAO().ListarTipoPago();

                comboBox2.DataSource = listado;
                metroGrid1.DataSource = listado;
                comboBox2.ValueMember = "id_tipo_pago";
                comboBox2.DisplayMember = "nombre_tipo_pago";
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
        }

        private void ModificarTipo_Pago_Load(object sender, EventArgs e)
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
                        List<Models.Tipo_pago> tec = new TipoPagoDAO().BuscarTipo(codigo);

                        if (tec.Count > 0)
                        {
                            TxtNombre.Text = "";
                            TxtTipoID.Text = "";


                            Models.Tipo_pago tecn = tec[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = tecn.nombre_tipo_pago.ToString();
                            TxtTipoID.Text = tecn.id_tipo_pago.ToString(); 

                            tec.Clear();/// solucion para que no se caiga
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
Models.Tipo_pago tipo = new Models.Tipo_pago();
            tipo.id_tipo_pago = Convert.ToInt32(TxtTipoID.Text);//ERROR
            tipo.nombre_tipo_pago = TxtNombre.Text;
            //if (new TipoPagoDAO())
            {
                if (new TipoPagoDAO().EditarTipo(tipo))
                {
                    MessageBox.Show("Modifificado");
                }
                else {

                    MessageBox.Show("No Modifificado");
                }
            }
            }
            catch (Exception)
            {

                MessageBox.Show("revise datos");
            }
            
        }
    }
}
