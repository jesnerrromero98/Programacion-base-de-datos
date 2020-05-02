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

namespace capaPresentacionRegistroPaciente
{
    public partial class fRegistroPaciente : Form
    {
        logicanegocioregpaciente logicaNRP = new logicanegocioregpaciente();

        public fRegistroPaciente()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    registropaciente objetoRegistroPaciente = new registropaciente();
                    objetoRegistroPaciente.nombrepac = textBoxNombrePaciente.Text;
                    objetoRegistroPaciente.apeidopac= textBoxApellido.Text;
                    objetoRegistroPaciente.direccion = textBoxDireccionPaciente.Text;
                    objetoRegistroPaciente.departamento = textBoxDepartamento.Text;
                    objetoRegistroPaciente.municipio = textBoxMunicipio.Text;
                    objetoRegistroPaciente.celular = Convert.ToInt32(textBoxCelular.Text);
                    objetoRegistroPaciente.telefono = Convert.ToInt32(textBoxTelefono.Text);
                    objetoRegistroPaciente.edad = Convert.ToInt32(textBoxEdad.Text);
                    objetoRegistroPaciente.cedula = textBoxCedula.Text;

                    if (logicaNRP.insertarregpaciente(objetoRegistroPaciente) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRegistroPaciente.DataSource = logicaNRP.listarregpaciente();
                        textBoxNombrePaciente.Text = "";
                        textBoxApellido.Text = "";
                        textBoxDireccionPaciente.Text = "";
                        textBoxDepartamento.Text = "";
                        textBoxMunicipio.Text = "";
                        textBoxCelular.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxEdad.Text = "";
                        textBoxCedula.Text = "";
                        tabRegistroPaciente.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Paciente");
                    }

                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    registropaciente objetoRegistroPaciente = new registropaciente();
                    objetoRegistroPaciente.nombrepac = textBoxNombrePaciente.Text;
                    objetoRegistroPaciente.apeidopac = textBoxApellido.Text;
                    objetoRegistroPaciente.direccion = textBoxDireccionPaciente.Text;
                    objetoRegistroPaciente.departamento = textBoxDepartamento.Text;
                    objetoRegistroPaciente.municipio = textBoxMunicipio.Text;
                    objetoRegistroPaciente.celular = Convert.ToInt32(textBoxCelular.Text);
                    objetoRegistroPaciente.telefono = Convert.ToInt32(textBoxTelefono.Text);
                    objetoRegistroPaciente.edad = Convert.ToInt32(textBoxEdad.Text);
                    objetoRegistroPaciente.cedula = textBoxCedula.Text;

                    if (logicaNRP.editarregpaciente(objetoRegistroPaciente) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRegistroPaciente.DataSource = logicaNRP.listarregpaciente();
                        textBoxNombrePaciente.Text = "";
                        textBoxApellido.Text = "";
                        textBoxDireccionPaciente.Text = "";
                        textBoxDepartamento.Text = "";
                        textBoxMunicipio.Text = "";
                        textBoxCelular.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxEdad.Text = "";
                        textBoxCedula.Text = "";
                        tabRegistroPaciente.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Paciente");
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
