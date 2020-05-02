using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaentidades;
using capanegocio;

namespace capaPresentacionRecetaMedica
{
    public partial class fRecetaMedica : Form
    {
        logicanegocioreceta logicaNRC = new logicanegocioreceta();

        public fRecetaMedica()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    recetamedica objetoRecetaMedica = new recetamedica();
                    objetoRecetaMedica.nombremedicamento = textBoxNombreMedicamento.Text;
                    objetoRecetaMedica.cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    objetoRecetaMedica.indicaciones = textBoxIndicaciones.Text;

                    if (logicaNRC.insertarreceta(objetoRecetaMedica) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRecetaMedica.DataSource = logicaNRC.listarreceta();
                        textBoxNombreMedicamento.Text = "";
                        textBoxCantidad.Text = "";
                        textBoxIndicaciones.Text = "";
                        tabRecetaMedica.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Receta Medica");
                    }

                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    recetamedica objetoRecetaMedica = new recetamedica();
                    objetoRecetaMedica.nombremedicamento = textBoxNombreMedicamento.Text;
                    objetoRecetaMedica.cantidad = Convert.ToInt32(textBoxCantidad.Text);
                    objetoRecetaMedica.indicaciones = textBoxIndicaciones.Text;

                    if (logicaNRC.editarreceta(objetoRecetaMedica) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRecetaMedica.DataSource = logicaNRC.listarreceta();
                        textBoxNombreMedicamento.Text = "";
                        textBoxCantidad.Text = "";
                        textBoxIndicaciones.Text = "";
                        tabRecetaMedica.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Receta Medica");
                    }
                    buttonGuardar.Text = "GUARDAR";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");                
            }
        }
    }
}
