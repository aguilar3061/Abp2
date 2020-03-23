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
    public partial class inicial : Form
    {
        //Boolean formAbrir = false;
        public inicial()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form1 login = new Form1();

        //    login.ShowDialog();
        //    formAbrir = true;
        //}

        private void inicial_Load(object sender, EventArgs e)
        {

        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            
                timerLogin.Enabled = false;
                FormPantallaPrincipal login = new FormPantallaPrincipal();

                login.ShowDialog();
            
        }
    }
}
