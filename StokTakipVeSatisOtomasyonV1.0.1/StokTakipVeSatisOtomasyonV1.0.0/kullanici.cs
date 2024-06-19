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
using static StokTakipVeSatisOtomasyonV1._0._0.arayuz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class kullanici : Form
    {
        public kullanici()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int kullanici_id = 1;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void KullaniciGridiDoldur()
        {
            dgv_kullanici.DataSource = vt.Select(@"select k.kullanici_id,k.ad,k.soyAd,k.mail,k.sifre,k.kullaniciTur_id, t.turAd
            from tbl_kullanici k
            join tbl_kullaniciTur t on t.kullaniciTur_id = k.kullaniciTur_id ");
            dgv_kullanici.Columns["kullanici_id"].Visible = false;
            dgv_kullanici.Columns["kullaniciTur_id"].Visible = false;

        }
        private void kullanici_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            KullaniciGridiDoldur();
            cbx_kullaniciTur.ValueMember = "kullaniciTur_id";
            cbx_kullaniciTur.DisplayMember = "turAd";
            cbx_kullaniciTur.DataSource = vt.Select("select kullaniciTur_id,turAd,yetki_id from tbl_kullaniciTur");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_kullanici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_kullanici.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_kullanici.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_mail.Text = dgv_kullanici.SelectedRows[0].Cells["mail"].Value.ToString();
            cbx_kullaniciTur.SelectedValue = dgv_kullanici.SelectedRows[0].Cells["kullaniciTur_id"].Value;
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
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 15)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 2 || tx_soyAd.Text.Length > 15)
            {
                MessageBox.Show("SoyAd En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_soyAd.Text) || tx_soyAd.Text.Trim().Length != tx_soyAd.Text.Length)
            {
                MessageBox.Show("SoyAd Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (cbx_kullaniciTur.SelectedValue == null || cbx_kullaniciTur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Kullanıcı Türü boş bırakılamaz. Lütfen Kullanıcı Türü seçiniz!");
                return;
            }
            if (IsValidEmail(tx_mail.Text))
            {
                tx_mail.Text = tx_mail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            DataTable dt = vt.Select(@"select mail from tbl_kullanici
                                where mail='" + tx_mail.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Mail İle Önceden Kayıt Edilmiş Bir Kişi Bulunuyor...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifre.Text) || tx_sifre.Text.Trim().Length != tx_sifre.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            string md5liSifreYeni = MD5Sifrele(tx_sifre.Text);
            vt.Insert(@"insert into tbl_kullanici(ad,soyAd,mail,sifre,kullaniciTur_id)
                        values('" + tx_ad.Text + "','" + tx_soyAd.Text + "','" + tx_mail.Text + "','" + md5liSifreYeni+ "','" + cbx_kullaniciTur.SelectedValue + "')");
            KullaniciGridiDoldur();
            MessageBox.Show("Kullanici Eklendi");
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
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek kullanıcıyı Seçiniz...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Bilgilerini Silmek O Kullanıcıya Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            { 
                
                vt.UpdateDelete("DELETE t1 FROM tbl_satisDetay t1 INNER JOIN tbl_satis t2 ON t1.satis_id = t2.satis_id WHERE t2.kullanici_id =" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                vt.UpdateDelete("delete from tbl_satis where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_stokGirisDetay t1 INNER JOIN tbl_stokGiris t2 ON t1.stokGiris_id = t2.stokGiris_id WHERE t2.kullanici_id =" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                vt.UpdateDelete("delete from tbl_stokGiris where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                vt.UpdateDelete("delete from tbl_log where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                vt.UpdateDelete("delete from tbl_kullanici where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);


               KullaniciGridiDoldur();
                MessageBox.Show("Kullanici Silindi");
        
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_kullanici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı Seçiniz...");
                return;
            }
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 15)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (tx_soyAd.Text.Length < 2 || tx_soyAd.Text.Length > 15)
            {
                MessageBox.Show("SoyAd En Az 2 Karakter En Fazla 15 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_soyAd.Text) || tx_soyAd.Text.Trim().Length != tx_soyAd.Text.Length)
            {
                MessageBox.Show("SoyAd Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (cbx_kullaniciTur.SelectedValue == null || cbx_kullaniciTur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Kullanıcı Türü boş bırakılamaz. Lütfen Kullanıcı Türü seçiniz!");
                return;
            }
            if (IsValidEmail(tx_mail.Text))
            {
                tx_mail.Text = tx_mail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Geçersiz email adresi!");
                return;
            }
            DataTable dtt = vt.Select(@"select mail,kullanici_id,ad,soyAd from tbl_kullanici
                                where mail='"+tx_mail.Text+"' and kullanici_id <> " + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Mail İle Önceden Kayıt Edilmiş Bir Kişi Bulunuyor...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_sifre.Text) || tx_sifre.Text.Trim().Length != tx_sifre.Text.Length)
            {
                MessageBox.Show("Şifre Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Bilgilerini Güncellemek O Kullanıcıya Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {


                string md5liSifre = MD5Sifrele(tx_sifre.Text);
                DataTable dt = vt.Select(@"select kullanici_id,ad+' '+soyad adSoyad,kullaniciTur_id
                    from tbl_kullanici
            where kullanici_id='" + kullanici_id + "' and sifre='" + md5liSifre + "'");

                string md5liSifreYeni = MD5Sifrele(tx_sifre.Text);
                vt.UpdateDelete(@"update tbl_kullanici
                set 
	                ad='" + tx_ad.Text + @"',
	               	soyAd='" + tx_soyAd.Text + @"',
	                mail='" + tx_mail.Text + @"',
	                sifre='" + md5liSifreYeni + @"',
                    kullaniciTur_id='" + cbx_kullaniciTur.SelectedValue + @"'
	                where kullanici_id=" + dgv_kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
                KullaniciGridiDoldur();
                MessageBox.Show("Kullanıcı Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_soyAd.Text = "";
            tx_mail.Text = "";
            tx_sifre.Text = "";
            cbx_kullaniciTur.SelectedValue = 0;
            if (dgv_kullanici.SelectedRows.Count != 0)
                dgv_kullanici.SelectedRows[0].Selected = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tx_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void tx_soyAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        private void kopyalaEngelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void tx_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanici_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void tx_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
