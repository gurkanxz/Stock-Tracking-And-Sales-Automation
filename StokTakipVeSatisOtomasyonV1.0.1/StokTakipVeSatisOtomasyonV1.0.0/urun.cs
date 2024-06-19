using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static StokTakipVeSatisOtomasyonV1._0._0.arayuz;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UrunGridiDoldur()
        {
            dgv_urun.DataSource = vt.Select(@"select u.urun_id, u.urunAd, u.birimFiyat, u.kod, u.resimYolu, kt.kategori_id, kt.kategoriAd
                    from tbl_urun u
					join tbl_urunKategori kt on kt.kategori_id=u.kategori_id");
            dgv_urun.Columns["urun_id"].Visible = false;
            dgv_urun.Columns["kategori_id"].Visible = false;

        }
        private void urun_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            UrunGridiDoldur();
            cbx_uruntur.ValueMember = "kategori_id";
            cbx_uruntur.DisplayMember = "kategoriAd";
            cbx_uruntur.DataSource = vt.Select(@"select kategori_id, kategoriAd
                    from tbl_urunKategori ");
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

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            tx_resim.Text = openFileDialog1.FileName;
        }

        private void dgv_urun_SelectionChanged(object sender, EventArgs e)

        {
            if (dgv_urun.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_urun.SelectedRows[0].Cells["urunAd"].Value.ToString();
            tx_fiyat.Text = dgv_urun.SelectedRows[0].Cells["birimFiyat"].Value.ToString();
            tx_kod.Text = dgv_urun.SelectedRows[0].Cells["kod"].Value.ToString();
            tx_resim.Text = dgv_urun.SelectedRows[0].Cells["resimYolu"].Value.ToString();
            cbx_uruntur.SelectedValue = dgv_urun.SelectedRows[0].Cells["kategori_id"].Value.ToString();
            pictureBox1.ImageLocation = dgv_urun.SelectedRows[0].Cells["resimYolu"].Value.ToString();
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
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 20)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 20 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            string fiyat = tx_fiyat.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Fiyatın ilk rakamı 0 olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_fiyat.Text) || tx_fiyat.Text.Trim().Length != tx_fiyat.Text.Length)
            {
                MessageBox.Show("Fiyat Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_kod.Text) || tx_kod.Text.Trim().Length != tx_kod.Text.Length)
            {
                MessageBox.Show("Kod Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (cbx_uruntur.SelectedValue == null || cbx_uruntur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün Türü boş bırakılamaz. Lütfen Ürün Türü seçiniz!");
                return;
            }
            DataTable dt = vt.Select(@"select kod from tbl_urun
                                where kod='" + tx_kod.Text + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Kod İle Önceden Kayıt Edilmiş Bir Ürün Bulunuyor...");
                return;
            }
            vt.Insert(@"insert into tbl_urun(urunAd,birimFiyat,kod,resimYolu,kategori_id)
                        values('" + tx_ad.Text + "','" + tx_fiyat.Text + "','" + tx_kod.Text + "','" + tx_resim.Text + "','" + cbx_uruntur.SelectedValue + "')");
            UrunGridiDoldur();
            MessageBox.Show("Ürün Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_urun.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Ürünü Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Ürün Bilgilerini Silmek Ürüne Ait Kayıtları ve Kayıt Detaylarını Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {

                vt.UpdateDelete("delete from tbl_stok where urun_id=" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                vt.UpdateDelete("delete from tbl_zayiUrun where urun_id=" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_satisDetay t1 INNER JOIN tbl_satis t2 ON t1.satis_id = t2.satis_id WHERE t1.urun_id =" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                vt.UpdateDelete("delete from tbl_satis WHERE satis_id = (SELECT MAX(satis_id) FROM tbl_satis)");
                vt.UpdateDelete("DELETE t1 FROM tbl_stokGirisDetay t1 INNER JOIN tbl_stokGiris t2 ON t1.stokGiris_id = t2.stokGiris_id WHERE t1.urun_id =" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                vt.UpdateDelete("delete from tbl_stokGiris WHERE stokGiris_id = (SELECT MAX(stokGiris_id) FROM tbl_stokGiris)");
                vt.UpdateDelete("delete from tbl_urun where urun_id=" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                UrunGridiDoldur();
                MessageBox.Show("Ürün Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_urun.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Ürünü Seçiniz...");

                return;
            }
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 20)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 20 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            string fiyat = tx_fiyat.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Fiyatın ilk rakamı 0 olamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_fiyat.Text) || tx_fiyat.Text.Trim().Length != tx_fiyat.Text.Length)
            {
                MessageBox.Show("Fiyat Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_kod.Text) || tx_kod.Text.Trim().Length != tx_kod.Text.Length)
            {
                MessageBox.Show("Kod Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            if (cbx_uruntur.SelectedValue == null || cbx_uruntur.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün Türü boş bırakılamaz. Lütfen Ürün Türü seçiniz!");
                return;
            }
            DataTable dt = vt.Select(@"select kod, urun_id from tbl_urun
                                where kod='" + tx_kod.Text + "' and urun_id <>  " + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Kod İle Önceden Kayıt Edilmiş Bir Ürün Bulunuyor...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Ürün Bilgilerini Güncellemek Ürüne Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_urun
                set 
	                urunAd='" + tx_ad.Text + @"',
                    birimFiyat='" + tx_fiyat.Text + @"',
                    kod='" + tx_kod.Text + @"',
                    kategori_id='" + cbx_uruntur.SelectedValue + @"',
                    resimYolu='" + tx_resim.Text + @"'
	                where urun_id=" + dgv_urun.SelectedRows[0].Cells["urun_id"].Value);
                UrunGridiDoldur();
                MessageBox.Show("Ürün Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            tx_fiyat.Text = "";
            tx_kod.Text = "";
            tx_resim.Text = "";
            cbx_uruntur.SelectedValue = 0;
            if (dgv_urun.SelectedRows.Count != 0)
                dgv_urun.SelectedRows[0].Selected = false;
        }

        private void urun_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
