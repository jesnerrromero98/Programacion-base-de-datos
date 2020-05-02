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

namespace capaPresentacionEspecialidad
{
    public partial class fEspecialidad : Form
    {
        logicanegocioespecialidad logicaNE = new logicanegocioespecialidad();

        public fEspecialidad()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    especialidad objetoEspecialidad = new especialidad();
                    objetoEspecialidad.nombrespecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.descespecialidad = textBoxDescripcionEspecialidad.Text;

                    if (logicaNE.insertarespecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewEspecialidad.DataSource = logicaNE.listarespecialidad();
                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescripcionEspecialidad.Text = "";
                        tabEspecialidad.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Especialidad");
                    }

                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    especialidad objetoEspecialidad = new especialidad();
                    objetoEspecialidad.nombrespecialidad = textBoxNombreEspecialidad.Text;
                    objetoEspecialidad.descespecialidad = textBoxDescripcionEspecialidad.Text;

                    if (logicaNE.editarespecialidad(objetoEspecialidad) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewEspecialidad.DataSource = logicaNE.listarespecialidad();
                        textBoxNombreEspecialidad.Text = "";
                        textBoxDescripcionEspecialidad.Text = "";
                        tabEspecialidad.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Especialidad");
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
