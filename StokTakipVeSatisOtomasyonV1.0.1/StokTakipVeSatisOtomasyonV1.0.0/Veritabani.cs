using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTI
{
    class Veritabani
    {
        public Veritabani()
        {
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=db_stoktakipvesatis;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();


        public DataTable Select(string sorgu)
        {
            dt = new DataTable();
            if(baglanti.State !=ConnectionState.Open)
                baglanti.Open();

            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            adtr.SelectCommand = komut;
            adtr.Fill(dt);

            baglanti.Close();

            return dt;
        }

        public object Insert(string sorgu)
        {
            dt = new DataTable();
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            int kayitSay = komut.ExecuteNonQuery();
            baglanti.Close();

            return kayitSay;
        }

        public int UpdateDelete(string sorgu)
        {
            dt = new DataTable();
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            int kayitSay = komut.ExecuteNonQuery();
            baglanti.Close();

            return kayitSay;
        }

    }
}
