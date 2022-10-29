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
    public partial class Form1 : Form
    {
        private SqlConnection baglanti;
      

        public Form1()
        {
            InitializeComponent();
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-SLDHV1K; Initial Catalog=TakipOtomasyon;Integrated Security=True");
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       

        private void girisbutton_Click(object sender, EventArgs e)
        {
         
            string KullaniciAdi = kullanıcıtextbox.Text;
            string Sifre = sifretextbox.Text;
            baglanti = new SqlConnection("Data Source=DESKTOP-SLDHV1K; Initial Catalog=TakipOtomasyon;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM KullaniciBilgi where KullaniciAdi= '" + kullanıcıtextbox.Text + "' AND Sifre='" + sifretextbox.Text + "'";
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                anasayfa anasayfa=new anasayfa();
                anasayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
        
    }
}


