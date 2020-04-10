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


        public FormEditarUsuario(Socis socio)
        {

            this.socio = socio;

            InitializeComponent();

        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {

     
            bindingSourceComunidad.DataSource = BD.ComunitatsORM.SelectAllComunitats();


            textBoxNombre.Text = socio.nom;
            textBoxCognom.Text = socio.cognoms;
            textBoxDni.Text = socio.DNI;
            textBoxTelfon.Text = socio.telefon;
            textBoxCorreo.Text = socio.mail;

            //comboBoxComarca.SelectedIndex = socio.Comunitat1.ElementAt;

            
            checkBoxActivo.Checked = socio.actiu;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
