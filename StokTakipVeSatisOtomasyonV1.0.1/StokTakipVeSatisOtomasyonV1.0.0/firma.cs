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
    public partial class firma : Form
    {
        public firma()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
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
        private void FirmaGridiDoldur()
        {
            dgv_firma.DataSource = vt.Select(@"select firma_id, firmaAd, tel, ePosta, adres
            from tbl_firma");
            dgv_firma.Columns["firma_id"].Visible = false;


        }
        private void firma_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            FirmaGridiDoldur();
        }
        private void harf_KeyPress(object sender, KeyPressEventArgs e)
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

            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 25 Karakter olabilir...");
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
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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

            DataTable dt = vt.Select(@"select firmaAd, ePosta, tel from tbl_firma
                            where firmaAd='"+ tx_ad.Text +"' OR ePosta='" + tx_mail.Text + "' OR tel='" + tx_tel.Text + "' ");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["firmaAd"].ToString() == tx_ad.Text)
                {
                    MessageBox.Show("Bu Firma Adı ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["ePosta"].ToString() == tx_mail.Text)
                {
                    MessageBox.Show("Bu e-posta adresi ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }

                return;
            }
            if (tx_adres.Text.Length < 2 || tx_adres.Text.Length > 150)
            {
                MessageBox.Show("Adres En Az 2 Karakter En Fazla 150 Karakter olabilir...");
                return;
            }
            vt.Insert(@"insert into tbl_firma(firmaAd, tel, ePosta, adres)
                        values('" + tx_ad.Text + "','" + tx_tel.Text + "','" + tx_mail.Text + "','" + tx_adres.Text + "')");
            FirmaGridiDoldur();
            MessageBox.Show("Firma Eklendi");

        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_firma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Firma Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Firma Bilgilerini Silmek Firmaya Ait Kayıtları Silebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

            
                vt.UpdateDelete("delete from tbl_firma where firma_id=" + dgv_firma.SelectedRows[0].Cells["firma_id"].Value);

                FirmaGridiDoldur();
                MessageBox.Show("Firma Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_firma.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Firma Seçiniz...");

                return;
            }
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 25 Karakter olabilir...");
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
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ad Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
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
            DataTable dt = vt.Select(@"select firmaAd, ePosta, tel from tbl_firma
                            where (firmaAd='" + tx_ad.Text + "' OR ePosta='" + tx_mail.Text + "' OR tel='" + tx_tel.Text + "') AND firma_id <> " + dgv_firma.SelectedRows[0].Cells["firma_id"].Value);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["firmaAd"].ToString() == tx_ad.Text)
                {
                    MessageBox.Show("Bu Firma Adı ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["ePosta"].ToString() == tx_mail.Text)
                {
                    MessageBox.Show("Bu e-posta adresi ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }
                else if (dt.Rows[0]["tel"].ToString() == tx_tel.Text)
                {
                    MessageBox.Show("Bu telefon numarası ile önceden kayıt edilmiş bir müşteri bulunuyor!");
                }

                return;
            }
            if (tx_adres.Text.Length < 2 || tx_adres.Text.Length > 150)
            {
                MessageBox.Show("Adres En Az 2 Karakter En Fazla 150 Karakter olabilir...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Firma Bilgilerini Güncellemek O Firmaya Ait Stok Giriş Kayıtlarını da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_firma
                set 
	                firmaAd='" + tx_ad.Text + @"',
                    tel='" + tx_tel.Text + @"',
                    ePosta='" + tx_mail.Text + @"',
                    adres='" + tx_adres.Text + @"'
	                where firma_id=" + dgv_firma.SelectedRows[0].Cells["firma_id"].Value);
                FirmaGridiDoldur();
                MessageBox.Show("Firma Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_tel.Text = "";
            tx_mail.Text = "";
            tx_adres.Text = "";
            if (dgv_firma.SelectedRows.Count != 0)
                dgv_firma.SelectedRows[0].Selected = false;
        }

        private void dgv_firma_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_firma.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_firma.SelectedRows[0].Cells["firmaAd"].Value.ToString();
            tx_tel.Text = dgv_firma.SelectedRows[0].Cells["tel"].Value.ToString();
            tx_mail.Text = dgv_firma.SelectedRows[0].Cells["ePosta"].Value.ToString();
            tx_adres.Text = dgv_firma.SelectedRows[0].Cells["adres"].Value.ToString();
        }

        private void firma_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
