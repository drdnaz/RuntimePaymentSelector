using System.Reflection;
using System.Text.RegularExpressions;
using NisanOdev3.Interface;

namespace NisanOdev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // odeeme yöntemleri çok olduğundan list içinde tutuyoruz.
            List<Type> odemeYontemleri = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && t.IsClass).ToList();
            //hepsini almak istemiyoruz çünkü form1 var o var bu var ondan where kullandım. 
            // anlık oluşturullmuş tüm kodlara erişim için GetExecutingAssembly() kullanıyoruz.

            cmbOdemeYontemi.DataSource = odemeYontemleri;
            cmbOdemeYontemi.DisplayMember = "Name";


        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                Type? secilenTip = cmbOdemeYontemi.SelectedItem as Type;
                if (secilenTip is not null)
                {
                    var nesne = Activator.CreateInstance(secilenTip) as IOdemeYontemi;// proje çalışırken nesne üretmemizi sağlar= CreateInstance
                    string sonuc = nesne.Ode(tutar);
                    lblSonuc.Text = sonuc;
                }
            }

        }

        private void btnKlasorAra_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //ShowDialog dosya seçim ekranını gösterir.ama sonuç ok dönerse.
                    listBox1.Items.Clear();
                    KlasorAra(dialog.SelectedPath);


                }
            }
        }

        private void KlasorAra(string dosyaYolu)
        {
            string[]? klasorler = Directory.GetDirectories(dosyaYolu, "*", SearchOption.AllDirectories);
            foreach (string klasor in klasorler)
            {
                string klasorAdi = "Klasör: "+ Path.GetFileName(klasor);
                listBox1.Items.Add(klasorAdi);

                var csDosyalari = Directory.GetFiles(klasor, " *.cs");

                foreach (var dosya in  csDosyalari)
                {
                    string[] satirlar = File.ReadAllLines(dosya);

                    foreach (string satir in satirlar)
                    {
                        if (satir.Trim().StartsWith("public class"))
                        {
                            string classAdi = Regex.Match(satir, @"class\s+(\w+)").Groups[1].Value;
                            if (!string.IsNullOrEmpty(classAdi))
                            {
                                listBox1.Items.Add(" - " + classAdi);
                            }
                        }
                    }
                }


            }


        }
    }
}
