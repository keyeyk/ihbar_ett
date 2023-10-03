using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihbar_et
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form yüklenirken il ComboBox'ına örnek il verileri ekleyelim
            ilComboBox.Items.Add("İstanbul");
            ilComboBox.Items.Add("Ankara");
            ilComboBox.Items.Add("İzmir");
            // İlçe ComboBox'ını boşaltalım
            ilceComboBox.Items.Clear();
        }

        private void ilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İlçe ComboBox'ını temizleyin
            ilceComboBox.Items.Clear();

            // Seçilen il'e göre ilçeleri ekleyin (örnek veri)
            string secilenIl = ilComboBox.SelectedItem.ToString();
            if (secilenIl == "İstanbul")
            {
                ilceComboBox.Items.Add("Kadıköy");
                ilceComboBox.Items.Add("Beşiktaş");
                ilceComboBox.Items.Add("Üsküdar");
                // Diğer ilçeleri eklemeye devam edin
            }
            else if (secilenIl == "Ankara")
            {
                ilceComboBox.Items.Add("Çankaya");
                ilceComboBox.Items.Add("Kızılay");
                ilceComboBox.Items.Add("Yenimahalle");
                // Diğer ilçeleri eklemeye devam edin
            }
            // Diğer iller için aynı işlemi yapın
        }

        private void ihbarEtButton_Click(object sender, EventArgs e)
        {
            // İl, ilçe ve açık adres bilgilerini alın
            string secilenIl = ilComboBox.SelectedItem?.ToString();
            string secilenIlce = ilceComboBox.SelectedItem?.ToString();
            string acikAdres = adresRichTextBox.Text;

            // Gerekli alanların dolu olup olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(secilenIl) || string.IsNullOrWhiteSpace(secilenIlce) || string.IsNullOrWhiteSpace(acikAdres))
            {
                MessageBox.Show("Lütfen il, ilçe ve açık adres alanlarını doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi burada sonlandırın
            }

            // İhbarı iletmek için gerekli işlemleri burada gerçekleştirin
            // Örneğin, bu bilgileri bir veritabanına kaydedebilir veya bir sunucuya iletebilirsiniz

            // İhbarın başarıyla iletilip iletilmediğini kontrol edin
            if (IhbariIletildiMi(secilenIl, secilenIlce, acikAdres))
            {
                MessageBox.Show("İhbar başarıyla iletilmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İhbar iletimi başarısız oldu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // İhbarı iletmek için gereken işlemi gerçekleştiren örnek bir fonksiyon
        private bool IhbariIletildiMi(string il, string ilce, string acikAdres)
        {
            // Burada ihbarın iletilip iletilmediğini kontrol etmek için gereken kodu ekleyin
            // Örneğin, bir veritabanına kaydetmek veya bir sunucuya göndermek gibi işlemler yapabilirsiniz

            // Örnek olarak her zaman başarılı olduğunu varsayalım
            return true;
        }

    }
}