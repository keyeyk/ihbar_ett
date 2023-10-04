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
    public partial class HaritaForm : Form
    {
        public HaritaForm()
        {
            InitializeComponent();
        }

        private void HaritaForm_Load(object sender, EventArgs e)
        {
            // Google Haritalar'ı yüklemek için bir HTML sayfasını gömün
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.OpenNew(true);
            webBrowser1.Document.Write("<html><head><title>Harita</title></head><body><div id='harita' style='width:100%;height:100%;'></div><script src='https://maps.googleapis.com/maps/api/js?key= YOUR_API_KEY &callback=initMap' async defer></script><script>function initMap() { var map = new google.maps.Map(document.getElementById('harita'), { zoom: 16, center: { lat: LATITUDE, lng: LONGITUDE } }); var marker = new google.maps.Marker({ position: { lat: LATITUDE, lng: LONGITUDE }, map: map }); }</script></body></html>");

            // LATITUDE ve LONGITUDE koordinatlarını belirleyin
            double latitude = 41.8781; // Örnek enlem
            double longitude = -87.6298; // Örnek boylam

            // Belirli bir koordinatın adresini almak için Google Geocoding API'yi kullanabilirsiniz
            // Bu örnek sadece harita gösterimini içerir
        }


    }
}
