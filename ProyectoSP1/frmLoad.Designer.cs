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
            this.timerLoad.Interval = 15;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(578, 282);
            this.ControlBox = false;
            this.Controls.Add(this.pg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.pg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pg;
        private System.Windows.Forms.Panel pv;
        private System.Windows.Forms.Timer timerLoad;
    }
}