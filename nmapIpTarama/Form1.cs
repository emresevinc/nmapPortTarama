using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nmapIpTarama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int basim = 0;
        private void tara_btn_Click(object sender, EventArgs e)
        {
            basim++;
            Boolean karsilastirmaYapabilirsin = false;
            List<String> list = taramaYap(ipAdress_txt.Text);
            if (basim % 2 == 1)
                tara_btn.Text = "YENİDEN TARA";// butona güüncel liste için basıldığında text özelliğini değiştirecek
            else
                tara_btn.Text = "TARA";
            foreach (String item in list)
            {
                if (basim %2 == 1)
                {
                    eskiListe.Items.Clear();
                    eskiListe.Items.Add(item); // open portlar listeye ekleniyor.
                }
                else
                {
                    yeniListe.Items.Clear();
                    yeniListe.Items.Add(item); // open portlar listeye ekleniyor.
                    karsilastirmaYapabilirsin = true;
                }
            }
            if (karsilastirmaYapabilirsin == true)
            {
                karsilastirmaYap(eskiListe, yeniListe, 1);
                karsilastirmaYap(yeniListe, eskiListe, 2);
            }
        }

        public List<String> taramaYap(String ipAdress) 
        {
            System.Diagnostics.ProcessStartInfo procStartInfo =
        new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "nmap " + ipAdress);// süreç başlatma bilgileri için ilgili sınıftan nesne yaratıp
                                                                                    //nmap'i kullanmak için cmd.exe'yi açıyoruz.
            procStartInfo.RedirectStandardOutput = true;// Output özelliğini aktif ediyoruz.
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();// çalışacak sürecimizi oluşturuyoruz.
            proc.StartInfo = procStartInfo;
            proc.Start();
            List<String> result= new List<string>();
            String temp; 
            while ((temp = proc.StandardOutput.ReadLine()) != null)
            {
                String[] parcalar; 
                parcalar = temp.Split(' ');
                foreach (String item in parcalar)// seçilen satırlar arasıdan open kelimesi bulunarak açık portlar bulunuyor.
                {
                    if (item.Equals("open"))
                    {
                        result.Add(temp);
                    }
                }
            }
            return result;
        }

        // bu fonksiyon ile open olarak bulunan portlar eski ve yeni olarak karşılaştıracak ve durum bilgisini sunacak.
        public void karsilastirmaYap(ListBox eskiList,ListBox yeniList,int kacinciCalisma) 
        {
            Boolean kontrol = false;

            for (int i = 0; i < eskiList.Items.Count; i++)
            {
                kontrol = false;
                for (int j = 0; j < yeniList.Items.Count; j++)
                {
                    if (eskiList.Items[i].Equals(yeniList.Items[j]))
                    {
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol==false)
                {
                    if (kacinciCalisma == 1)
                    {
                        genelSonuc_txt.Text += eskiList.Items[i].ToString() + " artık open değil /n";
                    }
                    else if(kacinciCalisma ==2)
                    {
                        genelSonuc_txt.Text += eskiList.Items[i].ToString() + " artık open /n";
                    }
                }
                if (genelSonuc_txt.Text.Equals(""))
                    genelSonuc_txt.Text = "Değişiklik yok";
            }
        
        }
    }
}
