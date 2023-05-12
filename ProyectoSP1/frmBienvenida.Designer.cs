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
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
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
            // cmdIniciar
            // 
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.Location = new System.Drawing.Point(280, 120);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(192, 59);
            this.cmdIniciar.TabIndex = 2;
            this.cmdIniciar.Text = "Iniciar Programa";
            this.cmdIniciar.UseVisualStyleBackColor = true;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar.Location = new System.Drawing.Point(40, 120);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(192, 59);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar Programa";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 241);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.lblBienvenido2);
            this.Controls.Add(this.lblBienvenido1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenida";
            this.Text = "Bienvenido/a";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido1;
        private System.Windows.Forms.Label lblBienvenido2;
        private System.Windows.Forms.Button cmdIniciar;
        private System.Windows.Forms.Button cmdCerrar;
    }
}

