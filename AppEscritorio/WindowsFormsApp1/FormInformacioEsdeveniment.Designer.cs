namespace WindowsFormsApp1
{
    partial class FormInformacioEsdeveniment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacioEsdeveniment));
            this.labelNomEsdeveniment = new System.Windows.Forms.Label();
            this.dataGridViewValoracions = new System.Windows.Forms.DataGridView();
            this.valoracioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAssistir = new System.Windows.Forms.BindingSource(this.components);
            this.labelParticipants = new System.Windows.Forms.Label();
            this.labelAssistencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAssistir)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomEsdeveniment
            // 
            this.labelNomEsdeveniment.AutoSize = true;
            this.labelNomEsdeveniment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEsdeveniment.Location = new System.Drawing.Point(334, 24);
            this.labelNomEsdeveniment.Name = "labelNomEsdeveniment";
            this.labelNomEsdeveniment.Size = new System.Drawing.Size(0, 31);
            this.labelNomEsdeveniment.TabIndex = 36;
            // 
            // dataGridViewValoracions
            // 
            this.dataGridViewValoracions.AllowUserToAddRows = false;
            this.dataGridViewValoracions.AllowUserToDeleteRows = false;
            this.dataGridViewValoracions.AutoGenerateColumns = false;
            this.dataGridViewValoracions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValoracions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valoracioDataGridViewTextBoxColumn,
            this.comentariDataGridViewTextBoxColumn});
            this.dataGridViewValoracions.DataSource = this.bindingSourceAssistir;
            this.dataGridViewValoracions.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewValoracions.Name = "dataGridViewValoracions";
            this.dataGridViewValoracions.ReadOnly = true;
            this.dataGridViewValoracions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValoracions.Size = new System.Drawing.Size(775, 362);
            this.dataGridViewValoracions.TabIndex = 37;
            this.dataGridViewValoracions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // valoracioDataGridViewTextBoxColumn
            // 
            this.valoracioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valoracioDataGridViewTextBoxColumn.DataPropertyName = "valoracio";
            this.valoracioDataGridViewTextBoxColumn.HeaderText = "valoracio";
            this.valoracioDataGridViewTextBoxColumn.Name = "valoracioDataGridViewTextBoxColumn";
            this.valoracioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentariDataGridViewTextBoxColumn
            // 
            this.comentariDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comentariDataGridViewTextBoxColumn.DataPropertyName = "comentari";
            this.comentariDataGridViewTextBoxColumn.HeaderText = "comentari";
            this.comentariDataGridViewTextBoxColumn.Name = "comentariDataGridViewTextBoxColumn";
            this.comentariDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceAssistir
            // 
            this.bindingSourceAssistir.DataSource = typeof(WindowsFormsApp1.Assistir);
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Location = new System.Drawing.Point(12, 54);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(60, 13);
            this.labelParticipants.TabIndex = 38;
            this.labelParticipants.Text = "Assistencia";
            // 
            // labelAssistencia
            // 
            this.labelAssistencia.AutoSize = true;
            this.labelAssistencia.Location = new System.Drawing.Point(78, 54);
            this.labelAssistencia.Name = "labelAssistencia";
            this.labelAssistencia.Size = new System.Drawing.Size(0, 13);
            this.labelAssistencia.TabIndex = 39;
            // 
            // FormInformacioEsdeveniment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(799, 462);
            this.Controls.Add(this.labelAssistencia);
            this.Controls.Add(this.labelParticipants);
            this.Controls.Add(this.dataGridViewValoracions);
            this.Controls.Add(this.labelNomEsdeveniment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformacioEsdeveniment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormInformacioEsdeveniment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoracions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAssistir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNomEsdeveniment;
        private System.Windows.Forms.BindingSource bindingSourceAssistir;
        private System.Windows.Forms.DataGridView dataGridViewValoracions;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelParticipants;
        private System.Windows.Forms.Label labelAssistencia;
    }
}