using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik_Projesi
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti= new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\asamu\Desktop\C#\Access Database\Kütüphane.mdb""");


        private void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Kitap",baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            listele();
            txt_uye.Enabled = false;
        }

        

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text= dataGridView1.Rows[index].Cells[0].Value.ToString();
            txt_adi.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txt_yazar.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cmb_tur.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txt_sayfa.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            if ("True" == dataGridView1.Rows[index].Cells[5].Value.ToString())
            {
                radio_Kutuphane.Checked = true;
                radio_odunc.Checked = false;
            }
            else
            {
                radio_Kutuphane.Checked = false;
                radio_odunc.Checked = true;
            }
            txt_konum.Text=dataGridView1.Rows[index].Cells[6].Value.ToString();
            txt_uye.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            msk_tarih.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_id.Text))
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Delete From Kitap where Kitap_Id=@p1",baglanti);
                cmd.Parameters.AddWithValue("@p1",txt_id.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kitap Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tablodan bir kitap seçin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            int durum = 0;
            string kimde = txt_uye.Text;

            if (!string.IsNullOrEmpty(txt_id.Text) && !string.IsNullOrEmpty(txt_adi.Text) && !string.IsNullOrEmpty(txt_yazar.Text) && !string.IsNullOrEmpty(cmb_tur.Text) && !string.IsNullOrEmpty(txt_sayfa.Text) && !string.IsNullOrEmpty(txt_konum.Text) )
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Update kitap set Kitap_Ad=@p1,Yazar=@p2,Tur=@p3,Sayfa_Sayisi=@p4,Durum=@p5,Konumu=@p6,Uye_ID=@p7,Teslim_Tarihi=@p8 where Kitap_Id=@p9", baglanti);
                cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                cmd.Parameters.AddWithValue("@p2", txt_yazar.Text);
                cmd.Parameters.AddWithValue("@p3", cmb_tur.Text);
                cmd.Parameters.AddWithValue("@p4", txt_sayfa.Text);
                if (radio_Kutuphane.Checked)
                {
                    durum = 1;
                    kimde = "";
                }
                cmd.Parameters.AddWithValue("@p5", durum);
                cmd.Parameters.AddWithValue("@p6", txt_konum.Text);
                cmd.Parameters.AddWithValue("@p7",kimde);
                cmd.Parameters.AddWithValue("@p8", msk_tarih.Text);
                cmd.Parameters.AddWithValue("@p9", txt_id.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
                MessageBox.Show("Kitap Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       

        private void txt_kitapAdiBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Kitap where Kitap_Ad like '%" + txt_kitapAdiBul.Text+"%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_kitapAdiBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            txt_adi.Text = "";
            txt_id.Text = "";
            txt_kitapAdiBul.Text = "";
            txt_konum.Text = "";
            txt_sayfa.Text = "";
            txt_yazar.Text = "";
            cmb_tur.SelectedIndex = -1;
            radio_odunc.Checked = false;
            radio_Kutuphane.Checked = false;
            txt_uye.Text = "";
            msk_tarih.Text = "";
            listele();
        }

        private void radio_Kutuphane_CheckedChanged(object sender, EventArgs e)
        {
            txt_uye.Text = "UYE ID";
            txt_uye.Enabled=false;
            msk_tarih.Enabled=false;
        }

        private void radio_odunc_CheckedChanged(object sender, EventArgs e)
        {
            
            txt_uye.Enabled = true;
            msk_tarih.Enabled = true;
            txt_uye.Text = "";
            msk_tarih.Text = "";
        }

        private void btn_yeniUye_Click(object sender, EventArgs e)
        {
            Frm_uye frm_Uye = new Frm_uye();
            frm_Uye.Show();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txt_adi.Text) && !string.IsNullOrEmpty(txt_yazar.Text) && !string.IsNullOrEmpty(cmb_tur.Text) && !string.IsNullOrEmpty(txt_sayfa.Text))
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("insert into  Kitap(Kitap_Ad,Yazar,Tur,Sayfa_Sayisi,Durum,Konumu) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                cmd.Parameters.AddWithValue("@p2", txt_yazar.Text);
                cmd.Parameters.AddWithValue("@p3", cmb_tur.Text);
                cmd.Parameters.AddWithValue("@p4", txt_sayfa.Text);
                cmd.Parameters.AddWithValue("@p5", 1);
                cmd.Parameters.AddWithValue("@p6", txt_konum.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();
                MessageBox.Show("Kitap Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_yazarBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Kitap where Yazar like '%" + txt_yazarBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_yazarBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
    }
    
}
// Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\asamu\Desktop\C#\Access Database\Kitaplar.mdb"