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
    public partial class FormGridViewEventos : System.Windows.Forms.Form
    {
        String mensaje;
        public FormGridViewEventos()
        {
            InitializeComponent();
        }

        private void FormGridViewEventos_Load(object sender, EventArgs e)
        {
            bindingSourceComunidades.DataSource = BD.ComunitatsORM.SelectAllComunitats();
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllEventos();
            comboBoxComunitats.SelectedItem = null;

        }

        private void comboBoxComunitats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxComunitats.SelectedItem != null) {

                bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllEventosPorComunidad((int)comboBoxComunitats.SelectedValue);

            }

        }

        private void dataGridViewEventos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Vols eliminar aquest esdeveniment?", "Eliminar esdeveniment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                mensaje = BD.EventoORM.DeleteEvento((Esdeveniment)dataGridViewEventos.SelectedRows[0].DataBoundItem);
                if (!mensaje.Equals(""))
                {
                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dataGridViewEventos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            FormModificarEvento f1 = new FormModificarEvento( (Esdeveniment)dataGridViewEventos.SelectedRows[0].DataBoundItem);

            f1.ShowDialog();
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllEventos();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void dataGridViewEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
