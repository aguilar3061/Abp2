namespace WindowsFormsApp1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNuevoUsuario = new System.Windows.Forms.Button();
            this.buttonNuevoEvento = new System.Windows.Forms.Button();
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            this.buttonEditarEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // buttonNuevoUsuario
            // 
            this.buttonNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoUsuario.ForeColor = System.Drawing.Color.Black;
            this.buttonNuevoUsuario.Location = new System.Drawing.Point(1, 84);
            this.buttonNuevoUsuario.Name = "buttonNuevoUsuario";
            this.buttonNuevoUsuario.Size = new System.Drawing.Size(393, 125);
            this.buttonNuevoUsuario.TabIndex = 1;
            this.buttonNuevoUsuario.Text = "Nuevo usuario";
            this.buttonNuevoUsuario.UseVisualStyleBackColor = false;
            this.buttonNuevoUsuario.Click += new System.EventHandler(this.buttonNuevoUsuario_Click);
            // 
            // buttonNuevoEvento
            // 
            this.buttonNuevoEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonNuevoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoEvento.ForeColor = System.Drawing.Color.Black;
            this.buttonNuevoEvento.Location = new System.Drawing.Point(400, 84);
            this.buttonNuevoEvento.Name = "buttonNuevoEvento";
            this.buttonNuevoEvento.Size = new System.Drawing.Size(393, 125);
            this.buttonNuevoEvento.TabIndex = 2;
            this.buttonNuevoEvento.Text = "Nuevo evento";
            this.buttonNuevoEvento.UseVisualStyleBackColor = false;
            this.buttonNuevoEvento.Click += new System.EventHandler(this.buttonNuevoEvento_Click);
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarUsuario.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(1, 215);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(393, 125);
            this.buttonEditarUsuario.TabIndex = 3;
            this.buttonEditarUsuario.Text = "Editar usuario";
            this.buttonEditarUsuario.UseVisualStyleBackColor = false;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // buttonEditarEvento
            // 
            this.buttonEditarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonEditarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarEvento.ForeColor = System.Drawing.Color.Black;
            this.buttonEditarEvento.Location = new System.Drawing.Point(400, 215);
            this.buttonEditarEvento.Name = "buttonEditarEvento";
            this.buttonEditarEvento.Size = new System.Drawing.Size(393, 125);
            this.buttonEditarEvento.TabIndex = 4;
            this.buttonEditarEvento.Text = "Editar evento";
            this.buttonEditarEvento.UseVisualStyleBackColor = false;
            this.buttonEditarEvento.Click += new System.EventHandler(this.buttonEditarEvento_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.buttonEditarEvento);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.buttonNuevoEvento);
            this.Controls.Add(this.buttonNuevoUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNuevoUsuario;
        private System.Windows.Forms.Button buttonNuevoEvento;
        private System.Windows.Forms.Button buttonEditarUsuario;
        private System.Windows.Forms.Button buttonEditarEvento;
    }
}