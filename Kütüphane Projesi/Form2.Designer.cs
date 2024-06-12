namespace Kitaplik_Projesi
{
    partial class Frm_uye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_uye));
            this.txt_UyeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_tcBul = new System.Windows.Forms.MaskedTextBox();
            this.txt_idBul = new System.Windows.Forms.TextBox();
            this.msk_telefonBul = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_soyadiBul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AdiBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_UyeId
            // 
            this.txt_UyeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_UyeId.Enabled = false;
            this.txt_UyeId.Location = new System.Drawing.Point(223, 63);
            this.txt_UyeId.Margin = new System.Windows.Forms.Padding(6);
            this.txt_UyeId.Name = "txt_UyeId";
            this.txt_UyeId.Size = new System.Drawing.Size(248, 29);
            this.txt_UyeId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üye ID: ";
            // 
            // txt_adi
            // 
            this.txt_adi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_adi.Location = new System.Drawing.Point(223, 108);
            this.txt_adi.Margin = new System.Windows.Forms.Padding(6);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(248, 29);
            this.txt_adi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı: ";
            // 
            // txt_soyad
            // 
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Location = new System.Drawing.Point(223, 153);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(6);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(248, 29);
            this.txt_soyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyadı: ";
            // 
            // msk_tel
            // 
            this.msk_tel.Location = new System.Drawing.Point(223, 198);
            this.msk_tel.Mask = "+90 (999) 000-0000";
            this.msk_tel.Name = "msk_tel";
            this.msk_tel.Size = new System.Drawing.Size(248, 29);
            this.msk_tel.TabIndex = 9;
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(223, 243);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(248, 29);
            this.msk_tc.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon Numarası: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "TC No: ";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(223, 278);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(124, 38);
            this.btn_kaydet.TabIndex = 13;
            this.btn_kaydet.Text = "Ekle";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(790, 209);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(347, 278);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(124, 38);
            this.btn_guncelle.TabIndex = 15;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.msk_tcBul);
            this.panel1.Controls.Add(this.txt_idBul);
            this.panel1.Controls.Add(this.msk_telefonBul);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_soyadiBul);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_AdiBul);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(526, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 232);
            this.panel1.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 24);
            this.label11.TabIndex = 109;
            this.label11.Text = "TC: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 108;
            this.label10.Text = "Tel: ";
            // 
            // msk_tcBul
            // 
            this.msk_tcBul.Location = new System.Drawing.Point(80, 177);
            this.msk_tcBul.Mask = "00000000000";
            this.msk_tcBul.Name = "msk_tcBul";
            this.msk_tcBul.Size = new System.Drawing.Size(195, 29);
            this.msk_tcBul.TabIndex = 107;
            this.msk_tcBul.TextChanged += new System.EventHandler(this.msk_tcBul_TextChanged);
            // 
            // txt_idBul
            // 
            this.txt_idBul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_idBul.Location = new System.Drawing.Point(80, 41);
            this.txt_idBul.Margin = new System.Windows.Forms.Padding(6);
            this.txt_idBul.Name = "txt_idBul";
            this.txt_idBul.Size = new System.Drawing.Size(195, 29);
            this.txt_idBul.TabIndex = 106;
            this.txt_idBul.TextChanged += new System.EventHandler(this.txt_idBul_TextChanged);
            // 
            // msk_telefonBul
            // 
            this.msk_telefonBul.Location = new System.Drawing.Point(80, 143);
            this.msk_telefonBul.Mask = "+90 (999) 000-0000";
            this.msk_telefonBul.Name = "msk_telefonBul";
            this.msk_telefonBul.Size = new System.Drawing.Size(195, 29);
            this.msk_telefonBul.TabIndex = 106;
            this.msk_telefonBul.TextChanged += new System.EventHandler(this.msk_telefonBul_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 24);
            this.label9.TabIndex = 105;
            this.label9.Text = "ID: ";
            // 
            // txt_soyadiBul
            // 
            this.txt_soyadiBul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyadiBul.Location = new System.Drawing.Point(80, 109);
            this.txt_soyadiBul.Margin = new System.Windows.Forms.Padding(6);
            this.txt_soyadiBul.Name = "txt_soyadiBul";
            this.txt_soyadiBul.Size = new System.Drawing.Size(195, 29);
            this.txt_soyadiBul.TabIndex = 104;
            this.txt_soyadiBul.TextChanged += new System.EventHandler(this.txt_soyadiBul_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 103;
            this.label6.Text = "Soyadı: ";
            // 
            // txt_AdiBul
            // 
            this.txt_AdiBul.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_AdiBul.Location = new System.Drawing.Point(80, 75);
            this.txt_AdiBul.Margin = new System.Windows.Forms.Padding(6);
            this.txt_AdiBul.Name = "txt_AdiBul";
            this.txt_AdiBul.Size = new System.Drawing.Size(195, 29);
            this.txt_AdiBul.TabIndex = 101;
            this.txt_AdiBul.TextChanged += new System.EventHandler(this.txt_AdiBul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 100;
            this.label7.Text = "Adı: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 102;
            this.label8.Text = "UYE ARA";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(223, 322);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(124, 38);
            this.btn_listele.TabIndex = 105;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(347, 322);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(124, 38);
            this.btn_temizle.TabIndex = 106;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Frm_uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(851, 600);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.msk_tel);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UyeId);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Frm_uye";
            this.Text = "Uye Sayfası";
            this.Load += new System.EventHandler(this.Frm_uye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UyeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_tel;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_AdiBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_idBul;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_soyadiBul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msk_tcBul;
        private System.Windows.Forms.MaskedTextBox msk_telefonBul;
        private System.Windows.Forms.Button btn_temizle;
    }
}