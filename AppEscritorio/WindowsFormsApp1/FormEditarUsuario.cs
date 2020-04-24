using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BD;

namespace WindowsFormsApp1
{
    public partial class FormEditarUsuario : System.Windows.Forms.Form
    {

        Socis socio = new Socis();
        String mensaje = "";

        public FormEditarUsuario(Socis socio)
        {

            this.socio = socio;

            InitializeComponent();

        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            if (socio.administrador)
            {

                labelEditar.Text = "Editar ADMINISTRADOR";


            }
     
            bindingSourceComunidad.DataSource = BD.ComunitatsORM.SelectAllComunitats();


            textBoxNombre.Text = socio.nom;
            textBoxCognom.Text = socio.cognoms;
            textBoxDni.Text = socio.DNI;
            textBoxTelefono.Text = socio.telefon;
            textBoxCorreu.Text = socio.mail;
            textBoxContrasena.Text = socio.contrasenya;
            textBoxContrasenaR.Text = socio.contrasenya;


            if (socio.Comunitat1 != null)
            {
              
                comboBoxComunidad.SelectedItem = socio.Comunitat1;

            }

            
            checkBoxActivo.Checked = socio.actiu;

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
            else if (textBoxTelefono.Text.Length > 9 || textBoxTelefono.Text.Length < 9 || textBoxTelefono.Text.Equals(""))
            {
                MessageBox.Show("El telefono del usuario no es correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTelefono.Focus();
            }
            else if (textBoxCorreu.Text.Equals(""))
            {
                MessageBox.Show("El correo del usuario no puede estar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTelefono.Focus();
            }
            else if (comboBoxComunidad.SelectedItem == null)
            {
                MessageBox.Show("La comunidad del usuario no puede estar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxComunidad.Focus();

            }
            else if (!textBoxContrasena.Text.Equals(textBoxContrasenaR.Text))
            {
                    
                MessageBox.Show("La contraseña no coincide.. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxComunidad.Focus();

            }
            else if (textBoxContrasena.Text.Equals(""))
            {

                MessageBox.Show("La no puede estar vacia.. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxComunidad.Focus();

            }
            else
            {


            
                socio.contrasenya = textBoxContrasena.Text;
                socio.nom = textBoxNombre.Text;
                socio.cognoms = textBoxCognom.Text;
                socio.DNI = textBoxDni.Text;
                socio.telefon = textBoxTelefono.Text;
                socio.mail = textBoxCorreu.Text;
                socio.actiu = checkBoxActivo.Checked;
                socio.Comunitat1 = (Comunitat) comboBoxComunidad.SelectedItem;



                BD.SociORM.UpdateSocio(socio);



                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("Modificaccio correcte", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
             DialogResult respuesta = MessageBox.Show("Seguro que desea cerrar la pantalla de editar usuario? Los datos introducidos de este evento se borraran ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if ( respuesta == DialogResult.Yes)
            {

                this.Close();
                
            }
           

        }

  
    }
}
