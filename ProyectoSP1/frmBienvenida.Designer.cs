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
            this.mrcBienvenida = new System.Windows.Forms.GroupBox();
            this.cmdNuke = new System.Windows.Forms.Button();
            this.mrcBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido1
            // 
            this.lblBienvenido1.AutoSize = true;
            this.lblBienvenido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido1.Location = new System.Drawing.Point(30, 20);
            this.lblBienvenido1.Name = "lblBienvenido1";
            this.lblBienvenido1.Size = new System.Drawing.Size(444, 25);
            this.lblBienvenido1.TabIndex = 0;
            this.lblBienvenido1.Text = "Bienvenido a la aplicación de Sintepart S.R.L";
            this.lblBienvenido1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBienvenido2
            // 
            this.lblBienvenido2.AutoSize = true;
            this.lblBienvenido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido2.Location = new System.Drawing.Point(70, 50);
            this.lblBienvenido2.Name = "lblBienvenido2";
            this.lblBienvenido2.Size = new System.Drawing.Size(346, 20);
            this.lblBienvenido2.TabIndex = 1;
            this.lblBienvenido2.Text = "Fábrica de autopartes y respuestos moviles Fiat";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Location = new System.Drawing.Point(145, 478);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(198, 36);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar Programa";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // mrcBienvenida
            // 
            this.mrcBienvenida.Controls.Add(this.cmdNuke);
            this.mrcBienvenida.Location = new System.Drawing.Point(35, 92);
            this.mrcBienvenida.Name = "mrcBienvenida";
            this.mrcBienvenida.Size = new System.Drawing.Size(439, 355);
            this.mrcBienvenida.TabIndex = 4;
            this.mrcBienvenida.TabStop = false;
            // 
            // cmdNuke
            // 
            this.cmdNuke.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuke.Location = new System.Drawing.Point(6, 12);
            this.cmdNuke.Name = "cmdNuke";
            this.cmdNuke.Size = new System.Drawing.Size(427, 337);
            this.cmdNuke.TabIndex = 0;
            this.cmdNuke.Text = "Send Nukes!!1!!";
            this.cmdNuke.UseVisualStyleBackColor = true;
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 526);
            this.ControlBox = false;
            this.Controls.Add(this.mrcBienvenida);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.lblBienvenido2);
            this.Controls.Add(this.lblBienvenido1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenida";
            this.Text = "Bienvenido/a";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.mrcBienvenida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido1;
        private System.Windows.Forms.Label lblBienvenido2;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.GroupBox mrcBienvenida;
        private System.Windows.Forms.Button cmdNuke;
    }
}

