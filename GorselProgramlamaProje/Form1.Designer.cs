namespace GorselProgramlamaProje
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnX = new System.Windows.Forms.Button();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.neonRing1 = new GorselProgramlamaProje.NeonRing();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.Firebrick;
            this.btnX.Location = new System.Drawing.Point(362, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(26, 23);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_click);
            // 
            // lblBilgi
            // 
            this.lblBilgi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(12, 38);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(376, 42);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "-";
            this.lblBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.White;
            this.btnBaslat.Location = new System.Drawing.Point(138, 406);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(120, 32);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // neonRing1
            // 
            this.neonRing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.neonRing1.ForeColor = System.Drawing.Color.LimeGreen;
            this.neonRing1.Location = new System.Drawing.Point(40, 83);
            this.neonRing1.MaksimumSure = 120;
            this.neonRing1.Name = "neonRing1";
            this.neonRing1.Size = new System.Drawing.Size(318, 317);
            this.neonRing1.Sure = 0;
            this.neonRing1.TabIndex = 1;
            this.neonRing1.Text = "neonRing1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.neonRing1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private NeonRing neonRing1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnBaslat;
    }
}

