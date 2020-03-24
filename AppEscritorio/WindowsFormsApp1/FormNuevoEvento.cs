using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNuevoEvento : System.Windows.Forms.Form
    {
        Boolean modificar = false;
        String mensaje="";
        public FormNuevoEvento()
        {
            InitializeComponent();
        }
        public FormNuevoEvento(Esdeveniment esdeveniment)
        {
            InitializeComponent();

            modificar = true;
        }

        private void FormNuevoEvento_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = BD.ComunitatsORM.SelectAllComunitats();
            comboBoxComunidad.SelectedItem = null;
        }
    
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (modificar != true)
            {
                if (ComprobarDatos() != false)
                {

                    mensaje = BD.EventoORM.InsertEvento(dateTimePickerFechaIncio.Value, dateTimePickerHoraInicio.Value, (int)comboBoxComunidad.SelectedValue, dateTimePickerFechaFinal.Value, dateTimePickerHoraFinal.Value, textBoxDireccion.Text, textBoxNombreEvento.Text);

                    if (!mensaje.Equals(""))
                    {
                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("El evento ha sido creado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
              
            }



        }
        private Boolean ComprobarDatos()
        {
            Boolean datosCorrectos = false; 

            if (textBoxDireccion.Text.Equals(""))
            {
                MessageBox.Show("La direccion no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDireccion.Focus();
            }
            else if ( dateTimePickerFechaIncio.Value.Date > dateTimePickerFechaFinal.Value.Date)
            {

                MessageBox.Show("La fecha de inicio no puede ser posterior a la de finalizacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerFechaIncio.Focus();

            }

            else if (dateTimePickerFechaIncio.Value.Date == dateTimePickerFechaFinal.Value.Date && dateTimePickerHoraFinal.Value.TimeOfDay < dateTimePickerHoraInicio.Value.TimeOfDay)
            {
               
         
                MessageBox.Show("La hora de inicio no puede ser mayor a la final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePickerHoraFinal.Focus();
                
           
            }
            else if ( comboBoxComunidad.SelectedValue.ToString().Equals("") )
            {
                MessageBox.Show("No hay ninguna comunidad seleccionada ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxComunidad.Focus();
            }
            else if (textBoxNombreEvento.Text.Equals(""))
            {
                MessageBox.Show("El nombre del evento no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreEvento.Focus();
            }
            else
            {
                
                datosCorrectos = true;

            }

            return datosCorrectos;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult respuesta = MessageBox.Show("Seguro que desea cerrar la pantalla de crear un nuevo evento?? Los datos introducidos de este evento se borraran ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if ( respuesta == DialogResult.Yes)
            {

                this.Close();
                
            }
        


        }

        private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
