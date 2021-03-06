﻿namespace WindowsFormsApp1
{
    partial class FormModificarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarEvento));
            this.bindingSourceComunidades = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaIncio = new System.Windows.Forms.DateTimePicker();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombreEvento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxImatgeEsdeveniment = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBoxDescripcio = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImatgeEsdeveniment)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceComunidades
            // 
            this.bindingSourceComunidades.DataSource = typeof(WindowsFormsApp1.Comunitat);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Modificar evento";
            // 
            // dateTimePickerHoraFinal
            // 
            this.dateTimePickerHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraFinal.Location = new System.Drawing.Point(548, 156);
            this.dateTimePickerHoraFinal.Name = "dateTimePickerHoraFinal";
            this.dateTimePickerHoraFinal.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerHoraFinal.TabIndex = 41;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(205, 156);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerHoraInicio.TabIndex = 40;
            // 
            // dateTimePickerFechaFinal
            // 
            this.dateTimePickerFechaFinal.Location = new System.Drawing.Point(506, 116);
            this.dateTimePickerFechaFinal.Name = "dateTimePickerFechaFinal";
            this.dateTimePickerFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaFinal.TabIndex = 39;
            // 
            // dateTimePickerFechaIncio
            // 
            this.dateTimePickerFechaIncio.Location = new System.Drawing.Point(162, 116);
            this.dateTimePickerFechaIncio.Name = "dateTimePickerFechaIncio";
            this.dateTimePickerFechaIncio.Size = new System.Drawing.Size(206, 20);
            this.dateTimePickerFechaIncio.TabIndex = 38;
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidades;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(41, 240);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(202, 21);
            this.comboBoxComunidad.TabIndex = 37;
            this.comboBoxComunidad.ValueMember = "id";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardar.Location = new System.Drawing.Point(633, 285);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(128, 49);
            this.buttonGuardar.TabIndex = 36;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(499, 285);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(128, 49);
            this.buttonCancelar.TabIndex = 35;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(348, 240);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(372, 20);
            this.textBoxDireccion.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(345, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Comunidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hora fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hora inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fecha fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fecha inicio:";
            // 
            // textBoxNombreEvento
            // 
            this.textBoxNombreEvento.Location = new System.Drawing.Point(110, 75);
            this.textBoxNombreEvento.Name = "textBoxNombreEvento";
            this.textBoxNombreEvento.Size = new System.Drawing.Size(372, 20);
            this.textBoxNombreEvento.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxImatgeEsdeveniment
            // 
            this.pictureBoxImatgeEsdeveniment.Location = new System.Drawing.Point(552, 12);
            this.pictureBoxImatgeEsdeveniment.Name = "pictureBoxImatgeEsdeveniment";
            this.pictureBoxImatgeEsdeveniment.Size = new System.Drawing.Size(209, 80);
            this.pictureBoxImatgeEsdeveniment.TabIndex = 42;
            this.pictureBoxImatgeEsdeveniment.TabStop = false;
            this.pictureBoxImatgeEsdeveniment.Click += new System.EventHandler(this.pictureBoxImatgeEsdeveniment_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Imatge";
            // 
            // richTextBoxDescripcio
            // 
            this.richTextBoxDescripcio.Location = new System.Drawing.Point(41, 305);
            this.richTextBoxDescripcio.Name = "richTextBoxDescripcio";
            this.richTextBoxDescripcio.Size = new System.Drawing.Size(327, 96);
            this.richTextBoxDescripcio.TabIndex = 44;
            this.richTextBoxDescripcio.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 45;
            this.label8.Text = "Descripcio";
            // 
            // FormModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(773, 413);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxDescripcio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxImatgeEsdeveniment);
            this.Controls.Add(this.dateTimePickerHoraFinal);
            this.Controls.Add(this.dateTimePickerHoraInicio);
            this.Controls.Add(this.dateTimePickerFechaFinal);
            this.Controls.Add(this.dateTimePickerFechaIncio);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombreEvento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarEvento";
            this.Text = "FormModificarEvento";
            this.Load += new System.EventHandler(this.FormModificarEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImatgeEsdeveniment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceComunidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIncio;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombreEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxImatgeEsdeveniment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcio;
        private System.Windows.Forms.Label label8;
    }
}