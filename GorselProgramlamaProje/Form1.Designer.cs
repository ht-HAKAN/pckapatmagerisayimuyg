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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.numDakika = new System.Windows.Forms.NumericUpDown();
            this.numSaniye = new System.Windows.Forms.NumericUpDown();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaniye)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblSayac);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(371, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(90, 20);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(220, 55);
            this.lblSayac.TabIndex = 1;
            this.lblSayac.Text = "00:00:00";
            // 
            // numDakika
            // 
            this.numDakika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numDakika.ForeColor = System.Drawing.Color.White;
            this.numDakika.Location = new System.Drawing.Point(49, 252);
            this.numDakika.Name = "numDakika";
            this.numDakika.Size = new System.Drawing.Size(120, 20);
            this.numDakika.TabIndex = 1;
            // 
            // numSaniye
            // 
            this.numSaniye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numSaniye.ForeColor = System.Drawing.Color.White;
            this.numSaniye.Location = new System.Drawing.Point(248, 252);
            this.numSaniye.Name = "numSaniye";
            this.numSaniye.Size = new System.Drawing.Size(120, 20);
            this.numSaniye.TabIndex = 2;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(49, 301);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "button2";
            this.btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(264, 301);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "button3";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(400, 10);
            this.progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.numSaniye);
            this.Controls.Add(this.numDakika);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaniye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.NumericUpDown numDakika;
        private System.Windows.Forms.NumericUpDown numSaniye;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

