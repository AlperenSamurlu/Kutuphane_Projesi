namespace Kitaplik_Projesi
{
    partial class Frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_main));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_odunc = new System.Windows.Forms.RadioButton();
            this.radio_Kutuphane = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_kitapAdiBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_konum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.txt_uye = new System.Windows.Forms.TextBox();
            this.btn_iUye = new System.Windows.Forms.Button();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_yazarBul = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID: ";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(146, 46);
            this.txt_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(299, 29);
            this.txt_id.TabIndex = 99;
            // 
            // txt_adi
            // 
            this.txt_adi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_adi.Location = new System.Drawing.Point(146, 83);
            this.txt_adi.Margin = new System.Windows.Forms.Padding(6);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(299, 29);
            this.txt_adi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı: ";
            // 
            // txt_yazar
            // 
            this.txt_yazar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_yazar.Location = new System.Drawing.Point(146, 120);
            this.txt_yazar.Margin = new System.Windows.Forms.Padding(6);
            this.txt_yazar.Name = "txt_yazar";
            this.txt_yazar.Size = new System.Drawing.Size(299, 29);
            this.txt_yazar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazar: ";
            // 
            // cmb_tur
            // 
            this.cmb_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Items.AddRange(new object[] {
            "Tiyatro",
            "Hikaye",
            "Roman",
            "Biyografi",
            "Macera"});
            this.cmb_tur.Location = new System.Drawing.Point(146, 194);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(299, 32);
            this.cmb_tur.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür: ";
            // 
            // radio_odunc
            // 
            this.radio_odunc.AutoSize = true;
            this.radio_odunc.Location = new System.Drawing.Point(146, 313);
            this.radio_odunc.Name = "radio_odunc";
            this.radio_odunc.Size = new System.Drawing.Size(135, 28);
            this.radio_odunc.TabIndex = 5;
            this.radio_odunc.TabStop = true;
            this.radio_odunc.Text = "Ödünç alındı";
            this.radio_odunc.UseVisualStyleBackColor = true;
            this.radio_odunc.CheckedChanged += new System.EventHandler(this.radio_odunc_CheckedChanged);
            // 
            // radio_Kutuphane
            // 
            this.radio_Kutuphane.AutoSize = true;
            this.radio_Kutuphane.Location = new System.Drawing.Point(146, 279);
            this.radio_Kutuphane.Name = "radio_Kutuphane";
            this.radio_Kutuphane.Size = new System.Drawing.Size(142, 28);
            this.radio_Kutuphane.TabIndex = 6;
            this.radio_Kutuphane.TabStop = true;
            this.radio_Kutuphane.Text = "Kütüphanede";
            this.radio_Kutuphane.UseVisualStyleBackColor = true;
            this.radio_Kutuphane.CheckedChanged += new System.EventHandler(this.radio_Kutuphane_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durum: ";
            // 
            // txt_sayfa
            // 
            this.txt_sayfa.Location = new System.Drawing.Point(146, 157);
            this.txt_sayfa.Margin = new System.Windows.Forms.Padding(6);
            this.txt_sayfa.Name = "txt_sayfa";
            this.txt_sayfa.Size = new System.Drawing.Size(299, 29);
            this.txt_sayfa.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sayfa: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(972, 184);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(454, 47);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(156, 41);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(454, 139);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(156, 41);
            this.btn_güncelle.TabIndex = 9;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(454, 93);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(156, 41);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Kitap Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(454, 185);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(156, 41);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Kitap Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_kitapAdiBul
            // 
            this.txt_kitapAdiBul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_kitapAdiBul.Location = new System.Drawing.Point(91, 46);
            this.txt_kitapAdiBul.Margin = new System.Windows.Forms.Padding(6);
            this.txt_kitapAdiBul.Name = "txt_kitapAdiBul";
            this.txt_kitapAdiBul.Size = new System.Drawing.Size(249, 29);
            this.txt_kitapAdiBul.TabIndex = 101;
            this.txt_kitapAdiBul.TextChanged += new System.EventHandler(this.txt_kitapAdiBul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 100;
            this.label7.Text = "Kitap Adı: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 102;
            this.label8.Text = "KİTAP ARA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txt_yazarBul);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_kitapAdiBul);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(628, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 179);
            this.panel1.TabIndex = 103;
            // 
            // txt_konum
            // 
            this.txt_konum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_konum.Location = new System.Drawing.Point(146, 237);
            this.txt_konum.Margin = new System.Windows.Forms.Padding(6);
            this.txt_konum.Name = "txt_konum";
            this.txt_konum.Size = new System.Drawing.Size(299, 29);
            this.txt_konum.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 105;
            this.label9.Text = "Hangi Rafa Ait:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(454, 232);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(156, 41);
            this.btn_temizle.TabIndex = 106;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txt_uye
            // 
            this.txt_uye.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_uye.Location = new System.Drawing.Point(178, 342);
            this.txt_uye.Margin = new System.Windows.Forms.Padding(6);
            this.txt_uye.Name = "txt_uye";
            this.txt_uye.Size = new System.Drawing.Size(91, 29);
            this.txt_uye.TabIndex = 107;
            this.txt_uye.Text = "ÜYE ID ";
            // 
            // btn_iUye
            // 
            this.btn_iUye.Location = new System.Drawing.Point(454, 279);
            this.btn_iUye.Name = "btn_iUye";
            this.btn_iUye.Size = new System.Drawing.Size(156, 41);
            this.btn_iUye.TabIndex = 108;
            this.btn_iUye.Text = "Üye Formu";
            this.btn_iUye.UseVisualStyleBackColor = true;
            this.btn_iUye.Click += new System.EventHandler(this.btn_yeniUye_Click);
            // 
            // msk_tarih
            // 
            this.msk_tarih.Location = new System.Drawing.Point(317, 342);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(118, 29);
            this.msk_tarih.TabIndex = 109;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 315);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 24);
            this.label10.TabIndex = 110;
            this.label10.Text = "Teslim Tarihi ";
            // 
            // txt_yazarBul
            // 
            this.txt_yazarBul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_yazarBul.Location = new System.Drawing.Point(91, 87);
            this.txt_yazarBul.Margin = new System.Windows.Forms.Padding(6);
            this.txt_yazarBul.Name = "txt_yazarBul";
            this.txt_yazarBul.Size = new System.Drawing.Size(249, 29);
            this.txt_yazarBul.TabIndex = 104;
            this.txt_yazarBul.TextChanged += new System.EventHandler(this.txt_yazarBul_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 103;
            this.label11.Text = "Yazar: ";
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1001, 626);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.msk_tarih);
            this.Controls.Add(this.btn_iUye);
            this.Controls.Add(this.txt_uye);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.txt_konum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_sayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radio_Kutuphane);
            this.Controls.Add(this.radio_odunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_tur);
            this.Controls.Add(this.txt_yazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_main";
            this.Text = "Kütüphane Uygulaması";
            this.Load += new System.EventHandler(this.Frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_odunc;
        private System.Windows.Forms.RadioButton radio_Kutuphane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_kitapAdiBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_konum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.TextBox txt_uye;
        private System.Windows.Forms.Button btn_iUye;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_yazarBul;
        private System.Windows.Forms.Label label11;
    }
}

