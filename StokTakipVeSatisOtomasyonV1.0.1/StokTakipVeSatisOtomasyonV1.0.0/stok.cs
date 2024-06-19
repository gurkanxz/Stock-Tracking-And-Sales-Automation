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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        public int kullanici_id = 1;
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

        private void StokGridiDoldur()
        {
            dgv_stok.DataSource = vt.Select(@"select s.stok_id, s.stokMiktari, s.kritikStok, u.urun_id, u.urunAd, sgd.stokGirisDetay_id, sgd.alisFiyat, sgd.adet, sgd.sonKullanmaTarih, sg.stokGiris_id, sg.tarih GirisTarih, sg.saat GirisSaat, sg.toplamMaliyet, sg.firma_id, f.firmaAd, sg.kullanici_id, k.ad KullanıcıAdı
            from tbl_stok s
            inner join tbl_urun u on u.urun_id=s.urun_id
            inner join tbl_stokGirisDetay sgd on u.urun_id=sgd.urun_id
            inner join tbl_stokGiris sg on sg.stokGiris_id=sgd.stokGiris_id
            inner join tbl_kullanici k on k.kullanici_id=sg.kullanici_id
            inner join tbl_firma f on f.firma_id=sg.firma_id");
            dgv_stok.Columns["stok_id"].Visible = false;
            dgv_stok.Columns["urun_id"].Visible = false;
            dgv_stok.Columns["stokGirisDetay_id"].Visible = false;
            dgv_stok.Columns["stokGiris_id"].Visible = false;
            dgv_stok.Columns["firma_id"].Visible = false;
            dgv_stok.Columns["kullanici_id"].Visible = false;

        }

        private void stok_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            StokGridiDoldur();
            cbx_urun.ValueMember = "urun_id";
            cbx_urun.DisplayMember = "urunKod";
            cbx_urun.DataSource = vt.Select("SELECT urun_id, CAST(urunAd AS nvarchar(MAX)) + '-' + CAST(kod AS nvarchar(MAX)) AS urunKod\r\nFROM tbl_urun;");
            cbx_firma.ValueMember = "firma_id";
            cbx_firma.DisplayMember = "firmaAd";
            cbx_firma.DataSource = vt.Select("select firma_id, firmaAd from tbl_firma");
        }
        private void txt_sadece_sayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void tx_stokmik_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tx_kritik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string fiyat = tx_kritik.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Kritik Stok 0 olamaz!");
                return;
            }
            string fiyat2 = tx_alisfiyat.Text.Trim();

            if (fiyat2.Length > 0 && fiyat2[0] == '0')
            {
                MessageBox.Show("Alış Fiyatı ilk rakamı 0 olamaz!");
                return;
            }
            string fiyat3 = tx_adet.Text.Trim();

            if (fiyat3.Length > 0 && fiyat3[0] == '0')
            {
                MessageBox.Show("Stok Adeti 0 olamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen Ürün seçiniz!");
                return;
            }
            if (cbx_firma.SelectedValue == null || cbx_firma.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Firma boş bırakılamaz. Lütfen Firma seçiniz!");
                return;
            }
            if (tx_stokmik.Text == "")
            {
                MessageBox.Show("Stok Miktarı boş bırakılamaz. Lütfen Stok Miktarını Girecek Adet Bilgisini Giriniz!");
                return;
            }
            if (tx_kritik.Text == "")
            {
                MessageBox.Show("Kritik Stok boş bırakılamaz. Lütfen Kritik Stok Bilgisini Giriniz!");
                return;
            }
            if (tx_alisfiyat.Text == "")
            {
                MessageBox.Show("Alış Fiyatı boş bırakılamaz. Lütfen Alış Fiyatı Bilgisini Giriniz!");
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz. Lütfen Adet Bilgisini Giriniz!");
                return;
            }
            if (dtp_skt.Value == DateTime.MinValue)
            {
                MessageBox.Show("Son Kullanma Tarihi Boş Bırakılamaz. Lütfen Son Kullanma Tarihini seçiniz!");
                return;
            }
            if (dtp_skt.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Geçerli bir Son Kullanma Tarihi seçiniz, Son Kullanma Tarihi Geçmiş Zaman Olamaz!");
                return;
            }
            DataTable dt = vt.Select(@"select s.stok_id, s.stokMiktari, s.kritikStok, u.urun_id, sgd.stokGirisDetay_id, sgd.alisFiyat, sgd.adet, sgd.sonKullanmaTarih, sg.stokGiris_id, sg.tarih, sg.saat, sg.toplamMaliyet, sg.firma_id, f.firmaAd, sg.kullanici_id, k.ad
                from tbl_stok s
                join tbl_urun u on u.urun_id=s.urun_id
                join tbl_stokGirisDetay sgd on u.urun_id=sgd.urun_id
                join tbl_stokGiris sg on sg.stokGiris_id=sgd.stokGiris_id
                join tbl_kullanici k on k.kullanici_id=sg.kullanici_id
                join tbl_firma f on f.firma_id=sg.firma_id
                  where s.urun_id= '"+cbx_urun.SelectedValue+"' and sgd.urun_id ='" + cbx_urun.SelectedValue + "'");
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Stok Bilgisinde Önceden Stoklanmış Bir Ürün Bulunuyor...");
                return;
            }
            DataTable dtt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  where s.urun_id= '" + cbx_urun.SelectedValue + "'");
            int stokMiktari, girilenAdet, kalan2, kritikStok;
            int.TryParse(dtt.Rows[0]["kritikStok"].ToString(), out kritikStok);
            int.TryParse(dtt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
            int.TryParse(tx_adet.Text, out girilenAdet);
            kalan2 = stokMiktari - girilenAdet;
            if (kalan2 <= kritikStok)
            {
                MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
            }
            int adet, alisFiyat, toplamMaliyet;
            DateTime now = DateTime.Now;
            if (int.TryParse(tx_adet.Text, out adet) && int.TryParse(tx_alisfiyat.Text, out alisFiyat))
            {
                toplamMaliyet = adet * alisFiyat;
                vt.Insert(@"insert into tbl_stok(stokMiktari,kritikStok, urun_id)
                        values('" + tx_adet.Text + "','" + tx_kritik.Text + "','" + cbx_urun.SelectedValue + "')");

                vt.Insert(@"insert into tbl_stokGiris(tarih,saat,toplamMaliyet,firma_id,kullanici_id)
                        values('" + now.ToString("yyyy-MM-dd") + "','" + now.ToString("HH:mm:ss") + "','" + toplamMaliyet + "','" + cbx_firma.SelectedValue + "','" + kullanici_id + "')");

                vt.Insert(@"insert into tbl_stokGirisDetay(alisFiyat,adet,sonKullanmaTarih,urun_id,stokGiris_id)
                        values('" + tx_alisfiyat.Text + "','" + tx_adet.Text + "','" + dtp_skt.Value.ToString("yyyy-MM-dd") + "','" + cbx_urun.SelectedValue + "',(SELECT MAX(stokGiris_id) FROM tbl_stokGiris))");
                StokGridiDoldur();
                MessageBox.Show("Stok Bilgisi Eklendi");
            }
            else
            {
                MessageBox.Show("Geçerli adet ve alış fiyatı giriniz!");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_stok.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Stok Bilgisini Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Stok Bilgilerini Silmek Stok Bilgilerine Ait Kayıtları ve Kayıt Detaylarını Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete("delete from tbl_stok where stok_id=" + dgv_stok.SelectedRows[0].Cells["stok_id"].Value);
                vt.UpdateDelete("delete from tbl_stokGirisDetay where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                vt.UpdateDelete("delete from tbl_stokGiris where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                StokGridiDoldur();
                MessageBox.Show("Stok Bilgisi Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_stok.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Stok Bilgisini Seçiniz...");

                return;
            }
            string fiyat = tx_kritik.Text.Trim();

            if (fiyat.Length > 0 && fiyat[0] == '0')
            {
                MessageBox.Show("Kritik Stok 0 olamaz!");
                return;
            }
            string fiyat2 = tx_alisfiyat.Text.Trim();

            if (fiyat2.Length > 0 && fiyat2[0] == '0')
            {
                MessageBox.Show("Alıi Fiyatı ilk rakamı 0 olamaz!");
                return;
            }
            string fiyat3 = tx_adet.Text.Trim();

            if (fiyat3.Length > 0 && fiyat3[0] == '0')
            {
                MessageBox.Show("Stok Adeti 0 olamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen Ürün seçiniz!");
                return;
            }
            if (cbx_firma.SelectedValue == null || cbx_firma.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Firma boş bırakılamaz. Lütfen Firma seçiniz!");
                return;
            }
            if(tx_stokmik.Text=="")
            {
                MessageBox.Show("Stok Miktarı boş bırakılamaz. Lütfen Stok Miktarını Girecek Adet Bilgisini Giriniz!");
                return;
            }
            if (tx_kritik.Text == "")
            {
                MessageBox.Show("Kritik Stok boş bırakılamaz. Lütfen Kritik Stok Bilgisini Giriniz!");
                return;
            }
            if (tx_alisfiyat.Text == "")
            {
                MessageBox.Show("Alış Fiyatı boş bırakılamaz. Lütfen Alış Fiyatı Bilgisini Giriniz!");
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Adet boş bırakılamaz. Lütfen Adet Bilgisini Giriniz!");
                return;
            }
            if (dtp_skt.Value == DateTime.MinValue)
            {
                MessageBox.Show("Son Kullanma Tarihi Boş Bırakılamaz. Lütfen Son Kullanma Tarihini seçiniz!");
                return;
            }
            if (dtp_skt.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Geçerli bir Son Kullanma Tarihi seçiniz, Son Kullanma Tarihi Geçmiş Zaman Olamaz!");
                return;
            }
            DataTable dt = vt.Select(@"select urun_id
                from tbl_stok
                where urun_id <> '" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value+"' and urun_id='"+cbx_urun.SelectedValue+"' ");

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Stok Bilgisinde Önceden Stoklanmış Bir Ürün Bulunuyor...");
                return;
            }


            DialogResult secenek = MessageBox.Show("Bu Stok Bilgilerini Güncellemek Stoğa Ait Kayıtları da Güncelleyebilir Ve Ya Birim Olarak Üstüne Yazacaktır. Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                DateTime now = DateTime.Now;
                int adet, stokMiktari, toplamStok, kalanAdet, ilkAdet, alisFiyat, toplamMaliyet, toplamMaliyeteEklenecek, ilkAlisFiyati, kalanAlisFiyat,kritikStok;
                int.TryParse(tx_adet.Text, out adet);
                int.TryParse(tx_stokmik.Text, out stokMiktari);
                int.TryParse(dgv_stok.SelectedRows[0].Cells["adet"].Value.ToString(), out ilkAdet);
                int.TryParse(dgv_stok.SelectedRows[0].Cells["kritikStok"].Value.ToString(), out kritikStok);
                int.TryParse(tx_alisfiyat.Text, out alisFiyat);
                int.TryParse(dgv_stok.SelectedRows[0].Cells["alisfiyat"].Value.ToString(), out ilkAlisFiyati);
                int.TryParse(dgv_stok.SelectedRows[0].Cells["toplamMaliyet"].Value.ToString(), out toplamMaliyet);
                if (adet < ilkAdet && alisFiyat == ilkAlisFiyati)
                {
                    kalanAdet = ilkAdet - adet;
                    toplamMaliyeteEklenecek = kalanAdet * alisFiyat;
                    toplamMaliyet = toplamMaliyet - toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari - kalanAdet;
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok <= kritikStok)
                    {
                        MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Adetten Kalan Kadar Stok Miktarı Azaltıldı\nÜrün Bilgileri Güncellendi...","DİKKAT",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if(adet > ilkAdet && alisFiyat == ilkAlisFiyati)
                {

                    kalanAdet = adet - ilkAdet;
                    toplamMaliyeteEklenecek = kalanAdet * alisFiyat;
                    toplamMaliyet = toplamMaliyet + toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari + kalanAdet;
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);

                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);

                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Adetten Kalan Kadar Stok Miktarı Arttırıldı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (alisFiyat < ilkAlisFiyati && adet == ilkAdet)
                {
                    
                    kalanAlisFiyat = ilkAlisFiyati - alisFiyat;
                    toplamMaliyeteEklenecek = ilkAdet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet - toplamMaliyeteEklenecek;
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + dgv_stok.SelectedRows[0].Cells["stokMiktari"].Value + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından Kalan Kadar Toplam Maliyet Azaltıldı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (alisFiyat > ilkAlisFiyati && adet == ilkAdet)
                {

                    kalanAlisFiyat = alisFiyat - ilkAlisFiyati;
                    toplamMaliyeteEklenecek = ilkAdet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet + toplamMaliyeteEklenecek;
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + dgv_stok.SelectedRows[0].Cells["stokMiktari"].Value + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından Kalan Kadar Toplam Maliyet Arttırıldı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (adet < ilkAdet && alisFiyat < ilkAlisFiyati)
                {
                    kalanAdet = ilkAdet - adet;
                    kalanAlisFiyat = ilkAlisFiyati - alisFiyat;
                    toplamMaliyeteEklenecek = adet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet - (kalanAdet * ilkAlisFiyati);
                    toplamMaliyet = toplamMaliyet - toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari - kalanAdet;
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok <= kritikStok)
                    {
                        MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından ve İlk Adet Miktarından Kalan Kadar, Toplam Maliyet ve Stok Miktarına Azaltma İşlemi Uygulandı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (adet < ilkAdet && alisFiyat > ilkAlisFiyati)
                {
                    kalanAdet = ilkAdet - adet;
                    kalanAlisFiyat = alisFiyat - ilkAlisFiyati;
                    toplamMaliyeteEklenecek = adet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet - (kalanAdet * ilkAlisFiyati);
                    toplamMaliyet = toplamMaliyet + toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari -kalanAdet;
                    //güncelleme işlemleri
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok <= kritikStok)
                    {
                        MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
                    }
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından Kalan Kadar Toplam Maliyet Arttırıldı\nİlk Adet Miktarından Kalan Kadar Stok Miktarına Azaltma İşlemi Uygulandı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (adet > ilkAdet && alisFiyat < ilkAlisFiyati)
                {
                    kalanAdet = adet - ilkAdet;
                    kalanAlisFiyat = ilkAlisFiyati - alisFiyat;
                    toplamMaliyeteEklenecek = adet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet + (kalanAdet * ilkAlisFiyati);
                    toplamMaliyet = toplamMaliyet - toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari + kalanAdet;
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından Kalan Kadar Toplam Maliyet Azaltıldı\nİlk Adet Miktarından Kalan Kadar Toplam Maliyete Arttırma İşlemi Uygulandı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (adet > ilkAdet && alisFiyat > ilkAlisFiyati)
                {
                    kalanAdet = adet - ilkAdet;
                    kalanAlisFiyat = alisFiyat - ilkAlisFiyati;
                    toplamMaliyeteEklenecek = adet * kalanAlisFiyat;
                    toplamMaliyet = toplamMaliyet + (kalanAdet * ilkAlisFiyati);
                    toplamMaliyet = toplamMaliyet + toplamMaliyeteEklenecek;
                    toplamStok = stokMiktari + kalanAdet;
                    if (toplamMaliyet < 0)
                    {
                        MessageBox.Show("Toplam Maliyet Negatif Olamaz...");
                        return;
                    }
                    if (toplamStok < 0)
                    {
                        MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                        return;
                    }
                    //güncelleme işlemleri
                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + toplamStok + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + toplamMaliyet + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("İlk Alış Fiyatından Kalan Kadar Toplam Maliyet Arttırıldı\nİlk Adet Miktarından Kalan Kadar Toplam Maliyete Arttırma İşlemi Uygulandı\nÜrün Bilgileri Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(adet == ilkAdet && alisFiyat == ilkAlisFiyati)
                {

                    vt.UpdateDelete(@"update tbl_stok
                set 
	                kritikStok='" + tx_kritik.Text + @"',
                    stokMiktari='" + dgv_stok.SelectedRows[0].Cells["stokMiktari"].Value + @"'
	                where urun_id=" + dgv_stok.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGiris
                set 
	                tarih='" + now.ToString("yyyy-MM-dd") + @"',
                    saat='" + now.ToString("HH:mm:ss") + @"',
                    toplamMaliyet='" + dgv_stok.SelectedRows[0].Cells["toplamMaliyet"].Value + @"',
                    firma_id='" + cbx_firma.SelectedValue + @"',
                    kullanici_id='" + kullanici_id + @"'
	                where stokGiris_id=" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value);
                    vt.UpdateDelete(@"update tbl_stokGirisDetay
                set 
	                alisFiyat='" + tx_alisfiyat.Text + @"',
                    adet='" + tx_adet.Text + @"',
                    sonKullanmaTarih='" + dtp_skt.Value.ToString("yyyy-MM-dd") + @"',
                    urun_id='" + cbx_urun.SelectedValue + @"',
                    stokGiris_id='" + dgv_stok.SelectedRows[0].Cells["stokGiris_id"].Value + @"'
	                where stokGirisDetay_id=" + dgv_stok.SelectedRows[0].Cells["stokGirisDetay_id"].Value);
                    StokGridiDoldur();
                    MessageBox.Show("Ürün Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void dgv_stok_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_stok.SelectedRows.Count == 0)
            {
                return;
            }
            tx_stokmik.Text = dgv_stok.SelectedRows[0].Cells["stokMiktari"].Value.ToString();
            tx_kritik.Text = dgv_stok.SelectedRows[0].Cells["kritikStok"].Value.ToString();
            tx_alisfiyat.Text = dgv_stok.SelectedRows[0].Cells["alisFiyat"].Value.ToString();
            tx_adet.Text = dgv_stok.SelectedRows[0].Cells["adet"].Value.ToString();
            cbx_urun.SelectedValue = dgv_stok.SelectedRows[0].Cells["urun_id"].Value.ToString();
            cbx_firma.SelectedValue= dgv_stok.SelectedRows[0].Cells["firma_id"].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_stokmik.Text = "";
            tx_kritik.Text = "";
            tx_alisfiyat.Text = "";
            tx_adet.Text = "";
            cbx_urun.SelectedValue = 0;
            cbx_firma.SelectedValue = 0;
            dtp_skt.Value = DateTime.Now;
            if (dgv_stok.SelectedRows.Count != 0)
                dgv_stok.SelectedRows[0].Selected = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cbx_urun_TextChanged(object sender, EventArgs e)
        {
            int stokMiktari, kritikStok;
            DataTable dt = vt.Select(@"SELECT kritikStok,stokMiktari from tbl_stok
                  where urun_id= '" + cbx_urun.SelectedValue + "'");
            if (dt.Rows.Count == 1)
            {
                int.TryParse(dt.Rows[0]["kritikStok"].ToString(), out kritikStok);
                int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
                int esikDeger = 10;
                int fark = Math.Abs(stokMiktari - kritikStok);
                if (stokMiktari <= kritikStok)
                {
                    lbl_kritik.Text = "Kritik Stok Değeri Geçilmiş!";
                }
                else if (fark <= esikDeger)
                {
                    lbl_kritik.Text = "Kritik Stok Değeri Geçilmeye Yakın!";
                }
                else
                {
                    lbl_kritik.Text = "";
                }
            }
            else if (dt.Rows.Count == 0)
            {
                lbl_kritik.Text = "";
            }
        }

        private void stok_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}

