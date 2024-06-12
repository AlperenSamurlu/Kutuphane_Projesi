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
    public partial class Frm_uye : Form
    {
        public Frm_uye()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\asamu\Desktop\C#\Access Database\Kütüphane.mdb""");
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_adi.Text) &&!string.IsNullOrEmpty(txt_soyad.Text) &&!string.IsNullOrEmpty(msk_tel.Text) && !string.IsNullOrEmpty(msk_tc.Text))
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("insert into  Uye(Ad,Soyad,Telefon,TC) values (@p1,@p2,@p3,@p4)", baglanti);
                cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
                cmd.Parameters.AddWithValue("@p3", msk_tel.Text);
                cmd.Parameters.AddWithValue("@p4", msk_tc.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();
                MessageBox.Show("Uye Kaydı Yapıldı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Frm_uye_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from Uye", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        private void temizle()
        {
            txt_adi.Text = "";
            txt_soyad.Text = "";
            msk_tel.Text = "";
            msk_tc.Text = "";
            txt_UyeId.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            txt_UyeId.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txt_adi.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            msk_tel.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            msk_tc.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_adi.Text) && !string.IsNullOrEmpty(txt_soyad.Text) && !string.IsNullOrEmpty(msk_tel.Text) && !string.IsNullOrEmpty(msk_tc.Text)) 
            {
                baglanti.Open();
                OleDbCommand cmd = new OleDbCommand("Update Uye set Ad=@p1,Soyad=@p2,Telefon=@p3,TC=@p4 where Uye_Id=@p5", baglanti);
                cmd.Parameters.AddWithValue("@p1", txt_adi.Text);
                cmd.Parameters.AddWithValue("@p2", txt_soyad.Text);
                cmd.Parameters.AddWithValue("@p3", msk_tel.Text);
                cmd.Parameters.AddWithValue("@p4", msk_tc.Text);
                cmd.Parameters.AddWithValue("@p5", txt_UyeId.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listele();
                temizle();
                MessageBox.Show("Uye Bilgisi Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void txt_idBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Uye where Uye_Id like '%" + txt_idBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_idBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void txt_AdiBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Uye where Ad like '%" + txt_AdiBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_AdiBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void txt_soyadiBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Uye where Soyad like '%" + txt_soyadiBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", txt_soyadiBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

      

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void msk_telefonBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Uye where Telefon like '%" + msk_telefonBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", msk_telefonBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }

        private void msk_tcBul_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from Uye where TC like '%" + msk_tcBul.Text + "%'", baglanti);
            cmd.Parameters.AddWithValue("@p1", msk_tcBul.Text);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
    }
}
