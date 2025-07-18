using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmKateqoriyaSecimi : Form
    {
        private string istifadeciAdi;

        public FrmKateqoriyaSecimi(string istifadeci)
        {
            InitializeComponent();
            this.istifadeciAdi = istifadeci;
        }

        private void btnKateqoriya_Click(object sender, EventArgs e)
        {
            Button basilanDugme = sender as Button;
            string secilmisKateqoriya = basilanDugme.Text;

            this.Hide();
            Frmbacar testFormu = new Frmbacar(istifadeciAdi, secilmisKateqoriya);
            testFormu.ShowDialog();
            this.Close();
        }

        private void btnLiderler_Click(object sender, EventArgs e)
        {
            FrmLiderler liderlerFormu = new FrmLiderler();
            liderlerFormu.ShowDialog();
        }
    }
}