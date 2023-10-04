namespace ihbar_et
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ilComboBox = new System.Windows.Forms.ComboBox();
            this.ilceComboBox = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.adresRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lblAddressInfo = new System.Windows.Forms.Label();
            this.ihbarEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakir",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Düzce"});
            this.ilComboBox.Location = new System.Drawing.Point(179, 142);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(121, 21);
            this.ilComboBox.TabIndex = 0;
            this.ilComboBox.SelectedIndexChanged += new System.EventHandler(this.ilComboBox_SelectedIndexChanged);
            // 
            // ilceComboBox
            // 
            this.ilceComboBox.FormattingEnabled = true;
            this.ilceComboBox.Location = new System.Drawing.Point(179, 182);
            this.ilceComboBox.Name = "ilceComboBox";
            this.ilceComboBox.Size = new System.Drawing.Size(121, 21);
            this.ilceComboBox.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(97, 145);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Şehir";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(97, 185);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(24, 13);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "İlçe";
            // 
            // adresRichTextBox
            // 
            this.adresRichTextBox.Location = new System.Drawing.Point(179, 220);
            this.adresRichTextBox.Name = "adresRichTextBox";
            this.adresRichTextBox.Size = new System.Drawing.Size(299, 46);
            this.adresRichTextBox.TabIndex = 4;
            this.adresRichTextBox.Text = "";
            // 
            // lblAddressInfo
            // 
            this.lblAddressInfo.AutoSize = true;
            this.lblAddressInfo.Location = new System.Drawing.Point(97, 223);
            this.lblAddressInfo.Name = "lblAddressInfo";
            this.lblAddressInfo.Size = new System.Drawing.Size(58, 13);
            this.lblAddressInfo.TabIndex = 5;
            this.lblAddressInfo.Text = "Açık Adres";
            // 
            // ihbarEt
            // 
            this.ihbarEt.Location = new System.Drawing.Point(179, 286);
            this.ihbarEt.Name = "ihbarEt";
            this.ihbarEt.Size = new System.Drawing.Size(104, 61);
            this.ihbarEt.TabIndex = 6;
            this.ihbarEt.Text = "İhbar Et !";
            this.ihbarEt.UseVisualStyleBackColor = true;
            this.ihbarEt.Click += new System.EventHandler(this.ihbarEtButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 571);
            this.Controls.Add(this.ihbarEt);
            this.Controls.Add(this.lblAddressInfo);
            this.Controls.Add(this.adresRichTextBox);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.ilceComboBox);
            this.Controls.Add(this.ilComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ilComboBox;
        private System.Windows.Forms.ComboBox ilceComboBox;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblAddressInfo;
        private System.Windows.Forms.Button ihbarEt;
        private System.Windows.Forms.RichTextBox adresRichTextBox;
    }
}

