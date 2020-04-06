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
    public partial class FormNuevoUsuario : System.Windows.Forms.Form
    {
        Boolean admin = false;
        String mensaje = "";
        public FormNuevoUsuario()
        {
            InitializeComponent();
            comboBoxComunitatAdmin.Visible = false;
            bindingSourceComunitats.DataSource = BD.ComunitatsORM.SelectAllComunitats();
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void checkBoxAdministrador_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxAdministrador.Checked)
            {
                comboBoxComunitatAdmin.Visible = true;
                admin = true;
            }
            else
            {
                comboBoxComunitatAdmin.Visible = false;
                admin = false;
            }
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxDni.Text.Length > 9 || textBoxDni.Text.Length < 9 || textBoxDni.Text.Equals(""))
            {
                MessageBox.Show("El DNI del usuario no es correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDni.Focus();
            }
            else if (textBoxNombre.Text.Equals(""))
            {
                MessageBox.Show("El nombre del usuario no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombre.Focus();
            }
            else if (textBoxCognom.Text.Equals(""))
            {
                MessageBox.Show("El apellido del usuario no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCognom.Focus();
            }
            //else if (textBoxTelefono.Text.Length > 9 || textBoxTelefono.Text.Length < 9 || textBoxTelefono.Text.Equals(""))
            //{
            //    MessageBox.Show("El telefono del usuario no es correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    textBoxTelefono.Focus();
            //}
            else if (textBoxCorreu.Text.Equals(""))
            {
                MessageBox.Show("El correo del usuario no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTelefono.Focus();
            }
            else
            {
               mensaje = BD.SociORM.InsertSoci(admin, textBoxCorreu.Text,textBoxNombre.Text,textBoxCognom.Text,textBoxTelefono.Text,textBoxDni.Text,(int) comboBoxComunitatAdmin.SelectedValue);

                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El socio ha sido creado con exito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
        }
    }
}
