namespace ProyectoSP1
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.lblBienvenido1 = new System.Windows.Forms.Label();
            this.lblBienvenido2 = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido1
            // 
            this.lblBienvenido1.AutoSize = true;
            this.lblBienvenido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBienvenido1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido1.Location = new System.Drawing.Point(34, 201);
            this.lblBienvenido1.Name = "lblBienvenido1";
            this.lblBienvenido1.Size = new System.Drawing.Size(448, 26);
            this.lblBienvenido1.TabIndex = 0;
            this.lblBienvenido1.Text = "Bienvenido a la aplicación de Sintepart S.R.L";
            this.lblBienvenido1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBienvenido2
            // 
            this.lblBienvenido2.AutoSize = true;
            this.lblBienvenido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBienvenido2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenido2.Location = new System.Drawing.Point(104, 227);
            this.lblBienvenido2.Name = "lblBienvenido2";
            this.lblBienvenido2.Size = new System.Drawing.Size(310, 17);
            this.lblBienvenido2.TabIndex = 1;
            this.lblBienvenido2.Text = "Fábrica de autopartes y respuestos moviles Fiat";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.ForeColor = System.Drawing.Color.White;
            this.cmdCerrar.Location = new System.Drawing.Point(489, 0);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(24, 25);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "X";
            this.cmdCerrar.UseVisualStyleBackColor = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(514, 526);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblBienvenido2);
            this.Controls.Add(this.lblBienvenido1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido/a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido1;
        private System.Windows.Forms.Label lblBienvenido2;
        private System.Windows.Forms.Button cmdCerrar;
    }
}

