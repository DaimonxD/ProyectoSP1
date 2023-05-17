namespace ProyectoSP1
{
    partial class frmLoad
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
            this.pg = new System.Windows.Forms.Panel();
            this.pv = new System.Windows.Forms.Panel();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.lblCargando = new System.Windows.Forms.Label();
            this.lblAB = new System.Windows.Forms.Label();
            this.lblAA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pg
            // 
            this.pg.Controls.Add(this.pv);
            this.pg.Location = new System.Drawing.Point(0, 267);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(579, 14);
            this.pg.TabIndex = 0;
            // 
            // pv
            // 
            this.pv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(210)))), ((int)(((byte)(145)))));
            this.pv.Location = new System.Drawing.Point(0, 0);
            this.pv.Name = "pv";
            this.pv.Size = new System.Drawing.Size(57, 14);
            this.pv.TabIndex = 1;
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 15;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargando.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCargando.Location = new System.Drawing.Point(178, 209);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(213, 42);
            this.lblCargando.TabIndex = 1;
            this.lblCargando.Text = "Cargando...";
            this.lblCargando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAB
            // 
            this.lblAB.AutoSize = true;
            this.lblAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAB.Location = new System.Drawing.Point(270, 40);
            this.lblAB.Name = "lblAB";
            this.lblAB.Size = new System.Drawing.Size(33, 16);
            this.lblAB.TabIndex = 4;
            this.lblAB.Text = "SRL";
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAA.Location = new System.Drawing.Point(220, 10);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(131, 33);
            this.lblAA.TabIndex = 3;
            this.lblAA.Text = "Sintepart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sintepart S.R.L©";
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(578, 282);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAB);
            this.Controls.Add(this.lblAA);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.pg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.Load += new System.EventHandler(this.frmLoad_Load);
            this.pg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pg;
        private System.Windows.Forms.Panel pv;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.Label lblAB;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Label label1;
    }
}