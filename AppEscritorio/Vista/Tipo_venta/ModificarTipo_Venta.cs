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

namespace AppEscritorio.Vista.Tipo_venta
{
    public partial class ModificarTipo_Venta : Form
    {
        public ModificarTipo_Venta()
        {
            InitializeComponent();
            

                List<Models.Tipo_Venta> listado = new Tipo_VentaDAO().ListarTipoVenta();
            comboBox2.DataSource = listado;
            metroGrid1.DataSource = listado;
            comboBox2.ValueMember ="id_tipo" ;
            comboBox2.DisplayMember="nombre_tipo"; 


        }

        private void ModificarTipo_Venta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombre.Enabled = true;
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
                        List<Models.Tipo_Venta> tec = new Tipo_VentaDAO().BuscarTipoVenta(codigo);

                        if (tec.Count > 0)
                        {
                            TxtNombre.Text = "";
                            TxtID.Text = "";


                            Models.Tipo_Venta  tecn = tec[0]; // Acceder al primer objeto Boleta de la lista

                            TxtNombre.Text = tecn.nombre_tipo.ToString();
                            TxtID.Text = tecn.id_tipo.ToString();

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
                Models.Tipo_Venta tipo = new Models.Tipo_Venta();
                tipo.id_tipo = (int)Convert.ToInt32(TxtID.Text);
                tipo.nombre_tipo = TxtNombre.Text;

                if (new Tipo_VentaDAO().editarTipoVenta(tipo))
                {
                    MessageBox.Show("Modificado");
                }
                else
                {
                    MessageBox.Show("No Modificado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("revise datos!");
                
            }
           
        }
    }
}
