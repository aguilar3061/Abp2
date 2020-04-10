using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OC.Core.Crypto;
using System.Security.Cryptography;
namespace WindowsFormsApp1
{
    public partial class FormInicioSesion : System.Windows.Forms.Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            List<Socis> socis = BD.SociORM.SelectAllsocis();
            bool login = false;

            //Hash hash = new Hash();

            //SHA512.Create(textBoxContrasenya.Text);

            //soci.contrasenya = hash.Sha512(textBoxContrasenya.Text);


            if (textBoxDNI.Text.Equals("") || textBoxContrasenya.Text.Equals(""))
            {
                MessageBox.Show("Un dels camps esta buit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SHA512.Create(textBoxContrasenya.Text);
                Socis soci = new Socis();

                soci.DNI = textBoxDNI.Text;
                soci.contrasenya = textBoxContrasenya.Text;

                for (int i = 0; i < socis.Count; i++)
                {
                    if (socis.ElementAt(i).DNI.Equals(soci.DNI) && socis.ElementAt(i).contrasenya.Equals(soci.contrasenya))
                    {
                        if (socis.ElementAt(i).administrador == true)
                        {
                            login = true;
                        }
                    }

                }
            }




            if (login == true)
            {
                FormMenu menu = new FormMenu();

                this.Close();

                menu.Show();
            }
            else
            {
                MessageBox.Show("Les credencials introduides no son valides", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
