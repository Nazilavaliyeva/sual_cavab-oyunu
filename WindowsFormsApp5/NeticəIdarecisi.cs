using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp5
{
    public static class NeticəIdarecisi
    {
        private static List<Neticə> neticeler;
        private static readonly string faylYolu = "neticeler.json";

        public static void NeticeleriYukle()
        {
            try
            {
                if (!File.Exists(faylYolu) || new FileInfo(faylYolu).Length == 0)
                {
                    neticeler = new List<Neticə>();
                    return;
                }
                string jsonMəzmunu = File.ReadAllText(faylYolu);
                neticeler = JsonConvert.DeserializeObject<List<Neticə>>(jsonMəzmunu) ?? new List<Neticə>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nəticələr yüklənərkən xəta baş verdi: {ex.Message}", "Xəta");
                neticeler = new List<Neticə>();
            }
        }

        public static void NeticeElaveEt(Neticə yeniNeticə)
        {
            neticeler.Add(yeniNeticə);
            string jsonMəzmunu = JsonConvert.SerializeObject(neticeler, Formatting.Indented);
            File.WriteAllText(faylYolu, jsonMəzmunu);
        }

        public static List<Neticə> ButunNeticeleriGetir()
        {
            return neticeler.OrderByDescending(n => n.Xal).ToList();
        }
    }
}