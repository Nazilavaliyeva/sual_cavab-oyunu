using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO; 
using Newtonsoft.Json; 

namespace WindowsFormsApp5
{
    public partial class Frmbacar : Form
    {
        private List<Sual> butunSuallar;
        private List<Sual> suallarSiyahisi;
        private int hazirkiSualIndeksi = 0;
        private int duzgunCavabSayi = 0;
        private int sehvCavabSayi = 0;
        private int umumiXal = 0;

        private const int SUAL_UCUN_VAXT = 20;
        private int qalanVaxt;

        private int komekHakki = 5;

        public Frmbacar(string istifadeciAdi, string secilmisKateqoriya)
        {
            InitializeComponent();
            lbluser.Text = istifadeciAdi;
            TestiBaslat(secilmisKateqoriya);
        }

        private void SesiOynat(string faylYolu)
        {
            try
            {
                axWindowsMediaPlayer1.URL = faylYolu;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Səs faylı ilə bağlı xəta: {faylYolu}, Xəta: {ex.Message}");
            }
        }



        private void TestiBaslat(string kateqoriya)
        {
            try
            {
                string jsonMəzmunu = File.ReadAllText("suallar.json");
                butunSuallar = JsonConvert.DeserializeObject<List<Sual>>(jsonMəzmunu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Suallar yüklənərkən xəta baş verdi: {ex.Message}\nProqram bağlanacaq.", "Kritik Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                butunSuallar = new List<Sual>();
                this.Close();
                return;
            }

            if (kateqoriya == "Qarışıq")
            {
                suallarSiyahisi = butunSuallar;
            }
            else
            {
                suallarSiyahisi = butunSuallar.Where(s => s.Kateqoriya == kateqoriya).ToList();
            }

            if (suallarSiyahisi.Count == 0)
            {
                MessageBox.Show("Bu kateqoriyada hələlik sual yoxdur.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            komekHakki = 5;
            btn5050.Text = $"50/50 ({komekHakki})";
            btn5050.Enabled = true;

            btn_a.Click += new EventHandler(VariantaKlik);
            btn_b.Click += new EventHandler(VariantaKlik);
            btn_c.Click += new EventHandler(VariantaKlik);
            btn_d.Click += new EventHandler(VariantaKlik);

            timer1.Interval = 1000;

            SualiGoster(hazirkiSualIndeksi);
        }

        private void SualiGoster(int indeks)
        {
            if (indeks < suallarSiyahisi.Count)
            {
                Sual hazirkiSual = suallarSiyahisi[indeks];
                richtxtsual.Text = hazirkiSual.SualMetni;
                btn_a.Text = "A) " + hazirkiSual.VariantA;
                btn_b.Text = "B) " + hazirkiSual.VariantB;
                btn_c.Text = "C) " + hazirkiSual.VariantC;
                btn_d.Text = "D) " + hazirkiSual.VariantD;

                lblsual.Text = $"Sual: {indeks + 1}/{suallarSiyahisi.Count}";
                lblduzgun.Text = "Düzgün: " + duzgunCavabSayi;
                lblsualatla.Text = "Səhv: " + sehvCavabSayi;
                lbl_xal.Text = "Xal: " + umumiXal;

                DugmeleriSifirla();

                qalanVaxt = SUAL_UCUN_VAXT;
                lbl_vaxt.Text = $"Qalan vaxt: {qalanVaxt} san.";
                timer1.Start();
            }
            else
            {
                TestiBitir();
            }
        }

        private void VariantaKlik(object sender, EventArgs e)
        {
            timer1.Stop();

            Button basilanDugme = sender as Button;
            string secilmisVariant = basilanDugme.Name.Split('_')[1].ToUpper();
            string dogruVariant = suallarSiyahisi[hazirkiSualIndeksi].DogruCavabVariantı;

            VariantlariSondur();

            if (secilmisVariant == dogruVariant)
            {
                duzgunCavabSayi++;
                umumiXal += 10;
                basilanDugme.BackColor = Color.Green;
                pb_yes.Visible = true;
                SesiOynat(@"C:\Users\murad\OneDrive\Masaüstü\ses faylari\dogru_ses.wav");
            }
            else
            {
                sehvCavabSayi++;
                umumiXal -= 5;
                basilanDugme.BackColor = Color.Red;
                pb_no.Visible = true;
                SesiOynat(@"C:\Users\murad\OneDrive\Masaüstü\ses faylari\sehv_ses.wav");

                Button dogruDugme = this.Controls.Find("btn_" + dogruVariant.ToLower(), true).FirstOrDefault() as Button;
                if (dogruDugme != null) dogruDugme.BackColor = Color.Green;
            }
            btn_ireli.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SesiOynat(@"C:\Users\murad\OneDrive\Masaüstü\ses faylari\Saniye.wav");

            qalanVaxt--;
            lbl_vaxt.Text = $"Qalan vaxt: {qalanVaxt} san.";

            if (qalanVaxt <= 0)
            {
                timer1.Stop();
                lbl_vaxt.Text = "Vaxt bitdi!";

                SesiOynat(@"C:\Users\murad\OneDrive\Masaüstü\ses faylari\sehv_ses.wav");

                sehvCavabSayi++;
                umumiXal -= 5;
                lblsualatla.Text = "Səhv: " + sehvCavabSayi;
                lbl_xal.Text = "Xal: " + umumiXal;

                VariantlariSondur();
                string dogruVariant = suallarSiyahisi[hazirkiSualIndeksi].DogruCavabVariantı;
                Button dogruDugme = this.Controls.Find("btn_" + dogruVariant.ToLower(), true).FirstOrDefault() as Button;
                if (dogruDugme != null) dogruDugme.BackColor = Color.Green;

                pb_no.Visible = true;
                btn_ireli.Enabled = true;
            }
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            if (komekHakki <= 0) return;
            if (!btn_a.Enabled) return;

            komekHakki--;
            btn5050.Text = $"50/50 ({komekHakki})";
            btn5050.Enabled = false;

            string dogruVariant = suallarSiyahisi[hazirkiSualIndeksi].DogruCavabVariantı;

            List<Button> sehvVariantlar = new List<Button>();
            if ("A" != dogruVariant) sehvVariantlar.Add(btn_a);
            if ("B" != dogruVariant) sehvVariantlar.Add(btn_b);
            if ("C" != dogruVariant) sehvVariantlar.Add(btn_c);
            if ("D" != dogruVariant) sehvVariantlar.Add(btn_d);

            Random random = new Random();
            sehvVariantlar = sehvVariantlar.OrderBy(x => random.Next()).ToList();

            sehvVariantlar[0].Visible = false;
            sehvVariantlar[1].Visible = false;
        }

        private void DugmeleriSifirla()
        {
            var dugmeler = new List<Button> { btn_a, btn_b, btn_c, btn_d };
            foreach (var dugme in dugmeler)
            {
                dugme.Enabled = true;
                dugme.Visible = true;
                dugme.BackColor = Color.FromArgb(0, 123, 255);
            }

            pb_yes.Visible = false;
            pb_no.Visible = false;
            btn_ireli.Enabled = false;
        }

        private void btn_ireli_Click(object sender, EventArgs e)
        {
            hazirkiSualIndeksi++;
            SualiGoster(hazirkiSualIndeksi);
        }

        private void VariantlariSondur()
        {
            btn_a.Enabled = false;
            btn_b.Enabled = false;
            btn_c.Enabled = false;
            btn_d.Enabled = false;
        }

        private void TestiBitir()
        {
            timer1.Stop();
            Neticə yeniNeticə = new Neticə { IstifadeciAdi = lbluser.Text, Xal = umumiXal };
            NeticəIdarecisi.NeticeElaveEt(yeniNeticə);
            MessageBox.Show($"Test bitdi!\n\nCəmi Sual: {suallarSiyahisi.Count}\nDüzgün Cavab: {duzgunCavabSayi}\nSəhv Cavab: {sehvCavabSayi}\n\nÜmumi Xal: {umumiXal}", "Nəticə", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Refresh();
            btn_ireli.Enabled = false;
            btn_geri.Enabled = true;
            
        }
    }
}