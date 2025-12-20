using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public class NeonRing : Control
    {
        private int _sure = 0;
        private int _maksimumSure = 1440;

        public event EventHandler SureDegisti;

        public int Sure
        {
            get => _sure;
            set
            {
                int v = value;
                if (v < 0) v = 0;
                if (v > MaksimumSure) v = MaksimumSure;

                if (_sure == v) return;
                _sure = v;
                Invalidate();
                SureDegisti?.Invoke(this, EventArgs.Empty);
            }
        }

        public int MaksimumSure
        {
            get => _maksimumSure;
            set
            {
                _maksimumSure = value <= 0 ? 1 : value;
                if (_sure > _maksimumSure) Sure = _maksimumSure;
                Invalidate();
            }
        }

        public NeonRing()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.Size = new Size(250, 250);
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ForeColor = Color.LimeGreen;
            this.TabStop = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            int kalinlik = 20;
            Rectangle rect = new Rectangle(kalinlik, kalinlik, this.Width - (2 * kalinlik), this.Height - (2 * kalinlik));

            using (Pen griKalem = new Pen(Color.FromArgb(40, 40, 40), kalinlik))
            {
                griKalem.StartCap = LineCap.Round;
                griKalem.EndCap = LineCap.Round;
                e.Graphics.DrawArc(griKalem, rect, 0, 360);
            }

            if (MaksimumSure > 0 && Sure > 0)
            {
                float aci = (float)Sure / MaksimumSure * 360;
                using (Pen neonKalem = new Pen(this.ForeColor, kalinlik))
                {
                    neonKalem.StartCap = LineCap.Round;
                    neonKalem.EndCap = LineCap.Round;
                    e.Graphics.DrawArc(neonKalem, rect, -90, aci);
                }
            }

            string yazi;
            if (Sure < 60)
                yazi = Sure + " dk";
            else
            {
                int saat = Sure / 60;
                int dakika = Sure % 60;
                yazi = $"{saat} s {dakika} dk";
            }

            using (Font yaziFontu = new Font("Segoe UI", 32, FontStyle.Bold))
            {
                SizeF yaziBoyutu = e.Graphics.MeasureString(yazi, yaziFontu);
                using (Brush firca = new SolidBrush(Color.White))
                {
                    e.Graphics.DrawString(yazi, yaziFontu, firca,
                        (this.Width - yaziBoyutu.Width) / 2,
                        (this.Height - yaziBoyutu.Height) / 2);
                }
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            this.Focus();

            int artisMiktari = (Control.ModifierKeys == Keys.Shift) ? 60 : 15;

            int yeni = Sure + (e.Delta > 0 ? artisMiktari : -artisMiktari);
            Sure = yeni;

            base.OnMouseWheel(e);
        }
    }
}