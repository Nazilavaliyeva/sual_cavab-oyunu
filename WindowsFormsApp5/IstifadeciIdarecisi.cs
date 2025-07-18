using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public static class IstifadeciIdarecisi
    {
        private static List<Istifadeci> istifadeciler = new List<Istifadeci>();
        private static readonly string faylYolu = "istifadeciler.json";

        public static void IstifadecileriYukle()
        {
            try
            {
                if (!File.Exists(faylYolu) || new FileInfo(faylYolu).Length == 0)
                {
                    istifadeciler = new List<Istifadeci>();
                    return;
                }

                string jsonMəzmunu = File.ReadAllText(faylYolu);
                istifadeciler = JsonConvert.DeserializeObject<List<Istifadeci>>(jsonMəzmunu);

                if (istifadeciler == null)
                {
                    istifadeciler = new List<Istifadeci>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstifadəçi məlumatları yüklənərkən xəta baş verdi: {ex.Message}", "Xəta");
                istifadeciler = new List<Istifadeci>();
            }
        }


        public static void IstifadecileriYaddaSaxla()
        {
            try
            {
                string jsonMəzmunu = JsonConvert.SerializeObject(istifadeciler, Formatting.Indented);
                File.WriteAllText(faylYolu, jsonMəzmunu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstifadəçi məlumatları yadda saxlanarkən xəta baş verdi: {ex.Message}", "Xəta");
            }
        }

        public static bool QeydiyyatdanKecir(Istifadeci yeniIstifadeci)
        {
            if (istifadeciler.Any(i => i.Email.Equals(yeniIstifadeci.Email, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            istifadeciler.Add(yeniIstifadeci);
            return true;
        }

        public static Istifadeci IstifadeciniYoxla(string email, string sifre)
        {
            return istifadeciler.FirstOrDefault(i => i.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && i.Sifre == sifre);
        }

        public static bool SifreniYenile(string email, string yeniSifre)
        {
            Istifadeci yenilenecekIstifadeci = istifadeciler.FirstOrDefault(i => i.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (yenilenecekIstifadeci != null)
            {
                yenilenecekIstifadeci.Sifre = yeniSifre;
                return true;
            }
            return false;
        }
    }
}