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

namespace capaPresentacionConsulta
{
    public partial class fConsulta : Form
    {
        logicanegocioconsulta logicaNCT = new logicanegocioconsulta();

        public fConsulta()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    consulta objetoConsulta = new consulta();
                    objetoConsulta.tipoconsulta = textBoxTipoConsulta.Text;

                    if (logicaNCT.insertarconsulta(objetoConsulta) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewConsulta.DataSource = logicaNCT.listarconsulta();
                        textBoxTipoConsulta.Text = "";
                        tabConsulta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Consulta");
                    }

                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    consulta objetoConsulta = new consulta();
                    objetoConsulta.tipoconsulta = textBoxTipoConsulta.Text;

                    if (logicaNCT.editarconsulta(objetoConsulta) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewConsulta.DataSource = logicaNCT.listarconsulta();
                        textBoxTipoConsulta.Text = "";
                        tabConsulta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Consulta");
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
