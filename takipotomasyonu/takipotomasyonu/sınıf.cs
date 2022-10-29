using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace takipotomasyonu
{
    class sınıf
    {
        private SqlConnection baglanti;
        public static SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = ("Data Source=DESKTOP-SLDHV1K;Initial Catalog=TakipOtomasyon;  Integrated Security = True ");
            return baglanti;
        }
        public static DataTable dtdoldur(string SqlSorgusu)
        {
            SqlConnection baglanti = baglan();            //yukarıda veri tabanına bağlanmıştık baglan fonk ile bilgileri alalım.
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter(SqlSorgusu, baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            baglanti.Close();
            return dt;
        }
    }
}
