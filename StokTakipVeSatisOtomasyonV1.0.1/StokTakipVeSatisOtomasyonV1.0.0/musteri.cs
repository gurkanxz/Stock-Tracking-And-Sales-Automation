using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokTakipVeSatisOtomasyonV1._0._0.arayuz;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriGridiDoldur()
        {
            dgv_musteri.DataSource = vt.Select(@"select musteri_id, ad, soyAd, tel, ePosta, adres
                    from tbl_musteri");
            dgv_musteri.Columns["musteri_id"].Visible = false;

        }
        private void musteri_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            MusteriGridiDoldur();
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
        private void txt_sadece_harf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void kopyalaEngelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
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

        private void dgv_musteri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_musteri.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_soyAd.Text = dgv_musteri.SelectedRows[0].Cells["soyAd"].Value.ToString();
            tx_tel.Text = dgv_musteri.SelectedRows[0].Cells["tel"].Value.ToString();
            tx_mail.Text = dgv_musteri.SelectedRows[0].Cells["ePosta"].Value.ToString();
            tx_adres.Text = dgv_musteri.SelectedRows[0].Cells["adres"].Value.ToString();
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
                MessageBox.Show("SoyAdı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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
            DataTable dt = vt.Select(@"select ePosta, tel from tbl_musteri
                            where ePosta='" + tx_mail.Text + "' OR tel='" + tx_tel.Text + "'");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ePosta"].ToString() == tx_mail.Text)
                {
                    MessageBox.Show("Bu e-posta adresi ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }

                return;
            }
            if (tx_tel.Text.Length !=11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (tx_adres.Text.Length < 2 || tx_adres.Text.Length > 150)
            {
                MessageBox.Show("Adres En Az 2 Karakter En Fazla 150 Karakter olabilir...");
                return;
            }
            vt.Insert(@"insert into tbl_musteri(ad,soyAd,tel,ePosta,adres)
                        values('" + tx_ad.Text + "','" + tx_soyAd.Text + "','" + tx_tel.Text + "','" + tx_mail.Text + "','" + tx_adres.Text + "')");
            MusteriGridiDoldur();
            MessageBox.Show("Müşteri Türü Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Müşteri Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Müşteri Bilgilerini Silmek O Müşteriye Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                vt.UpdateDelete("DELETE t1 FROM tbl_satisDetay t1 INNER JOIN tbl_satis t2 ON t1.satis_id = t2.satis_id  WHERE t2.musteri_id =" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_satis t1  WHERE t1.musteri_id =" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);
                vt.UpdateDelete("delete from tbl_musteri where musteri_id=" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);

                MusteriGridiDoldur();
                MessageBox.Show("Müşteri Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Müşteri Seçiniz...");

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
                MessageBox.Show("SoyAdı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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
            DataTable dt = vt.Select(@"select musteri_id, ePosta, tel from tbl_musteri
                            where (ePosta='" + tx_mail.Text + "' OR tel='" + tx_tel.Text + "') AND musteri_id <> " + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ePosta"].ToString() == tx_mail.Text)
                {
                    MessageBox.Show("Bu e-posta adresi ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }

                return;
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası başında'0' dahil 11 Karakter olmalı...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_tel.Text) || tx_tel.Text.Trim().Length != tx_tel.Text.Length)
            {
                MessageBox.Show("Telefon Numarası Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (tx_adres.Text.Length < 2 || tx_adres.Text.Length > 150)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 150 Karakter olabilir...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Müşteri Bilgilerini Güncellemek O Müşteriye Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_musteri
                set 
	                ad='" + tx_ad.Text + @"',
                    soyAd='" + tx_ad.Text + @"',
                    tel='" + tx_tel.Text + @"',
                    ePosta='" + tx_mail.Text + @"',
                    adres='" + tx_adres.Text + @"'
	                where musteri_id=" + dgv_musteri.SelectedRows[0].Cells["musteri_id"].Value);
                MusteriGridiDoldur();
                MessageBox.Show("Müşteri Güncellendi");
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
            tx_tel.Text = "";
            tx_mail.Text = "";
            tx_adres.Text = "";
            if (dgv_musteri.SelectedRows.Count != 0)
                dgv_musteri.SelectedRows[0].Selected = false;
        }

        private void musteri_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
