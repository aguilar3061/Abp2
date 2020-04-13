namespace WindowsFormsApp1
{
    partial class FormEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarUsuario));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxCognom = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxContrasenaR = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.textBoxCorreu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidad = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(577, 423);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 49);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardar.Location = new System.Drawing.Point(721, 423);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(128, 49);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(764, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Activo";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(297, 221);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(246, 20);
            this.textBoxTelefono.TabIndex = 29;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(222, 221);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(70, 18);
            this.labelTelefon.TabIndex = 28;
            this.labelTelefon.Text = "Telefono:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Enabled = false;
            this.textBoxDni.Location = new System.Drawing.Point(297, 183);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(246, 20);
            this.textBoxDni.TabIndex = 27;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(254, 185);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(37, 18);
            this.labelDni.TabIndex = 26;
            this.labelDni.Text = "DNI:";
            // 
            // textBoxCognom
            // 
            this.textBoxCognom.Location = new System.Drawing.Point(297, 146);
            this.textBoxCognom.Name = "textBoxCognom";
            this.textBoxCognom.Size = new System.Drawing.Size(246, 20);
            this.textBoxCognom.TabIndex = 25;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(228, 146);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(63, 18);
            this.labelApellido.TabIndex = 24;
            this.labelApellido.Text = "Apellido:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(297, 111);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(246, 20);
            this.textBoxNombre.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Editar usuario";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(298, 343);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = 'x';
            this.textBoxContrasena.Size = new System.Drawing.Size(246, 20);
            this.textBoxContrasena.TabIndex = 37;
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(160, 343);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(132, 18);
            this.labelContrasena.TabIndex = 36;
            this.labelContrasena.Text = "Nueva contraseña:";
            // 
            // textBoxContrasenaR
            // 
            this.textBoxContrasenaR.Location = new System.Drawing.Point(298, 377);
            this.textBoxContrasenaR.Name = "textBoxContrasenaR";
            this.textBoxContrasenaR.PasswordChar = 'x';
            this.textBoxContrasenaR.Size = new System.Drawing.Size(246, 20);
            this.textBoxContrasenaR.TabIndex = 39;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(136, 379);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(156, 18);
            this.label.TabIndex = 38;
            this.label.Text = "Confirmar contraseña:";
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(818, 385);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxActivo.TabIndex = 40;
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // textBoxCorreu
            // 
            this.textBoxCorreu.Location = new System.Drawing.Point(297, 255);
            this.textBoxCorreu.Name = "textBoxCorreu";
            this.textBoxCorreu.Size = new System.Drawing.Size(246, 20);
            this.textBoxCorreu.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 43;
            this.label4.Text = "Comunidad:";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidad;
            this.comboBoxComunidad.DisplayMember = "nombre";
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(298, 288);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(246, 21);
            this.comboBoxComunidad.TabIndex = 44;
            this.comboBoxComunidad.ValueMember = "id";
            // 
            // bindingSourceComunidad
            // 
            this.bindingSourceComunidad.DataSource = typeof(WindowsFormsApp1.Comunitat);
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(861, 484);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCorreu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.textBoxContrasenaR);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.textBoxCognom);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxCognom;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxContrasenaR;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.TextBox textBoxCorreu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.BindingSource bindingSourceComunidad;
    }
}