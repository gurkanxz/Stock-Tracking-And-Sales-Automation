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
    public partial class kullaniciTürü : Form
    {
        public kullaniciTürü()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void KullaniciTuruGridiDoldur()
        {
            dgv_tur.DataSource = vt.Select(@"select k.turAd, k.kullaniciTur_id, kt.yetki, kt.yetki_id
                    from tbl_kullaniciTur k
					join tbl_yetki kt on kt.yetki_id=k.yetki_id");
            dgv_tur.Columns["kullaniciTur_id"].Visible = false;
            dgv_tur.Columns["yetki_id"].Visible = false;

        }
        private void kullaniciTürü_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            KullaniciTuruGridiDoldur();
            cbx_yetki.ValueMember = "yetki_id";
            cbx_yetki.DisplayMember = "yetki";
            cbx_yetki.DataSource = vt.Select(@"select k.turAd, k.kullaniciTur_id, kt.yetki, kt.yetki_id
                    from tbl_kullaniciTur k
					full join tbl_yetki kt on kt.yetki_id=k.yetki_id");

        }

        private void dgv_tur_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                return;
            }
            tx_turAd.Text = dgv_tur.SelectedRows[0].Cells["turAd"].Value.ToString();
            cbx_yetki.SelectedValue = dgv_tur.SelectedRows[0].Cells["yetki_id"].Value.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_turAd.Text.Length < 2 || tx_turAd.Text.Length > 50)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 50 Karakter olabilir...");
                return;
            }
            if (cbx_yetki.SelectedValue == null || cbx_yetki.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Kullanıcı Yetkisi boş bırakılamaz. Lütfen Kullanıcı Yetkisi seçiniz!");
                return;
            }
            string turAd = tx_turAd.Text.Trim(); // Boşlukları temizle

            DataTable dt = vt.Select(@"select turAd from tbl_kullaniciTur
                            where REPLACE(turAd, ' ', '') = '" + turAd.Replace(" ", "") + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Tur Adı İle Önceden Kayıt Edilmiş Bir Kullanıcı Türü Bulunuyor...");
                return;
            }

            vt.Insert(@"insert into tbl_kullaniciTur(turAd,yetki_id)
                        values('" + tx_turAd.Text + "','" + cbx_yetki.SelectedValue + "')");
            KullaniciTuruGridiDoldur();
            MessageBox.Show("Kullanici Türü Eklendi");
        }

        private void tx_turAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);

        }
        private void kopyalaEngelle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Silinecek Kullanıcı Türünü Seçiniz...");

                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Türü Bilgilerini Silmek O Kullanıcı Türüne Ait Kayıtları Silecektir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                
                vt.UpdateDelete("DELETE t1 FROM tbl_satisDetay t1 INNER JOIN tbl_satis t2 ON t1.satis_id = t2.satis_id INNER JOIN tbl_kullanici t3 on t2.kullanici_id=t3.kullanici_id WHERE t3.kullaniciTur_id =" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_satis t1 INNER JOIN tbl_kullanici t3 on t1.kullanici_id=t3.kullanici_id WHERE t3.kullaniciTur_id =" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_stokGirisDetay t1 INNER JOIN tbl_stokGiris t2 ON t1.stokGiris_id = t2.stokGiris_id INNER JOIN tbl_kullanici t3 on t2.kullanici_id=t3.kullanici_id WHERE t3.kullaniciTur_id =" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_stokGiris t1 INNER JOIN tbl_kullanici t3 on t1.kullanici_id=t3.kullanici_id WHERE t3.kullaniciTur_id=" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_log t1 INNER JOIN tbl_kullanici t3 on t1.kullanici_id=t3.kullanici_id WHERE t3.kullaniciTur_id=" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("DELETE t1 FROM tbl_kullanici t1 INNER JOIN tbl_kullaniciTur t3 on t1.kullaniciTur_id=t3.kullaniciTur_id WHERE t3.kullaniciTur_id=" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                vt.UpdateDelete("delete from tbl_kullaniciTur where kullaniciTur_id=" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);

                KullaniciTuruGridiDoldur();
                MessageBox.Show("Kullanici Türü Silindi");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)

        {
            if (dgv_tur.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kullanıcıyı Seçiniz...");
                return;
            }
            if (tx_turAd.Text.Length < 2 || tx_turAd.Text.Length > 50)
            {
                MessageBox.Show("Ad En Az 2 Karakter En Fazla 50 Karakter olabilir...");
                return;
            }
            if (cbx_yetki.SelectedValue == null || cbx_yetki.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Kullanıcı Yetkisi boş bırakılamaz. Lütfen Kullanıcı Yetkisi seçiniz!");
                return;
            }
            string turAd = tx_turAd.Text.Trim();
            int selectedKullaniciTurId = Convert.ToInt32(dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);

            DataTable dt = vt.Select(@"SELECT turAd FROM tbl_kullaniciTur
                WHERE REPLACE(turAd, ' ', '') = '" + turAd.Replace(" ", "") + "'  AND kullaniciTur_id <> " + selectedKullaniciTurId);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bu Tur Adı İle Önceden Kayıt Edilmiş Bir Kullanıcı Türü Bulunuyor...");
                return;
            }
            DataTable dtt = vt.Select(@"select turAd, yetki_id from tbl_kullaniciTur
                                where turAd='" + tx_turAd.Text + "' and yetki_id='" + cbx_yetki.SelectedValue+ "' ");
            if (dtt.Rows.Count == 1)
            {
                MessageBox.Show("Bu Tur Adı İle Önceden Kayıt Edilmiş Bir Kullanıcı Türü Bulunuyor...");
                return;
            }

            DialogResult secenek = MessageBox.Show("Bu Kullanıcı Türü Bilgilerini Güncellemek O Kullanıcı Türüne Ait Kayıtları da Güncelleyebilir Devam Etmek İstiyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (secenek == DialogResult.Yes)
            {
                vt.UpdateDelete(@"update tbl_kullaniciTur
                set 
	                turAd='" + tx_turAd.Text + @"',
                    yetki_id='" + cbx_yetki.SelectedValue + @"'
	                where kullaniciTur_id=" + dgv_tur.SelectedRows[0].Cells["kullaniciTur_id"].Value);
                KullaniciTuruGridiDoldur();
                MessageBox.Show("Kullanıcı Turu Güncellendi");
            }
            else if (secenek == DialogResult.No)
            {
                return;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_turAd.Text = "";
            cbx_yetki.SelectedValue = 0;
            if (dgv_tur.SelectedRows.Count != 0)
                dgv_tur.SelectedRows[0].Selected = false;
        }

        private void kullaniciTürü_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
