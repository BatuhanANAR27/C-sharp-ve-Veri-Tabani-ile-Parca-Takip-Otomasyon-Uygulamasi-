using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace takipotomasyonu
{
    public partial class anasayfa : Form
    {

        SqlConnection baglanti = sınıf.baglan();
        public anasayfa()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        void parcagetir()
        {
            baglanti.Open();
            dataGridView1.DataSource = sınıf.dtdoldur("select * from ParcaBilgi");
            baglanti.Close();
        }


        private void anasayfa_Load(object sender, EventArgs e)
        {
            parcagetir();

        }
        private void temizle()
        {
            SeriNoTextBox.Text = "";
            ParcaAdiTextBox.Text = "";
            ModelTextBox.Text = "";
            AlisTextBox.Text = "";
            SatisTextBox.Text = "";
            StokTextBox.Text = "";
            
        }

        

        private void takipOtomasyonDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AraTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sınıf.dtdoldur("select * from ParcaBilgi where ParcaAdi like '%" + AraTextBox.Text + "%'");
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into ParcaBilgi (ParcaSeriNo,ParcaAdi,Arac,AlisFiyati,SatisFiyati,StokAdedi) values (@ParcaSeriNo,@ParcaAdi,@Arac,@AlisFiyati,@SatisFiyati,@StokAdedi)";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@ParcaSeriNo", SeriNoTextBox.Text);
            cmd.Parameters.AddWithValue("@ParcaAdi", ParcaAdiTextBox.Text);
            cmd.Parameters.AddWithValue("@Arac", ModelTextBox.Text);
            cmd.Parameters.AddWithValue("@AlisFiyati", AlisTextBox.Text);
            cmd.Parameters.AddWithValue("@SatisFiyati", SatisTextBox.Text);
            cmd.Parameters.AddWithValue("@StokAdedi", StokTextBox.Text);
            //cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Parça Bilgileri Başarıyla Kaydedildi...");
            parcagetir();
            temizle();
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE ParcaBilgi Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Parça Bilgileri Başarıyla Silindi...");
            parcagetir();
            temizle();
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "update ParcaBilgi Set ParcaSeriNo=@ParcaSeriNo, ParcaAdi=@ParcaAdi, Arac=@Arac, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, StokAdedi=@StokAdedi Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@ParcaSeriNo", SeriNoTextBox.Text);
            cmd.Parameters.AddWithValue("@ParcaAdi", ParcaAdiTextBox.Text);
            cmd.Parameters.AddWithValue("@Arac", ModelTextBox.Text);
            cmd.Parameters.AddWithValue("@AlisFiyati", AlisTextBox.Text);
            cmd.Parameters.AddWithValue("@SatisFiyati", SatisTextBox.Text);
            cmd.Parameters.AddWithValue("@StokAdedi", StokTextBox.Text);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Parça Bilgileri Başarıyla Kaydedildi...");
            parcagetir();
            temizle();
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            SeriNoTextBox.Text = satır.Cells[1].Value.ToString();
            ParcaAdiTextBox.Text = satır.Cells[2].Value.ToString();
            ModelTextBox.Text = satır.Cells[3].Value.ToString();
            AlisTextBox.Text = satır.Cells[4].Value.ToString();
            SatisTextBox.Text = satır.Cells[5].Value.ToString();
            StokTextBox.Text = satır.Cells[6].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}


