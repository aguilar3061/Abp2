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
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonNuevoEvento_Click(object sender, EventArgs e)
        {
            TopMost = false;
            FormNuevoEvento NuevoEvento = new FormNuevoEvento();
            NuevoEvento.ShowDialog();
        }

        private void buttonNuevoUsuario_Click(object sender, EventArgs e)
        {
            TopMost = false;
            FormNuevoUsuario NuevoUsuario = new FormNuevoUsuario();
            NuevoUsuario.ShowDialog();
        }

        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            TopMost = false;
            FormGirdViewUsuarios editarUsuario = new FormGirdViewUsuarios();
            editarUsuario.ShowDialog();
        }

        private void buttonEditarEvento_Click(object sender, EventArgs e)
        {
            TopMost = false;
            FormGridViewEventos editarEvento = new FormGridViewEventos();
            editarEvento.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {




        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Adeeeeuu ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();

        }
    }
}
