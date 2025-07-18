using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Qeydiyyat : Form
    {
        public Qeydiyyat()
        {
            InitializeComponent();
        }

        
        private void btntesdiqq_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtadq.Text) ||
                string.IsNullOrWhiteSpace(txtsoyadq.Text) ||
                string.IsNullOrWhiteSpace(txtmailq.Text) ||
                string.IsNullOrWhiteSpace(txtyenisifreq.Text) ||
                string.IsNullOrWhiteSpace(txtsifreq.Text))
            {
                MessageBox.Show("Zəhmət olmasa, bütün məlumatları daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Şifrələrin eyni olub-olmadığını yoxla
            if (txtyenisifreq.Text != txtsifreq.Text)
            {
                MessageBox.Show("Şifrələr eyni deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Yeni bir Istifadeci obyekti yarat
            Istifadeci yeniIstifadeci = new Istifadeci
            {
                Ad = txtadq.Text,
                Soyad = txtsoyadq.Text,
                DogumTarixi = txtdogumq.Text,
                Region = txtregionq.Text,
                Email = txtmailq.Text,
                Sifre = txtyenisifreq.Text
            };

            // 4. İstifadəçini qeydiyyatdan keçirməyə cəhd et
            bool ugurlu = IstifadeciIdarecisi.QeydiyyatdanKecir(yeniIstifadeci);

            if (ugurlu)
            {
                MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu e-mail adresi ilə artıq bir istifadəçi mövcuddur.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void Qeydiyyat_Load(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void lblregion_Click(object sender, EventArgs e) { }
        private void lblmail_Click(object sender, EventArgs e) { }
    }
}