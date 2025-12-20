using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        private int _kalanSaniye = 0;
        private bool _sayacCalisiyor = false;
        private int _baslangicSaniye = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;

            neonRing1.MaksimumSure = 24 * 60;
            if (neonRing1.Sure > neonRing1.MaksimumSure)
                neonRing1.Sure = neonRing1.MaksimumSure;

            lblBilgi.Text = "Süre ayarlamak için Mouse tekerleğini kullanın.\n(Hızlı sarmak için Shift tuşuna basılı tutun)";

            this.FormClosing += Form1_FormClosing;

            neonRing1.SureDegisti += (_, __) =>
            {
                if (!_sayacCalisiyor)
                    lblBilgi.Text = $"Seçilen süre: {SureFormatla(neonRing1.Sure)}\nBaşlatmak için BAŞLAT butonuna basın.";
            };
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!_sayacCalisiyor)
            {
                int secilenDakika = neonRing1.Sure;

                if (secilenDakika <= 0)
                {
                    MessageBox.Show("Lütfen önce bir süre belirleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _baslangicSaniye = secilenDakika * 60;
                _kalanSaniye = _baslangicSaniye;
                _sayacCalisiyor = true;

                ShutdownPlanla(_kalanSaniye);
                timer1.Start();

                btnBaslat.Text = "İPTAL ET";
                neonRing1.Enabled = false;

                lblBilgi.Text = $"Bilgisayarınız {secilenDakika} dakika sonra\notomatik olarak kapatılacak.";
            }
            else
            {
                Sifirla();
                lblBilgi.Text = "Geri sayım iptal edildi.\nBilgisayarınız kapatılmayacak.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_kalanSaniye > 0)
            {
                _kalanSaniye--;

                neonRing1.Sure = (int)Math.Ceiling((double)_kalanSaniye / 60);

                lblBilgi.Text = KalanSureYazisi(_kalanSaniye) + "\nKapatmayı iptal etmek için İPTAL ET'e basın.";
            }
            else
            {
                timer1.Stop();
                lblBilgi.Text = "Süre doldu! Bilgisayar kapatılıyor...";
                _sayacCalisiyor = false;
            }
        }

        private void Sifirla()
        {
            timer1.Stop();
            _sayacCalisiyor = false;
            _kalanSaniye = 0;
            _baslangicSaniye = 0;

            ShutdownIptal();

            btnBaslat.Text = "BAŞLAT";

            neonRing1.Enabled = true;
            neonRing1.Sure = 0;
            neonRing1.Invalidate();

            lblBilgi.Text = "Süre ayarlamak için Mouse tekerleğini kullanın.\n(Hızlı sarmak için Shift tuşuna basılı tutun)";
        }

        private void btnX_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sayacCalisiyor)
            {
                var secim = MessageBox.Show(
                    "Geri sayım aktif.\n\nEğer uygulamayı kapatırsan kapatma işlemi Windows tarafından yine de devam eder.\nKapatmayı iptal etmek ister misin?",
                    "Uyarı",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (secim == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }

                if (secim == DialogResult.Yes)
                {
                    ShutdownIptal();
                }
            }
        }

        private void ShutdownPlanla(int saniye)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "shutdown",
                    Arguments = $"/s /f /t {Math.Max(0, saniye)}",
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kapatma planlanamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Sifirla();
            }
        }

        private void ShutdownIptal()
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "shutdown",
                    Arguments = "/a",
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(psi);
            }
            catch
            {
            }
        }

        private string KalanSureYazisi(int saniye)
        {
            if (saniye < 0) saniye = 0;
            int dk = saniye / 60;
            int sn = saniye % 60;

            if (dk <= 0)
                return $"Kalan: {sn} sn";

            return $"Kalan: {dk} dk {sn} sn";
        }

        private string SureFormatla(int dakika)
        {
            if (dakika < 0) dakika = 0;
            if (dakika < 60) return $"{dakika} dk";

            int saat = dakika / 60;
            int dk = dakika % 60;
            return $"{saat} sa {dk} dk";
        }
    }
}