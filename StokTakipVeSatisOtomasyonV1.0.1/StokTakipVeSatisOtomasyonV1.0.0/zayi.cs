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
    public partial class zayi : Form
    {
        public zayi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void ZayiGridiDoldur()
        {
            dgv_zayi.DataSource = vt.Select(@"select z.zayiUrun_id,CAST(u.urunAd AS nvarchar(MAX)) + '-' + CAST(u.kod AS nvarchar(MAX)) AS urunKod,z.zayiAdet,z.zayiMaliyet,z.zayiTarih,z.urun_id
            from tbl_zayiUrun z
            join tbl_urun u on u.urun_id=z.urun_id");
            dgv_zayi.Columns["zayiUrun_id"].Visible = false;
            dgv_zayi.Columns["urun_id"].Visible = false;

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
        private void zayi_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            ZayiGridiDoldur();
            cbx_urun.ValueMember = "urun_id";
            cbx_urun.DisplayMember = "urunKod";
            cbx_urun.DataSource = vt.Select("SELECT s.urun_id, CAST(u.urunAd AS nvarchar(MAX)) + '-' + CAST(u.kod AS nvarchar(MAX)) AS urunKod FROM tbl_urun u join tbl_stok s on s.urun_id=u.urun_id;");
            cbx_urun.SelectedIndexChanged += cbx_urun_SelectedIndexChanged;
            if (cbx_urun.SelectedValue != null)
            {
                int selectedUrunId = (int)cbx_urun.SelectedValue;
                UpdateStokMiktariGrid(selectedUrunId);
            }
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string fiyat2 = tx_maliyet.Text.Trim();

            if (fiyat2.Length > 0 && fiyat2[0] == '0')
            {
                MessageBox.Show("Maliyet 0 olamaz!");
                return;
            }
            string fiyat3 = tx_adet.Text.Trim();

            if (fiyat3.Length > 0 && fiyat3[0] == '0')
            {
                MessageBox.Show("Zayi Adeti 0 olamaz!");
                return;
            }
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Zayi Adeti boş bırakılamaz!");
                return;
            }
            if (tx_maliyet.Text == "")
            {
                MessageBox.Show("Maliyet boş bırakılamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen stoklanmış ürün seçiniz!");
                return;
            }
            DataTable dt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  where s.urun_id= '" + cbx_urun.SelectedValue + "'");
            int stokMiktari, girilenAdet,kalan,kritikStok,urun_id;
            DateTime now = DateTime.Now;
            int.TryParse(dt.Rows[0]["kritikStok"].ToString(), out kritikStok);
            int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
            int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urun_id);
            int.TryParse(tx_adet.Text, out girilenAdet);
            if (stokMiktari < girilenAdet)
            {
                MessageBox.Show("Zayi Adeti Stok Miktarından Fazla Olamaz...");
                return;
            }
            kalan = stokMiktari - girilenAdet;
            if(kalan < 0)
            {
                MessageBox.Show("Stok Miktarı Negatif Olamaz...");
                return;
            }
            if(kalan<=kritikStok)
            {
                MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
            }
            vt.Insert(@"insert into tbl_zayiUrun(zayiTarih,zayiMaliyet,zayiAdet,urun_id)
                        values('" + now.ToString("yyyy-MM-dd") + "','" + tx_maliyet.Text + "','" + tx_adet.Text + "','" + cbx_urun.SelectedValue + "')");
            vt.UpdateDelete(@"update tbl_stok
                set 
	                stokMiktari='" + kalan + @"'

	                where urun_id=" +cbx_urun.SelectedValue);
            ZayiGridiDoldur();
            UpdateStokMiktariGrid(urun_id);
            MessageBox.Show("Zayi Adeti Stok Miktarından Düşüldü ve Zayi Bilgisi Eklendi");

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_zayi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Zayi Bilgisi Seçiniz...");

                return;
            }
            DataTable dt2 = vt.Select(@"select *from tbl_stok where urun_id='"+ dgv_zayi.SelectedRows[0].Cells["urun_id"].Value + "'");
            if (dt2.Rows.Count == 0)
            {
                vt.UpdateDelete("delete from tbl_zayiUrun where zayiUrun_id=" + dgv_zayi.SelectedRows[0].Cells["zayiUrun_id"].Value);
                ZayiGridiDoldur();
                MessageBox.Show("Stok Bilgisi Bulunamadı...\nZayi Bilgisi Silindi...!");
            }
            else if (dt2.Rows.Count == 1)
            {
                DialogResult secenek = MessageBox.Show("Bu Zayi Bilgilerini Silmek Zayi Adetini Geri Stok Miktarına Ekleyecektir\nDevam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    DataTable dt = vt.Select(@"SELECT s.stokMiktari,s.urun_id,z.zayiAdet from tbl_stok s
                    join tbl_zayiUrun z on z.urun_id = s.urun_id
                    where s.urun_id= '" + dgv_zayi.SelectedRows[0].Cells["urun_id"].Value + "'");
                    int stokMiktari, zayiAdet,urun_id;
                    int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
                    int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urun_id);
                    int.TryParse(dt.Rows[0]["zayiAdet"].ToString(), out zayiAdet);
                    stokMiktari = stokMiktari + zayiAdet;
                    vt.UpdateDelete(@"update tbl_stok
                    set 
	                stokMiktari='" + stokMiktari + @"'
	                where urun_id=" + dgv_zayi.SelectedRows[0].Cells["urun_id"].Value);
                    vt.UpdateDelete("delete from tbl_zayiUrun where zayiUrun_id=" + dgv_zayi.SelectedRows[0].Cells["zayiUrun_id"].Value);

                    MessageBox.Show("Zayi Bilgisi Silindi Ve Zayi Adeti Stok Miktarına Eklendi...");
                    ZayiGridiDoldur();
                    UpdateStokMiktariGrid(urun_id);
                }
                else if(secenek == DialogResult.No)
                {
                    return;
                }
                   
            }
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_zayi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellenecek Zayi Bilgisi Seçiniz...");

                return;
            }
            //string fiyat2 = tx_maliyet.Text.Trim();

            //if (fiyat2.Length > 0 && fiyat2[0] == '0')
            //{
            //    MessageBox.Show("Maliyet 0 olamaz!");
            //    return;
            //}
            //string fiyat3 = tx_adet.Text.Trim();

            //if (fiyat3.Length > 0 && fiyat3[0] == '0')
            //{
            //    MessageBox.Show("Zayi Adeti 0 olamaz!");
            //    return;
            //}
            if (tx_adet.Text == "")
            {
                MessageBox.Show("Zayi Adeti boş bırakılamaz!");
                return;
            }
            if (tx_maliyet.Text == "")
            {
                MessageBox.Show("Maliyet boş bırakılamaz!");
                return;
            }
            if (cbx_urun.SelectedValue == null || cbx_urun.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Ürün boş bırakılamaz. Lütfen stoklanmış ürün seçiniz!");
                return;
            }
            DataTable dt = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  where s.urun_id= '" + cbx_urun.SelectedValue + "'");
            int stokMiktari, girilenAdet, kalan, kritikStok, urun_id;
            DateTime now = DateTime.Now;
            int.TryParse(dt.Rows[0]["kritikStok"].ToString(), out kritikStok);
            int.TryParse(dt.Rows[0]["stokMiktari"].ToString(), out stokMiktari);
            int.TryParse(dt.Rows[0]["urun_id"].ToString(), out urun_id);
            int.TryParse(tx_adet.Text, out girilenAdet);
            //if (stokMiktari < girilenAdet)
            //{
            //    MessageBox.Show("Zayi Adeti Stok Miktarından Fazla Olamaz...");
            //    return;
            //}
            kalan = stokMiktari - girilenAdet;
            //if (kalan < 0)
            //{
            //    MessageBox.Show("Stok Miktarı Negatif Olamaz...");
            //    return;
            //}
            if (kalan <= kritikStok)
            {
                MessageBox.Show("Kritik Stok Miktarı Aşıldı!");
            }
            DataTable dt2 = vt.Select(@"select *from tbl_stok where urun_id='" + dgv_zayi.SelectedRows[0].Cells["urun_id"].Value + "'");
            if (dt2.Rows.Count == 0)
            {

                MessageBox.Show("Bu Zayi Bilgisine Ait Stok Bilgisi Bulunamadı...!\nGüncelleme Yapılamıyor...");
                return;
            }
            else if (dt2.Rows.Count == 1)
            {

                DialogResult secenek = MessageBox.Show("Bu Zayi Bilgilerini Güncellemek Diğer Kayıtları da Etkileyecektir\nDevam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    DataTable dt22 = vt.Select(@"SELECT s.urun_id,s.stokMiktari,s.kritikStok,z.zayiAdet FROM tbl_urun u
                  join tbl_stok s on s.urun_id=u.urun_id
                  join tbl_zayiUrun z on z.urun_id=s.urun_id
                  where s.urun_id= '" + dgv_zayi.SelectedRows[0].Cells["urun_id"].Value + "'");
                    int stokMiktari2, girilenAdet2, kalan2, kritikStok2, urun_id2,zayiMiktari2;
                    int.TryParse(dt22.Rows[0]["kritikStok"].ToString(), out kritikStok2);
                    int.TryParse(dt22.Rows[0]["stokMiktari"].ToString(), out stokMiktari2);
                    int.TryParse(dt22.Rows[0]["urun_id"].ToString(), out urun_id2);
                    int.TryParse(dt22.Rows[0]["zayiAdet"].ToString(), out zayiMiktari2);
                    int.TryParse(tx_adet.Text, out girilenAdet2);

                    if (girilenAdet2<zayiMiktari2)
                    {
                        kalan2 = zayiMiktari2 - girilenAdet2;
                        stokMiktari2 = stokMiktari2 + kalan2;
                        if(stokMiktari2< 0)
                        {
                            MessageBox.Show("Stok Miktarını Negatif Yapan Değerler Girilemez...");
                            return;
                        }
                        vt.UpdateDelete(@"update tbl_stok
                         set 
	                     stokMiktari='" + stokMiktari2+ @"'
	                     where urun_id=" + cbx_urun.SelectedValue);

                        vt.UpdateDelete(@"update tbl_zayiUrun
                            set 
	                        zayiTarih='" + now.ToString("yyyy-MM-dd") + @"',
                            zayiMaliyet='" + tx_maliyet.Text + @"',
                            zayiAdet='" + tx_adet.Text + @"',
                            urun_id='" + cbx_urun.SelectedValue + @"'
	                        where zayiUrun_id=" + dgv_zayi.SelectedRows[0].Cells["zayiUrun_id"].Value);
                        ZayiGridiDoldur();
                        UpdateStokMiktariGrid(urun_id);
                        MessageBox.Show("Stok Miktarı Girilen Zayi Adetten Kalan Kadar Arttırıldı...\nZayi Bilgileri Güncellendi.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(girilenAdet2 > zayiMiktari2)
                    {
                        kalan2 = girilenAdet2 - zayiMiktari2;
                        stokMiktari2 = stokMiktari2 - kalan2;
                        if (stokMiktari2 < 0)
                        {
                            MessageBox.Show("Stok Miktarını Negatif Yapan Değerler Girilemez...");
                            return;
                        }
                        vt.UpdateDelete(@"update tbl_stok
                         set 
	                     stokMiktari='" + stokMiktari2 + @"'
	                     where urun_id=" + cbx_urun.SelectedValue);

                        vt.UpdateDelete(@"update tbl_zayiUrun
                            set 
	                        zayiTarih='" + now.ToString("yyyy-MM-dd") + @"',
                            zayiMaliyet='" + tx_maliyet.Text + @"',
                            zayiAdet='" + tx_adet.Text + @"',
                            urun_id='" + cbx_urun.SelectedValue + @"'
	                        where zayiUrun_id=" + dgv_zayi.SelectedRows[0].Cells["zayiUrun_id"].Value);
                        ZayiGridiDoldur();
                        UpdateStokMiktariGrid(urun_id);
                        MessageBox.Show("Stok Miktarı Girilen Zayi Adetten Kalan Kadar Azaltıldı...\nZayi Bilgileri Güncellendi.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(girilenAdet2 == zayiMiktari2)
                    {
                        vt.UpdateDelete(@"update tbl_zayiUrun
                            set 
	                        zayiTarih='" + now.ToString("yyyy-MM-dd") + @"',
                            zayiMaliyet='" + tx_maliyet.Text + @"',
                            zayiAdet='" + tx_adet.Text + @"',
                            urun_id='" + cbx_urun.SelectedValue + @"'
	                        where zayiUrun_id=" + dgv_zayi.SelectedRows[0].Cells["zayiUrun_id"].Value);
                        ZayiGridiDoldur();
                        UpdateStokMiktariGrid(urun_id);
                        MessageBox.Show("Ürün Güncellendi", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (secenek == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_adet.Text = "";
            tx_maliyet.Text = "";
            cbx_urun.SelectedValue = 0;
            if (dgv_zayi.SelectedRows.Count != 0)
                dgv_zayi.SelectedRows[0].Selected = false;
        }

        private void tx_adet_TextChanged(object sender, EventArgs e)
        {
            int alisFiyat, adet, toplamTutar;
            DataTable dt = vt.Select(@"SELECT alisFiyat from tbl_stokGirisDetay
                  where urun_id= '" + cbx_urun.SelectedValue + "'");
            if (dt.Rows.Count == 1)
            {
                int.TryParse(dt.Rows[0]["alisFiyat"].ToString(), out alisFiyat);
                int.TryParse(tx_adet.Text, out adet);
                int.TryParse(tx_maliyet.Text, out toplamTutar);
                toplamTutar = adet * alisFiyat;
                tx_maliyet.Text = toplamTutar.ToString();
            }

        }

        private void dgv_zayi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_zayi.SelectedRows.Count == 0)
            {
                return;
            }
            tx_adet.Text = dgv_zayi.SelectedRows[0].Cells["zayiAdet"].Value.ToString();
            tx_maliyet.Text = dgv_zayi.SelectedRows[0].Cells["zayiMaliyet"].Value.ToString();
            cbx_urun.SelectedValue = dgv_zayi.SelectedRows[0].Cells["urun_id"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = vt.Select(@"select s.stok_id, s.stokMiktari, s.kritikStok, u.urun_id, u.urunAd, sgd.stokGirisDetay_id, sgd.alisFiyat, sgd.adet, sgd.sonKullanmaTarih, sg.stokGiris_id, sg.tarih GirisTarih, sg.saat GirisSaat, sg.toplamMaliyet, sg.firma_id, f.firmaAd, sg.kullanici_id, k.ad KullanıcıAdı
            from tbl_stok s
            inner join tbl_urun u on u.urun_id=s.urun_id
            inner join tbl_stokGirisDetay sgd on u.urun_id=sgd.urun_id
            inner join tbl_stokGiris sg on sg.stokGiris_id=sgd.stokGiris_id
            inner join tbl_kullanici k on k.kullanici_id=sg.kullanici_id
            inner join tbl_firma f on f.firma_id=sg.firma_id");

            foreach (DataRow row in dt.Rows)
            {
                int stokMiktari, zayiAdet, toplam;
                decimal alisFiyat;
                DateTime sonKullanmaTarihi = Convert.ToDateTime(row["sonKullanmaTarih"]);
                int urunID = Convert.ToInt32(row["urun_id"]);
                int.TryParse(row["stokMiktari"].ToString(), out stokMiktari);
                decimal.TryParse(row["alisFiyat"].ToString(), out alisFiyat);
                DataTable dttt = vt.Select(@"select s.stok_id, s.stokMiktari, s.kritikStok, u.urun_id,CAST(u.urunAd AS nvarchar(MAX)) + '-' + CAST(u.kod AS nvarchar(MAX)) AS urunKod, sgd.stokGirisDetay_id, sgd.alisFiyat, sgd.adet, sgd.sonKullanmaTarih, sg.stokGiris_id, sg.tarih GirisTarih, sg.saat GirisSaat, sg.toplamMaliyet, sg.firma_id, f.firmaAd, sg.kullanici_id, k.ad KullanıcıAdı
                from tbl_stok s
                inner join tbl_urun u on u.urun_id=s.urun_id
                inner join tbl_stokGirisDetay sgd on u.urun_id=sgd.urun_id
                inner join tbl_stokGiris sg on sg.stokGiris_id=sgd.stokGiris_id
                inner join tbl_kullanici k on k.kullanici_id=sg.kullanici_id
                inner join tbl_firma f on f.firma_id=sg.firma_id where u.urun_id='" + urunID + "'");
                if (sonKullanmaTarihi < DateTime.Now)
                {
                    DataTable dtt = vt.Select(@"select * from tbl_zayiUrun where urun_id = " + urunID);

                    if (dtt.Rows.Count > 0)
                    {
                        // Zaten zayi ürünler tablosunda varsa güncelleme işlemi
                        int.TryParse(dtt.Rows[0]["zayiAdet"].ToString(), out zayiAdet);
                        toplam = stokMiktari + zayiAdet;

                        decimal zayiAlisFiyat = alisFiyat * toplam;

                        vt.UpdateDelete(@"update tbl_zayiUrun
                              set 
                                  urun_id = " + urunID + @",
                                  zayiAdet = " + toplam + @",
                                  zayiMaliyet = " + zayiAlisFiyat + @",
                                  zayiTarih = '" + DateTime.Now.ToString("yyyy-MM-dd") + @"'
                              where urun_id = " + urunID);

                        // Stok miktarını azaltma işlemi
                        vt.UpdateDelete(@"update tbl_stok
                              set 
                                  stokMiktari = 0
                              where urun_id = " + urunID);
                        ZayiGridiDoldur();
                        UpdateStokMiktariGrid(urunID);
                        MessageBox.Show(dttt.Rows[0]["urunKod"].ToString() + " Ürünü Stok Miktarından Düşüldü ve Zayi Bilgisi Eklendi");
                    }
                    else
                    {
                        if (stokMiktari == 0)
                        {
                            // Stok miktarı zaten sıfır
                        }
                        else if (stokMiktari > 0)
                        {
                            // Zayi ürünler tablosunda yoksa ekleme işlemi
                            vt.Insert(@"insert into tbl_zayiUrun(urun_id, zayiTarih,zayiAdet,zayiMaliyet)
                            values(" + urunID + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + stokMiktari + "','" + (alisFiyat * stokMiktari) + "')");

                            // Stok miktarını tamamen azaltma işlemi
                            vt.UpdateDelete(@"update tbl_stok
                                  set 
                                      stokMiktari = 0
                                  where urun_id = " + urunID);
                            ZayiGridiDoldur();
                            UpdateStokMiktariGrid(urunID);
                            MessageBox.Show("Tarihi Geçen '" + dttt.Rows[0]["urunKod"].ToString()+ "' Ürünleri Zayi ye atıldı...");
                        }
                    }
                }
            }



        }

        private void zayi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
