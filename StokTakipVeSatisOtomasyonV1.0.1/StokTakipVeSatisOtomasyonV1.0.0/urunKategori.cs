using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokTakipVeSatisOtomasyonV1._0._0.arayuz;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class urunKategori : Form
    {
        public urunKategori()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void urunKategori_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            UrunTuruGridiDoldur();
        }
        private void UrunTuruGridiDoldur()
        {
            dgv_tur.DataSource = vt.Select(@"select kategoriAd, kategori_id
                    from tbl_urunKategori ");
            dgv_tur.Columns["kategori_id"].Visible = false;

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Kategori Adı En Az 2 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            DataTable dt = vt.Select(@"select kategoriAd from tbl_urunKategori
                            where kategoriAd = '"+ tx_ad.Text +"' ");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Kategori Adı İle Önceden Kayıt Edilmiş Bir Kategori Türü Bulunuyor...");
                return;
            }
            vt.Insert(@"insert into tbl_urunKategori(kategoriAd)
                        values('" + tx_ad.Text + "')");
            UrunTuruGridiDoldur();
            MessageBox.Show("Ürün Türü Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Ürün Kategorisini Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Ürün Kategorisi Bilgilerini Silmek Ürün Kategorisine Ait Kayıtları ve Kayıt Detaylarını Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("DELETE t1 FROM tbl_stok t1 INNER JOIN tbl_urun t2 ON t1.urun_id = t2.urun_id WHERE t2.kategori_id =" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_zayiUrun t1 INNER JOIN tbl_urun t2 ON t1.urun_id = t2.urun_id WHERE t2.kategori_id =" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_satisDetay t1 INNER JOIN tbl_urun t2 ON t1.urun_id = t2.urun_id WHERE t2.kategori_id =" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_stokGirisDetay t1 INNER JOIN tbl_urun t2 ON t1.urun_id = t2.urun_id WHERE t2.kategori_id =" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                vt.UpdateDelete("delete from tbl_urun where kategori_id=" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                vt.UpdateDelete("delete from tbl_urunKategori where kategori_id=" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                UrunTuruGridiDoldur();
                MessageBox.Show("Ürün Kategorisi Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Ürün Kategorisi Seçiniz...");

                return;
            }
            if (tx_ad.Text.Length < 2 || tx_ad.Text.Length > 25)
            {
                MessageBox.Show("Kategori Adı En Az 2 Karakter En Fazla 25 Karakter olabilir...");
                return;
            }
            if (string.IsNullOrWhiteSpace(tx_ad.Text) || tx_ad.Text.Trim().Length != tx_ad.Text.Length)
            {
                MessageBox.Show("Kategori Adı Boş Bırakılamaz ve İçinde ya da Sonunda Boşluk Bulunamaz...");
                return;
            }
            DataTable dt = vt.Select(@"select kategoriAd, kategori_id from tbl_urunKategori
                            where kategoriAd = '" + tx_ad.Text + "' and kategori_id <> "+ dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Kategori Adı İle Önceden Kayıt Edilmiş Bir Kategori Türü Bulunuyor...");
                return;
            }
            DialogResult secenek = MessageBox.Show("Bu Ürün Türü Bilgilerini Güncellemek O Ürün Türüne Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_urunKategori
                set 
	                kategoriAd='" + tx_ad.Text + @"'
	                where kategori_id=" + dgv_tur.SelectedRows[0].Cells["kategori_id"].Value);
                UrunTuruGridiDoldur();
                MessageBox.Show("Ürün Kategorisi Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_ad.Text = "";
            if (dgv_tur.SelectedRows.Count != 0)
                dgv_tur.SelectedRows[0].Selected = false;
        }

        private void dgv_tur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                return;
            }
            tx_ad.Text = dgv_tur.SelectedRows[0].Cells["kategoriAd"].Value.ToString();
        }

        private void urunKategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.AddForm(this);
        }
    }
}
