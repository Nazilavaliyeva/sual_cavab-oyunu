using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            IstifadeciIdarecisi.IstifadecileriYukle();
            NeticəIdarecisi.NeticeleriYukle();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            IstifadeciIdarecisi.IstifadecileriYaddaSaxla();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Qeydiyyat qeydiyyatFormu = new Qeydiyyat();
            qeydiyyatFormu.ShowDialog();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtsifre.Text))
            {
                MessageBox.Show("E-mail və şifrə daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = txtname.Text;
            string sifre = txtsifre.Text;

            Istifadeci dogrulanmisIstifadeci = IstifadeciIdarecisi.IstifadeciniYoxla(email, sifre);

            if (dogrulanmisIstifadeci != null)
            {
                this.Hide();

                FrmKateqoriyaSecimi kategoriyaFormu = new FrmKateqoriyaSecimi(dogrulanmisIstifadeci.Ad + " " + dogrulanmisIstifadeci.Soyad);
                kategoriyaFormu.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("E-mail və ya şifrə yanlışdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_parol parolFormu = new F_parol();
            parolFormu.ShowDialog();
        }
    }
}