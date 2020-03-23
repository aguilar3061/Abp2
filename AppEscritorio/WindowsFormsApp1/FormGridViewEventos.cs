﻿using System;
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
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllHotelesPorComunidad((int)comboBoxComunitats.SelectedValue);
        }

        private void comboBoxComunitats_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceEventosGridview.DataSource = BD.EventoORM.SelectAllHotelesPorComunidad((int)comboBoxComunitats.SelectedValue);
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
    }
}