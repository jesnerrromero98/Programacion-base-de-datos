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

namespace capaPresentacionCita
{
    public partial class fCita : Form
    {
        logicanegociocita logicaNC = new logicanegociocita();

        public fCita()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    cita objetoCita = new cita();
                    objetoCita.nuevacitas = Convert.ToDateTime(textBoxNuevaCita.Text);
                    objetoCita.fechacita = Convert.ToDateTime(textBoxFechaCita.Text);
                    objetoCita.horadisponible = Convert.ToDateTime(textBoxHoraDisponible.Text);
                    objetoCita.precio = Convert.ToInt32(textBoxPrecio.Text);

                    if (logicaNC.insertarcita(objetoCita)>0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRegistrarCita.DataSource = logicaNC.listarcita();
                        textBoxNuevaCita.Text = "";
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponible.Text = "";
                        textBoxPrecio.Text = "";
                        tabCita.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Cita");
                    }

                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    cita objetoCita = new cita();
                    objetoCita.nuevacitas = Convert.ToDateTime(textBoxNuevaCita.Text);
                    objetoCita.fechacita = Convert.ToDateTime(textBoxFechaCita.Text);
                    objetoCita.horadisponible = Convert.ToDateTime(textBoxHoraDisponible.Text);
                    objetoCita.precio = Convert.ToInt32(textBoxPrecio.Text);

                    if (logicaNC.editarcita(objetoCita)>0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRegistrarCita.DataSource = logicaNC.listarcita();
                        textBoxNuevaCita.Text = "";
                        textBoxFechaCita.Text = "";
                        textBoxHoraDisponible.Text = "";
                        textBoxPrecio.Text = "";
                        tabCita.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Cita");
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
