namespace StokTakipVeSatisOtomasyonV1._0._0
{
    partial class stok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_kritik = new System.Windows.Forms.Label();
            this.cbx_urun = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_skt = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_adet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_alisfiyat = new System.Windows.Forms.TextBox();
            this.cbx_firma = new System.Windows.Forms.ComboBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_stokmik = new System.Windows.Forms.TextBox();
            this.tx_kritik = new System.Windows.Forms.TextBox();
            this.dgv_stok = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stok)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1834, 38);
            this.panel2.TabIndex = 20;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "STOK";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.x_23_512;
            this.pictureBox2.Location = new System.Drawing.Point(1804, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_kritik);
            this.groupBox1.Controls.Add(this.cbx_urun);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtp_skt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tx_adet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tx_alisfiyat);
            this.groupBox1.Controls.Add(this.cbx_firma);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tx_stokmik);
            this.groupBox1.Controls.Add(this.tx_kritik);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 649);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_kritik
            // 
            this.lbl_kritik.AutoSize = true;
            this.lbl_kritik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kritik.ForeColor = System.Drawing.Color.Red;
            this.lbl_kritik.Location = new System.Drawing.Point(15, 138);
            this.lbl_kritik.Name = "lbl_kritik";
            this.lbl_kritik.Size = new System.Drawing.Size(0, 18);
            this.lbl_kritik.TabIndex = 48;
            // 
            // cbx_urun
            // 
            this.cbx_urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_urun.FormattingEnabled = true;
            this.cbx_urun.Location = new System.Drawing.Point(18, 108);
            this.cbx_urun.Name = "cbx_urun";
            this.cbx_urun.Size = new System.Drawing.Size(161, 24);
            this.cbx_urun.TabIndex = 1;
            this.cbx_urun.TextChanged += new System.EventHandler(this.cbx_urun_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(13, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 30);
            this.label11.TabIndex = 46;
            this.label11.Text = "Urun";
            // 
            // dtp_skt
            // 
            this.dtp_skt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_skt.Location = new System.Drawing.Point(18, 510);
            this.dtp_skt.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_skt.Name = "dtp_skt";
            this.dtp_skt.Size = new System.Drawing.Size(232, 22);
            this.dtp_skt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(13, 476);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 30);
            this.label9.TabIndex = 42;
            this.label9.Text = "Son Kullanma Tarih";
            // 
            // tx_adet
            // 
            this.tx_adet.Location = new System.Drawing.Point(18, 456);
            this.tx_adet.Name = "tx_adet";
            this.tx_adet.Size = new System.Drawing.Size(161, 22);
            this.tx_adet.TabIndex = 6;
            this.tx_adet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_kritik_KeyDown);
            this.tx_adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(13, 423);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "Adet";
            // 
            // tx_alisfiyat
            // 
            this.tx_alisfiyat.Location = new System.Drawing.Point(18, 389);
            this.tx_alisfiyat.Name = "tx_alisfiyat";
            this.tx_alisfiyat.Size = new System.Drawing.Size(161, 22);
            this.tx_alisfiyat.TabIndex = 5;
            this.tx_alisfiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_kritik_KeyDown);
            this.tx_alisfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // cbx_firma
            // 
            this.cbx_firma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_firma.FormattingEnabled = true;
            this.cbx_firma.Location = new System.Drawing.Point(18, 321);
            this.cbx_firma.Name = "cbx_firma";
            this.cbx_firma.Size = new System.Drawing.Size(163, 24);
            this.cbx_firma.TabIndex = 4;
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_temizle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_temizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_temizle.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.recurring_appointment_32;
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_temizle.Location = new System.Drawing.Point(233, 393);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(169, 56);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(13, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "Alış Fiyat";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_guncelle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_guncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_guncelle.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.available_updates_32;
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_guncelle.Location = new System.Drawing.Point(233, 318);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(169, 56);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_sil.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_sil.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.delete_32;
            this.btn_sil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_sil.Location = new System.Drawing.Point(233, 244);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(169, 56);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(13, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Firma";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_ekle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_ekle.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.add_32;
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_ekle.Location = new System.Drawing.Point(233, 164);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(169, 56);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(13, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "KritikStok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Stok Miktarı";
            // 
            // tx_stokmik
            // 
            this.tx_stokmik.Enabled = false;
            this.tx_stokmik.Location = new System.Drawing.Point(18, 198);
            this.tx_stokmik.Name = "tx_stokmik";
            this.tx_stokmik.Size = new System.Drawing.Size(163, 22);
            this.tx_stokmik.TabIndex = 2;
            this.tx_stokmik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_stokmik_KeyDown);
            this.tx_stokmik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // tx_kritik
            // 
            this.tx_kritik.Location = new System.Drawing.Point(18, 259);
            this.tx_kritik.Name = "tx_kritik";
            this.tx_kritik.Size = new System.Drawing.Size(161, 22);
            this.tx_kritik.TabIndex = 3;
            this.tx_kritik.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_kritik_KeyDown);
            this.tx_kritik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // dgv_stok
            // 
            this.dgv_stok.AllowUserToAddRows = false;
            this.dgv_stok.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.dgv_stok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stok.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stok.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stok.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_stok.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_stok.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_stok.Location = new System.Drawing.Point(427, 38);
            this.dgv_stok.MultiSelect = false;
            this.dgv_stok.Name = "dgv_stok";
            this.dgv_stok.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stok.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_stok.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.dgv_stok.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_stok.RowTemplate.Height = 24;
            this.dgv_stok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stok.Size = new System.Drawing.Size(1407, 643);
            this.dgv_stok.TabIndex = 36;
            this.dgv_stok.SelectionChanged += new System.EventHandler(this.dgv_stok_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ekle,
            this.ts_sil,
            this.ts_guncelle,
            this.temizleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 100);
            // 
            // ts_ekle
            // 
            this.ts_ekle.BackgroundImage = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.add_16;
            this.ts_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_ekle.Name = "ts_ekle";
            this.ts_ekle.Size = new System.Drawing.Size(135, 24);
            this.ts_ekle.Text = "Ekle";
            this.ts_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // ts_sil
            // 
            this.ts_sil.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ts_sil.BackgroundImage = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.delete_16;
            this.ts_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_sil.Name = "ts_sil";
            this.ts_sil.Size = new System.Drawing.Size(135, 24);
            this.ts_sil.Text = "Sil";
            this.ts_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ts_guncelle
            // 
            this.ts_guncelle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ts_guncelle.BackgroundImage = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.available_updates_16;
            this.ts_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_guncelle.Name = "ts_guncelle";
            this.ts_guncelle.Size = new System.Drawing.Size(135, 24);
            this.ts_guncelle.Text = "Güncelle";
            this.ts_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.BackgroundImage = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.recurring_appointment_16;
            this.temizleToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1834, 687);
            this.Controls.Add(this.dgv_stok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stok";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stok_FormClosed);
            this.Load += new System.EventHandler(this.stok_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stok)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_stokmik;
        private System.Windows.Forms.TextBox tx_kritik;
        private System.Windows.Forms.ComboBox cbx_urun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_skt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_adet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_alisfiyat;
        private System.Windows.Forms.ComboBox cbx_firma;
        private System.Windows.Forms.DataGridView dgv_stok;
        private System.Windows.Forms.Label lbl_kritik;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem ts_ekle;
        public System.Windows.Forms.ToolStripMenuItem ts_sil;
        public System.Windows.Forms.ToolStripMenuItem ts_guncelle;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public System.Windows.Forms.Button btn_temizle;
        public System.Windows.Forms.Button btn_guncelle;
        public System.Windows.Forms.Button btn_sil;
        public System.Windows.Forms.Button btn_ekle;
    }
}