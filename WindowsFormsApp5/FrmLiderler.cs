using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmLiderler : Form
    {
        public FrmLiderler()
        {
            InitializeComponent();
        }

        private void FrmLiderler_Load(object sender, EventArgs e)
        {
            List<Neticə> siralama = NeticəIdarecisi.ButunNeticeleriGetir();
            lstLiderler.Items.Clear();

            int yer = 1;
            foreach (var neticə in siralama)
            {
                lstLiderler.Items.Add($"{yer}. {neticə.IstifadeciAdi} - {neticə.Xal} xal");
                yer++;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}