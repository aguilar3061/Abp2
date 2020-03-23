namespace WindowsFormsApp1
{
    partial class FormGridViewEventos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.bindingSourceEventosGridview = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxComunitats = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.nombreEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventosGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEventoDataGridViewTextBoxColumn,
            this.direccioDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.horaFinDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.bindingSourceEventosGridview;
            this.dataGridViewEventos.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.Size = new System.Drawing.Size(776, 292);
            this.dataGridViewEventos.TabIndex = 22;
            this.dataGridViewEventos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewEventos_UserDeletingRow);
            // 
            // bindingSourceEventosGridview
            // 
            this.bindingSourceEventosGridview.DataSource = typeof(WindowsFormsApp1.Esdeveniment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Editar evento";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::WindowsFormsApp1.Properties.Resources.FlechaParaAtras;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(48, 38);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // comboBoxComunitats
            // 
            this.comboBoxComunitats.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunitats.DisplayMember = "nombre";
            this.comboBoxComunitats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunitats.FormattingEnabled = true;
            this.comboBoxComunitats.Location = new System.Drawing.Point(13, 64);
            this.comboBoxComunitats.Name = "comboBoxComunitats";
            this.comboBoxComunitats.Size = new System.Drawing.Size(177, 21);
            this.comboBoxComunitats.TabIndex = 25;
            this.comboBoxComunitats.ValueMember = "id";
            this.comboBoxComunitats.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunitats_SelectedIndexChanged);
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(WindowsFormsApp1.Comunitat);
            // 
            // nombreEventoDataGridViewTextBoxColumn
            // 
            this.nombreEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreEventoDataGridViewTextBoxColumn.DataPropertyName = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.HeaderText = "NombreEvento";
            this.nombreEventoDataGridViewTextBoxColumn.Name = "nombreEventoDataGridViewTextBoxColumn";
            this.nombreEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccioDataGridViewTextBoxColumn
            // 
            this.direccioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccioDataGridViewTextBoxColumn.DataPropertyName = "Direccio";
            this.direccioDataGridViewTextBoxColumn.HeaderText = "Direccio";
            this.direccioDataGridViewTextBoxColumn.Name = "direccioDataGridViewTextBoxColumn";
            this.direccioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            this.fechaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "horaInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            this.fechaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFinDataGridViewTextBoxColumn
            // 
            this.horaFinDataGridViewTextBoxColumn.DataPropertyName = "horaFin";
            this.horaFinDataGridViewTextBoxColumn.HeaderText = "horaFin";
            this.horaFinDataGridViewTextBoxColumn.Name = "horaFinDataGridViewTextBoxColumn";
            this.horaFinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormGridViewEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxComunitats);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.dataGridViewEventos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGridViewEventos";
            this.Load += new System.EventHandler(this.FormGridViewEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventosGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.BindingSource bindingSourceEventosGridview;
        private System.Windows.Forms.ComboBox comboBoxComunitats;
        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFinDataGridViewTextBoxColumn;
    }
}