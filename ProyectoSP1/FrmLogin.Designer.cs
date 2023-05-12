namespace ProyectoSP1
{
    partial class frmLogin
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblMódulo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cboxMódulo = new System.Windows.Forms.ComboBox();
            this.CmdAceptar2 = new System.Windows.Forms.Button();
            this.cmdCancelar2 = new System.Windows.Forms.Button();
            this.lblNoSe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(12, 100);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblMódulo
            // 
            this.lblMódulo.AutoSize = true;
            this.lblMódulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMódulo.Location = new System.Drawing.Point(12, 160);
            this.lblMódulo.Name = "lblMódulo";
            this.lblMódulo.Size = new System.Drawing.Size(52, 16);
            this.lblMódulo.TabIndex = 2;
            this.lblMódulo.Text = "Módulo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUsuario.Location = new System.Drawing.Point(112, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(142, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(113, 96);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(141, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // cboxMódulo
            // 
            this.cboxMódulo.FormattingEnabled = true;
            this.cboxMódulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.cboxMódulo.Location = new System.Drawing.Point(112, 160);
            this.cboxMódulo.Name = "cboxMódulo";
            this.cboxMódulo.Size = new System.Drawing.Size(141, 21);
            this.cboxMódulo.TabIndex = 5;
            this.cboxMódulo.Text = "Seleccionar";
            this.cboxMódulo.SelectedIndexChanged += new System.EventHandler(this.cboxMódulo_SelectedIndexChanged);
            // 
            // CmdAceptar2
            // 
            this.CmdAceptar2.Location = new System.Drawing.Point(148, 218);
            this.CmdAceptar2.Name = "CmdAceptar2";
            this.CmdAceptar2.Size = new System.Drawing.Size(107, 35);
            this.CmdAceptar2.TabIndex = 6;
            this.CmdAceptar2.Text = "&Aceptar";
            this.CmdAceptar2.UseVisualStyleBackColor = true;
            this.CmdAceptar2.Click += new System.EventHandler(this.CmdAceptar2_Click);
            // 
            // cmdCancelar2
            // 
            this.cmdCancelar2.Location = new System.Drawing.Point(15, 218);
            this.cmdCancelar2.Name = "cmdCancelar2";
            this.cmdCancelar2.Size = new System.Drawing.Size(107, 37);
            this.cmdCancelar2.TabIndex = 7;
            this.cmdCancelar2.Text = "&Cancelar";
            this.cmdCancelar2.UseVisualStyleBackColor = true;
            this.cmdCancelar2.Click += new System.EventHandler(this.cmdCancelar2_Click);
            // 
            // lblNoSe
            // 
            this.lblNoSe.AutoSize = true;
            this.lblNoSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoSe.Location = new System.Drawing.Point(66, 9);
            this.lblNoSe.Name = "lblNoSe";
            this.lblNoSe.Size = new System.Drawing.Size(118, 20);
            this.lblNoSe.TabIndex = 8;
            this.lblNoSe.Text = "Inicio de sesión";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 276);
            this.ControlBox = false;
            this.Controls.Add(this.lblNoSe);
            this.Controls.Add(this.cmdCancelar2);
            this.Controls.Add(this.CmdAceptar2);
            this.Controls.Add(this.cboxMódulo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblMódulo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblMódulo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cboxMódulo;
        private System.Windows.Forms.Button CmdAceptar2;
        private System.Windows.Forms.Button cmdCancelar2;
        private System.Windows.Forms.Label lblNoSe;
    }
}