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
    public partial class FormInicioSesion : System.Windows.Forms.Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        
        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            FormMenu menu = new FormMenu();

            this.Close();

            menu.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
