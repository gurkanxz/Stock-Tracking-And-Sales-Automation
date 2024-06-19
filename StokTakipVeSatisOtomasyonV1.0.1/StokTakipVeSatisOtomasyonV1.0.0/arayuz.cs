using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipVeSatisOtomasyonV1._0._0
{
    public partial class arayuz : Form
    {
        public class FormManager
        {
            private static List<Form> openForms = new List<Form>();

            public static void AddForm(Form form)
            {
                openForms.Add(form);
            }

            public static void RemoveForm(Form form)
            {
                openForms.Remove(form);
            }

            public static void ToggleFormsVisibility()
            {
                foreach (var form in openForms)
                {
                    form.Visible = !form.Visible;
                }
            }
            public static List<Form> GetOpenForms()
            {
                return openForms;
            }
            public static void ExitApplication()
            {
                Application.Exit();
            }
            public static bool AreFormsVisible()
            {
                return openForms.Any(form => form.Visible);
            }

        }
        public arayuz()
        {
            InitializeComponent();
            FormManager.AddForm(this);
        }

        VTI.Veritabani vt = new VTI.Veritabani();
        KullaniciGirisi a = new KullaniciGirisi();
        public int kullanici_id= 1;
        public int yetki_id= 1;
        public string adSoyad = " ";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            k.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz

            kt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            m.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            u.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            uk.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            s.kullanici_id = kullanici_id;
            s.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            sa.kullanici_id = kullanici_id;
            sa.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kullanici k = new kullanici();
            kullaniciTürü kt = new kullaniciTürü();
            musteri m = new musteri();
            urun u = new urun();
            urunKategori uk = new urunKategori();
            firma f = new firma();
            stok s = new stok();
            satis sa = new satis();
            zayi z = new zayi();
            log l = new log();

            if (yetki_id == 1)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = true;

            }//tüm yetkiler
            else if (yetki_id == 2)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = true;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = true;
                k.ts_guncelle.Enabled = false;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = true;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = true;
                kt.ts_guncelle.Enabled = false;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = true;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = true;
                m.ts_guncelle.Enabled = false;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = true;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = true;
                u.ts_guncelle.Enabled = false;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = true;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = true;
                uk.ts_guncelle.Enabled = false;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = true;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = true;
                f.ts_guncelle.Enabled = false;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = true;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = true;
                s.ts_guncelle.Enabled = false;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = true;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = true;
                sa.ts_guncelle.Enabled = false;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = true;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = true;
                z.ts_guncelle.Enabled = false;
            }//sadece ekle-sil
            else if (yetki_id == 3)
            {
                k.btn_ekle.Enabled = true;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = true;
                k.ts_ekle.Enabled = true;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = true;
                kt.btn_ekle.Enabled = true;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = true;
                kt.ts_ekle.Enabled = true;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = true;
                m.btn_ekle.Enabled = true;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = true;
                m.ts_ekle.Enabled = true;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = true;
                u.btn_ekle.Enabled = true;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = true;
                u.btn_resimsec.Enabled = true;
                u.ts_ekle.Enabled = true;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = true;
                uk.btn_ekle.Enabled = true;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = true;
                uk.ts_ekle.Enabled = true;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = true;
                f.btn_ekle.Enabled = true;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = true;
                f.ts_ekle.Enabled = true;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = true;
                s.btn_ekle.Enabled = true;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = true;
                s.ts_ekle.Enabled = true;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = true;
                sa.btn_ekle.Enabled = true;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = true;
                sa.ts_ekle.Enabled = true;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = true;
                z.btn_ekle.Enabled = true;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = true;
                z.ts_ekle.Enabled = true;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = true;
            }//ekle-güncelle
            else if (yetki_id == 4)
            {
                k.btn_ekle.Enabled = false;
                k.ts_ekle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.ts_ekle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.ts_ekle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.ts_ekle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.ts_ekle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.ts_ekle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.ts_ekle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.ts_ekle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.ts_ekle.Enabled = false;


            }//sil-güncelle
            else if (yetki_id == 5)
            {
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//ekle
            else if (yetki_id == 6)
            {
                k.btn_ekle.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_guncelle.Enabled = false;



            }//sil
            else if (yetki_id == 7)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;


            }//güncelle
            else if (yetki_id == 8)
            {
                k.btn_ekle.Enabled = false;
                k.btn_sil.Enabled = false;
                k.btn_guncelle.Enabled = false;
                k.ts_ekle.Enabled = false;
                k.ts_sil.Enabled = false;
                k.ts_guncelle.Enabled = false;

                kt.btn_ekle.Enabled = false;
                kt.btn_sil.Enabled = false;
                kt.btn_guncelle.Enabled = false;
                kt.ts_ekle.Enabled = false;
                kt.ts_sil.Enabled = false;
                kt.ts_guncelle.Enabled = false;

                m.btn_ekle.Enabled = false;
                m.btn_sil.Enabled = false;
                m.btn_guncelle.Enabled = false;
                m.ts_ekle.Enabled = false;
                m.ts_sil.Enabled = false;
                m.ts_guncelle.Enabled = false;

                u.btn_ekle.Enabled = false;
                u.btn_sil.Enabled = false;
                u.btn_guncelle.Enabled = false;
                u.btn_resimsec.Enabled = false;
                u.ts_ekle.Enabled = false;
                u.ts_sil.Enabled = false;
                u.ts_guncelle.Enabled = false;

                uk.btn_ekle.Enabled = false;
                uk.btn_sil.Enabled = false;
                uk.btn_guncelle.Enabled = false;
                uk.ts_ekle.Enabled = false;
                uk.ts_sil.Enabled = false;
                uk.ts_guncelle.Enabled = false;

                f.btn_ekle.Enabled = false;
                f.btn_sil.Enabled = false;
                f.btn_guncelle.Enabled = false;
                f.ts_ekle.Enabled = false;
                f.ts_sil.Enabled = false;
                f.ts_guncelle.Enabled = false;

                s.btn_ekle.Enabled = false;
                s.btn_sil.Enabled = false;
                s.btn_guncelle.Enabled = false;
                s.ts_ekle.Enabled = false;
                s.ts_sil.Enabled = false;
                s.ts_guncelle.Enabled = false;

                sa.btn_ekle.Enabled = false;
                sa.btn_sil.Enabled = false;
                sa.btn_guncelle.Enabled = false;
                sa.ts_ekle.Enabled = false;
                sa.ts_sil.Enabled = false;
                sa.ts_guncelle.Enabled = false;

                z.btn_ekle.Enabled = false;
                z.btn_sil.Enabled = false;
                z.btn_guncelle.Enabled = false;
                z.ts_ekle.Enabled = false;
                z.ts_sil.Enabled = false;
                z.ts_guncelle.Enabled = false;


            }//sadece görüntüleme yetkisi
            else
            {
                MessageBox.Show("Yetkiniz bulunmuyor lütfen yöneticiyle iletişime geçiniz...");
                return;
            }//yetkisiz
            z.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            log l = new log();
            l.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void arayuz_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (var form in FormManager.GetOpenForms())
        //    {
        //        form.Hide();
        //    }

        //}

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.ToggleFormsVisibility();

            
            gösterToolStripMenuItem.Text = FormManager.AreFormsVisible() ? "Gizle" : "Göster";
        }


        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManager.ExitApplication();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreDegistir si = new sifreDegistir();
            si.kullanici_id = kullanici_id;
            si.Show();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void arayuz_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
