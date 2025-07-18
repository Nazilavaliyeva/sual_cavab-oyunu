using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class F_parol : Form
    {
        public F_parol()
        {
            InitializeComponent();
        }

        private void btntesdiqs_Click(object sender, EventArgs e)
        {
            // 1. Xanaların dolu olub-olmadığını yoxla
            if (string.IsNullOrWhiteSpace(txtemail.Text) || 
                string.IsNullOrWhiteSpace(txtyenisifre.Text) || 
                string.IsNullOrWhiteSpace(txtsifretekrar.Text))
            {
                MessageBox.Show("Zəhmət olmasa, bütün məlumatları daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Yeni şifrələrin eyni olub-olmadığını yoxla
            if (txtyenisifre.Text != txtsifretekrar.Text)
            {
                MessageBox.Show("Yeni şifrələr eyni deyil.", "Xəta", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Şifrəni yeniləməyə cəhd et
            bool ugurlu = IstifadeciIdarecisi.SifreniYenile(txtemail.Text, txtyenisifre.Text);

            if (ugurlu)
            {
                MessageBox.Show("Şifrəniz uğurla yeniləndi.", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu e-mail ilə qeydiyyatdan keçmiş istifadəçi tapılmadı.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btntesdiqs_Click_1(object sender, EventArgs e)
        {

        }
    }
}