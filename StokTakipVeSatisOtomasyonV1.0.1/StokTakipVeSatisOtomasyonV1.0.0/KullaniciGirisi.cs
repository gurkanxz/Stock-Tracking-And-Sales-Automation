using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Visible = true;
        }
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            label6.Visible = true;
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void KullaniciGirisi_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void KullaniciGirisi_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = false;

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
            label5.Visible = false;
            label6.Visible = false;
        }

        private void KullaniciGirisi_MouseUp(object sender, MouseEventArgs e)
        {
            move = false; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_kullaniciAdi.Text.Length > 35)
            {
                MessageBox.Show("Kullanici Mail 35 karakterden büyük olmamalıdır.");
                return;
            }
            if (tx_sifre.Text == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz. Lütfen şifrenizi giriniz!");
                return;
            }
            if (IsValidEmail(tx_kullaniciAdi.Text))
            {
                tx_kullaniciAdi.Text = tx_kullaniciAdi.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            string md5liSifre = MD5Sifrele(tx_sifre.Text);
            DataTable dt = vt.Select(@"select k.kullanici_id,k.mail,k.ad+' '+k.soyAd adSoyad, k.kullaniciTur_id, kt.turAd,kt.yetki_id,ye.yetki
                    from tbl_kullanici k
					join tbl_kullaniciTur kt on kt.kullaniciTur_id=k.kullaniciTur_id
                    join tbl_yetki ye on ye.yetki_id=kt.yetki_id
            where mail='" + tx_kullaniciAdi.Text + "' and sifre='" + md5liSifre + "'");
            arayuz p = new arayuz();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı !!!");
                return;
            }
            else if (dt.Rows.Count != 0)
            {
                p.lbl_ad.Text = "Kullanıcı: " + dt.Rows[0]["adSoyad"].ToString();
                p.lbl_tur.Text = "Kullanıcı Türü: " + dt.Rows[0]["turAd"].ToString();
            }
            p.kullanici_id = Convert.ToInt32(dt.Rows[0]["kullanici_id"]);
            string bilgisayarIsmi = System.Environment.MachineName;
            DateTime now = DateTime.Now;
            string tarih = now.ToString("yyyy-MM-dd");
            string saat = now.ToString("HH:mm:ss");
            vt.Insert(@"insert into tbl_log(pcİsmi, girisTarih, girisSaat, kullanici_id)
            values('" + bilgisayarIsmi + "','" + tarih + "','" + saat + "','" + p.kullanici_id + "')");
            MessageBox.Show("Kullanici Girişi Başarılı.\nHoş Geldin :" + dt.Rows[0]["adSoyad"].ToString());
            int yetki_id = (int)dt.Rows[0]["yetki_id"];
            p.yetki_id = yetki_id;
            this.Hide();
            p.Show();
            

        }
        public string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
