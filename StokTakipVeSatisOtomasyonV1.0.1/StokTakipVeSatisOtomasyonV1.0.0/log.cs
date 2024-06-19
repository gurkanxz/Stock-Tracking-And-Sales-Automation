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
    public partial class log : Form
    {
        public log()
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
        private void LogGridiDoldur()
        {
            dgv_log.DataSource = vt.Select(@"select l.log_id, l.pcİsmi,l.girisTarih,l.girisSaat,k.kullanici_id,k.Ad+'-'+k.soyAd AdSoyad
            from tbl_log l
            join tbl_kullanici k on k.kullanici_id=l.kullanici_id");
            dgv_log.Columns["log_id"].Visible = false;
            dgv_log.Columns["kullanici_id"].Visible = false;
        }
        private void log_Load(object sender, EventArgs e)
        {
            FormManager.AddForm(this);
            LogGridiDoldur();
        }

        private void log_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.RemoveForm(this);
        }
    }
}
