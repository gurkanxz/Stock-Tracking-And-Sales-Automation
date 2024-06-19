using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StokTakipVeSatisOtomasyonV1._0._0.arayuz;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class satis : Form
    {
        public satis()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int kullanici_id = 1;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void SatisGridiDoldur()
        {
            FormManager.AddForm(this);
            dgv_satis.DataSource = vt.Select(@"select s.satis_id,u.urunAd, m.ad + ' ' + m.soyAd AdSoyAd, s.satisTarih,sd.satisFiyat,sd.adet,s.toplamTutar ,sd.detay_id,s.musteri_id, s.kullanici_id,sd.urun_id, k.ad KullanıcıAdı
            from tbl_satis s
            join tbl_satisDetay sd on sd.satis_id=s.satis_id
            join tbl_musteri m on m.musteri_id=s.musteri_id
            join tbl_kullanici k on k.kullanici_id=s.kullanici_id
            join tbl_urun u on u.urun_id=sd.urun_id");
            dgv_satis.Columns["satis_id"].Visible = false;
            dgv_satis.Columns["urun_id"].Visible = false;
            dgv_satis.Columns["musteri_id"].Visible = false;
            dgv_satis.Columns["kullanici_id"].Visible = false;
            dgv_satis.Columns["detay_id"].Visible = false;
        }

        private void UpdateStokMiktariGrid(int urunId)
        {
            DataTable dt = vt.Select(@"select * from tbl_stok where urun_id='" + urunId + "'");
            dgv_stokMiktari.DataSource = dt;
            dgv_stokMiktari.Columns["stok_id"].Visible = false;
            dgv_stokMiktari.Columns["urun_id"].Visible = false;
        }
        private void cbx_urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cbx_urun'un SelectedIndexChanged olayı tetiklendiğinde, ilgili ürün için stok bilgilerini güncelle
            if (cbx_urun.SelectedValue != null)
            {
                int selectedUrunId = (int)cbx_urun.SelectedValue;
                UpdateStokMiktariGrid(selectedUrunId);
            }
        }
        private void satis_Load(object sender, EventArgs e)
        {
            SatisGridiDoldur();
            cbx_urun.ValueMember = "urun_id";
            cbx_urun.DisplayMember = "urunKod";
            cbx_urun.DataSource = vt.Select("SELECT s.urun_id, CAST(u.urunAd AS nvarchar(MAX)) + '-' + CAST(u.kod AS nvarchar(MAX)) AS urunKod FROM tbl_urun u join tbl_stok s on s.urun_id=u.urun_id;");
            cbx_musteri.ValueMember = "musteri_id";
            cbx_musteri.DisplayMember = "AdSoyAd";
            cbx_musteri.DataSource = vt.Select("select musteri_id, ad + '-' + soyAd AdSoyAd from tbl_musteri");
            cbx_urun.SelectedIndexChanged += cbx_urun_SelectedIndexChanged;
            if (cbx_urun.SelectedValue != null)
            {
                int selectedUrunId = (int)cbx_urun.SelectedValue;
                UpdateStokMiktariGrid(selectedUrunId);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string fiyat = tx_fiyat.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Fiyat 0 olamaz!");
                return;
            }
            string fiyat2 = tx_toplamTutar.Text.Trim();

            if (fiyat2.Length > 0 && fiyat2[0] == '0')
            {
                MessageBox.Show("Toplam Tutar 0 olamaz!");
                return;
            }
            string fiyat3 = tx_adet.Text.Trim();

            if (fiyat3.Length > 0 && fiyat3[0] == '0')
            {
                MessageBox.Show("Stok Adeti 0 olamaz!");
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz!");
                return;
            }
            if (tx_fiyat.Text == "")
            {
                MessageBox.Show("Satış Fiyatı boş bırakılamaz!");
                return;
            }
            if (tx_toplamTutar.Text == "")
            {
                MessageBox.Show("Toplam Tutar boş bırakılamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen ürün seçiniz!");
                return;
            }
            if (cbx_musteri.SelectedValue == null || cbx_musteri.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Müşteri boş bırakılamaz. Lütfen Müşteri seçiniz!");
                return;
            }

            if (dtp_satisTarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Satış Tarihi Boş Bırakılamaz. Lütfen Satış Tarihini seçiniz!");
                return;
            }
            DataTable dt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok,sa.adet,sa.detay_id FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  join tbl_satisDetay sa on sa.urun_id=s.urun_id
                  where s.urun_id= '" + cbx_urun.SelectedValue + "'");
            int stokMiktari, girilenAdet,kritikStok,kalan, urunID;
            int.TryParse(dt.Rows[0]["kritikStok"].ToString(), out kritikStok);
            int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
            int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urunID);
            int.TryParse(tx_adet.Text, out girilenAdet);
            if (stokMiktari<girilenAdet)
            {
                MessageBox.Show("Satış Adeti Stok Miktarından Fazla Olamaz...");
                return;
            }
            kalan = stokMiktari - girilenAdet;
            if (kalan <= kritikStok)
            {
                MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
            }
            vt.UpdateDelete("update tbl_stok set stokMiktari= '" + kalan + "' where urun_id='" + cbx_urun.SelectedValue + "'");
            MessageBox.Show("Stok Bilgisi Girilen Adet Doğrultusunda Azaltıldı.");
            vt.Insert(@"insert into tbl_satis(satisTarih,toplamTutar,kullanici_id,musteri_id)
                        values('" + dtp_satisTarih.Value.ToString("yyyy-MM-dd") + "','" + tx_toplamTutar.Text.ToString() + "','" + kullanici_id + "','" + cbx_musteri.SelectedValue + "')");
            vt.Insert(@"insert into tbl_satisDetay(satisFiyat,adet, urun_id, satis_id)
                        values('" + tx_fiyat.Text + "','" + tx_adet.Text + "','" + cbx_urun.SelectedValue + "',(SELECT MAX(satis_id) FROM tbl_satis))");
            UpdateStokMiktariGrid(urunID);
            SatisGridiDoldur();
            MessageBox.Show("Satış Bilgisi Eklendi");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Satış Bilgisini Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Satış Bilgilerini Silmek İstediğinize Emin Misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                DataTable dt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok,sa.adet,sa.detay_id FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  join tbl_satisDetay sa on sa.urun_id=s.urun_id
                  where s.urun_id= '" + dgv_satis.SelectedRows[0].Cells["urun_id"].Value + "' and sa.detay_id= '" + dgv_satis.SelectedRows[0].Cells["detay_id"].Value + "'");
                int satisAdeti,stokMiktari,urunID;
                int.TryParse(dt.Rows[0]["adet"].ToString(), out satisAdeti);
                int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
                int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urunID);
                stokMiktari = stokMiktari + satisAdeti;
                DialogResult secenek2 = MessageBox.Show("Bu Satış Adetini Stok Bilgisine Geri Eklemek İster misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek2 == DialogResult.Yes)
                    {
                    vt.UpdateDelete("update tbl_stok set stokMiktari= '" + stokMiktari + "' where urun_id=" + dgv_satis.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete("delete from tbl_satisDetay where detay_id=" + dgv_satis.SelectedRows[0].Cells["detay_id"].Value);
                    vt.UpdateDelete("delete from tbl_satis where satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);
                    UpdateStokMiktariGrid(urunID);
                    SatisGridiDoldur();
                    MessageBox.Show("Satış Adeti Geri Stok Miktarına Eklendi ve Satış Bilgisi Silindi");

                }
                    else if (secenek2 == DialogResult.No)
                    {
                        vt.UpdateDelete("delete from tbl_satisDetay where detay_id=" + dgv_satis.SelectedRows[0].Cells["detay_id"].Value);
                        vt.UpdateDelete("delete from tbl_satis where satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);
                        SatisGridiDoldur();
                        MessageBox.Show("Satış Bilgisi Silindi");
                    }

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Satış Bilgisini Seçiniz...");

                return;
            }

            string fiyat = tx_fiyat.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Fiyat 0 olamaz!");
                return;
            }
            string fiyat2 = tx_toplamTutar.Text.Trim();

            if (fiyat2.Length > 0 && fiyat2[0] == '0')
            {
                MessageBox.Show("Toplam Tutar 0 olamaz!");
                return;
            }
            string fiyat3 = tx_adet.Text.Trim();

            if (fiyat3.Length > 0 && fiyat3[0] == '0')
            {
                MessageBox.Show("Stok Adeti 0 olamaz!");
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz!");
                return;
            }
            if (tx_fiyat.Text == "")
            {
                MessageBox.Show("Satış Fiyatı boş bırakılamaz!");
                return;
            }
            if (tx_toplamTutar.Text == "")
            {
                MessageBox.Show("Toplam Tutar boş bırakılamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen ürün seçiniz!");
                return;
            }
            if (cbx_musteri.SelectedValue == null || cbx_musteri.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Müşteri boş bırakılamaz. Lütfen Müşteri seçiniz!");
                return;
            }
            if (dtp_satisTarih.Value == DateTime.MinValue)
            {
                MessageBox.Show("Satış Tarihi Boş Bırakılamaz. Lütfen Satış Tarihini seçiniz!");
                return;
            }

            DataTable dt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok,sa.adet,sa.detay_id FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  join tbl_satisDetay sa on sa.urun_id=s.urun_id
                  where s.urun_id= '" + dgv_satis.SelectedRows[0].Cells["urun_id"].Value + "' and sa.detay_id= '" + dgv_satis.SelectedRows[0].Cells["detay_id"].Value + "'");
            int stokMiktari, girilenAdet,ilkAdet,kalan,kritikStok,kalan2,urunID;
            int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
            int.TryParse(dt.Rows[0]["kritikStok"].ToString(), out kritikStok);
            int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urunID);
            int.TryParse(tx_adet.Text, out girilenAdet);
            int.TryParse(dgv_satis.SelectedRows[0].Cells["adet"].Value.ToString(), out ilkAdet);
            //if (stokMiktari < girilenAdet)
            //{
            //    MessageBox.Show("Satış Adeti Stok Miktarından Fazla Olamaz...");
            //    return;
            //}
            kalan2 = stokMiktari - girilenAdet;
            if (kalan2 <= kritikStok)
            {
                MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
            }
            DialogResult secenek = MessageBox.Show("Bu Satış Bilgilerini Güncellemek Satışa Ait Kayıtları da Güncelleyebilir Ve Ya Birim Olarak Üstüne Yazacaktır. Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                if (girilenAdet > ilkAdet)
                {
                    kalan = girilenAdet - ilkAdet;
                    stokMiktari = stokMiktari - kalan;
                    if(stokMiktari<0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Yapılamaz...");
                        return;
                    }
                    else
                    {
                    vt.UpdateDelete("update tbl_stok set stokMiktari= '" + stokMiktari + "' where urun_id=" + dgv_satis.SelectedRows[0].Cells["urun_id"].Value);
                    MessageBox.Show("Stok Bilgisi Girilen Adet Doğrultusunda Azaltıldı.");
                    }



                }
                else if (girilenAdet < ilkAdet)
                {
                    kalan = ilkAdet - girilenAdet;
                    stokMiktari = stokMiktari + kalan;
                    vt.UpdateDelete("update tbl_stok set stokMiktari= '" + stokMiktari + "' where urun_id=" + dgv_satis.SelectedRows[0].Cells["urun_id"].Value);
                    MessageBox.Show("Stok Bilgisi Girilen Adet Doğrultusunda Arttırıldı.");


                }
                vt.UpdateDelete(@"update tbl_satis
                set 
	                satisTarih='" + dtp_satisTarih.Value.ToString("yyyy-MM-dd") + @"',
                    toplamTutar='" + tx_toplamTutar.Text + @"',
                    kullanici_id='" + kullanici_id+ @"',
                    musteri_id='" + cbx_musteri.SelectedValue + @"'
	                where satis_id=" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value);
                vt.UpdateDelete(@"update tbl_satisDetay
                set 
	                satisFiyat='" +tx_fiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    satis_id='" + dgv_satis.SelectedRows[0].Cells["satis_id"].Value + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"'
	                where detay_id=" + dgv_satis.SelectedRows[0].Cells["detay_id"].Value);
                UpdateStokMiktariGrid(urunID);
                SatisGridiDoldur();
                MessageBox.Show("Satış Bilgisi Güncellendi");

            }
            else if (secenek == DialogResult.No)
            {
                return;
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_adet.Text = "";
            tx_fiyat.Text = "";
            tx_toplamTutar.Text = "";
            cbx_urun.SelectedValue = 0;
            cbx_musteri.SelectedValue = 0;
            if (dgv_satis.SelectedRows.Count != 0)
                dgv_satis.SelectedRows[0].Selected = false;
        }

        private void tx_yapistirEngel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tx_fiyat_TextChanged(object sender, EventArgs e)
        {
            int satisFiyat, adet, toplamTutar;
            int.TryParse(tx_adet.Text, out adet);
            int.TryParse(tx_fiyat.Text, out satisFiyat);
            toplamTutar = adet * satisFiyat;
            tx_toplamTutar.Text = toplamTutar.ToString();
        }

        private void tx_adet_TextChanged(object sender, EventArgs e)
        {
            int satisFiyat, adet, toplamTutar;
            int.TryParse(tx_adet.Text, out adet);
            int.TryParse(tx_fiyat.Text, out satisFiyat);
            toplamTutar = adet * satisFiyat;
            tx_toplamTutar.Text = toplamTutar.ToString();
        }

        private void dgv_satis_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_satis.SelectedRows.Count == 0)
            {
                return;
            }
            tx_adet.Text = dgv_satis.SelectedRows[0].Cells["adet"].Value.ToString();
            tx_fiyat.Text = dgv_satis.SelectedRows[0].Cells["satisFiyat"].Value.ToString();
            tx_toplamTutar.Text = dgv_satis.SelectedRows[0].Cells["toplamTutar"].Value.ToString();
            cbx_urun.SelectedValue = dgv_satis.SelectedRows[0].Cells["urun_id"].Value.ToString();
            cbx_musteri.SelectedValue = dgv_satis.SelectedRows[0].Cells["musteri_id"].Value.ToString();
        }

        private void satis_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
