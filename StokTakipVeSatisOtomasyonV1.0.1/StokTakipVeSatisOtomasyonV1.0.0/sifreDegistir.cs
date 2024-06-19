using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class sifreDegistir : Form
    {
        public sifreDegistir()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int kullanici_id = ' ';
        private void sifreDegistir_Load(object sender, EventArgs e)
        {

        }

        private void tx_sifreYeniTekrar_TextChanged(object sender, EventArgs e)
        {
            if (tx_sifreYeni.Text != tx_sifreYeniTekrar.Text)
            {
                lbl_mesaj.Text = "Şifreler uyuşmuyor !!!";
                lbl_mesaj.Visible = true;

            }
            else
                lbl_mesaj.Visible = false;
        }
        private void btn_degistir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tx_sifre.Text) || tx_sifre.Text.Trim().Length != tx_sifre.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifreYeni.Text) || tx_sifreYeni.Text.Trim().Length != tx_sifreYeni.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifreYeniTekrar.Text) || tx_sifreYeniTekrar.Text.Trim().Length != tx_sifreYeni.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (tx_sifreYeni.Text != tx_sifreYeniTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor !!!");
                return;
            }
            if (tx_sifreYeni.Text.Length < 6)
            {
                MessageBox.Show("Şifre en az 6 karakter olmalıdır !!!");
                return;
            }
            string md5liSifre = MD5Sifrele(tx_sifre.Text);
            DataTable dt = vt.Select(@"select kullanici_id,ad+' '+soyad adSoyad,kullaniciTur_id
                    from tbl_kullanici
            where kullanici_id='" + kullanici_id + "' and sifre='" + md5liSifre + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Şifre hatalı !!!");
                return;
            }

            string md5liSifreYeni = MD5Sifrele(tx_sifreYeni.Text);
            vt.UpdateDelete("update tbl_kullanici set sifre='" + md5liSifreYeni + "' where kullanici_id=" + kullanici_id);
            MessageBox.Show("Şifre güncellendi. Form Kapatılıyor...");
            this.Close();
        }
        public string MD5Sifrele(string sifrelenecekMetin)
        {

          
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
           
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            
            dizi = md5.ComputeHash(dizi);
           
            StringBuilder sb = new StringBuilder();
            

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

           
            return sb.ToString();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void arayuz_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void arayuz_MouseMove(object sender, MouseEventArgs e)
        {

            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void arayuz_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tx_sifre.PasswordChar == '*')
            {
                button2.BringToFront();
                tx_sifre.PasswordChar = tx_sifreYeni.PasswordChar = tx_sifreYeniTekrar.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tx_sifre.PasswordChar == '\0')
            {
                button1.BringToFront();
                tx_sifre.PasswordChar = tx_sifreYeni.PasswordChar = tx_sifreYeniTekrar.PasswordChar = '*';
            }
        }
    }
}
