﻿namespace StokTakipVeSatisOtomasyonV1._0._0
{
    partial class satis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_stokMiktari = new System.Windows.Forms.DataGridView();
            this.cbx_musteri = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_urun = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tx_toplamTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_satisTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_fiyat = new System.Windows.Forms.TextBox();
            this.tx_adet = new System.Windows.Forms.TextBox();
            this.dgv_satis = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stokMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satis)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1483, 38);
            this.panel2.TabIndex = 21;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.arayuz_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "SATIŞ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.x_23_512;
            this.pictureBox2.Location = new System.Drawing.Point(1449, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_stokMiktari);
            this.groupBox1.Controls.Add(this.cbx_musteri);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbx_urun);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tx_toplamTutar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtp_satisTarih);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tx_fiyat);
            this.groupBox1.Controls.Add(this.tx_adet);
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(29, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 539);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv_stokMiktari
            // 
            this.dgv_stokMiktari.AllowUserToAddRows = false;
            this.dgv_stokMiktari.AllowUserToDeleteRows = false;
            this.dgv_stokMiktari.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dgv_stokMiktari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stokMiktari.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stokMiktari.Location = new System.Drawing.Point(35, 21);
            this.dgv_stokMiktari.MultiSelect = false;
            this.dgv_stokMiktari.Name = "dgv_stokMiktari";
            this.dgv_stokMiktari.ReadOnly = true;
            this.dgv_stokMiktari.RowHeadersWidth = 51;
            this.dgv_stokMiktari.RowTemplate.Height = 24;
            this.dgv_stokMiktari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stokMiktari.Size = new System.Drawing.Size(337, 62);
            this.dgv_stokMiktari.TabIndex = 39;
            // 
            // cbx_musteri
            // 
            this.cbx_musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_musteri.FormattingEnabled = true;
            this.cbx_musteri.Location = new System.Drawing.Point(22, 131);
            this.cbx_musteri.Name = "cbx_musteri";
            this.cbx_musteri.Size = new System.Drawing.Size(174, 24);
            this.cbx_musteri.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(17, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 30);
            this.label11.TabIndex = 46;
            this.label11.Text = "Müşteri";
            // 
            // cbx_urun
            // 
            this.cbx_urun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_urun.FormattingEnabled = true;
            this.cbx_urun.Location = new System.Drawing.Point(211, 131);
            this.cbx_urun.Name = "cbx_urun";
            this.cbx_urun.Size = new System.Drawing.Size(174, 24);
            this.cbx_urun.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.AliceBlue;
            this.label10.Location = new System.Drawing.Point(206, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "Ürün";
            // 
            // tx_toplamTutar
            // 
            this.tx_toplamTutar.Enabled = false;
            this.tx_toplamTutar.Location = new System.Drawing.Point(211, 249);
            this.tx_toplamTutar.Name = "tx_toplamTutar";
            this.tx_toplamTutar.Size = new System.Drawing.Size(174, 22);
            this.tx_toplamTutar.TabIndex = 6;
            this.tx_toplamTutar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_yapistirEngel_KeyDown);
            this.tx_toplamTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(206, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "Toplam Tutar";
            // 
            // dtp_satisTarih
            // 
            this.dtp_satisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_satisTarih.Location = new System.Drawing.Point(22, 249);
            this.dtp_satisTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_satisTarih.Name = "dtp_satisTarih";
            this.dtp_satisTarih.Size = new System.Drawing.Size(174, 22);
            this.dtp_satisTarih.TabIndex = 5;
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
            this.btn_temizle.Location = new System.Drawing.Point(214, 386);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(169, 56);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "  Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
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
            this.btn_guncelle.Location = new System.Drawing.Point(214, 306);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(169, 56);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "  Güncelle";
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
            this.btn_sil.Location = new System.Drawing.Point(27, 386);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(169, 56);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(17, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Satış Tarih";
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
            this.btn_ekle.Location = new System.Drawing.Point(27, 306);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(169, 56);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(206, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(17, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Satış Fiyatı";
            // 
            // tx_fiyat
            // 
            this.tx_fiyat.Location = new System.Drawing.Point(22, 191);
            this.tx_fiyat.Name = "tx_fiyat";
            this.tx_fiyat.Size = new System.Drawing.Size(174, 22);
            this.tx_fiyat.TabIndex = 3;
            this.tx_fiyat.TextChanged += new System.EventHandler(this.tx_fiyat_TextChanged);
            this.tx_fiyat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_yapistirEngel_KeyDown);
            this.tx_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // tx_adet
            // 
            this.tx_adet.Location = new System.Drawing.Point(211, 191);
            this.tx_adet.Name = "tx_adet";
            this.tx_adet.Size = new System.Drawing.Size(174, 22);
            this.tx_adet.TabIndex = 4;
            this.tx_adet.TextChanged += new System.EventHandler(this.tx_adet_TextChanged);
            this.tx_adet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_yapistirEngel_KeyDown);
            this.tx_adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // dgv_satis
            // 
            this.dgv_satis.AllowUserToAddRows = false;
            this.dgv_satis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.dgv_satis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_satis.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_satis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_satis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_satis.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_satis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_satis.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_satis.Location = new System.Drawing.Point(472, 52);
            this.dgv_satis.MultiSelect = false;
            this.dgv_satis.Name = "dgv_satis";
            this.dgv_satis.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_satis.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_satis.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.dgv_satis.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_satis.RowTemplate.Height = 24;
            this.dgv_satis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_satis.Size = new System.Drawing.Size(1007, 531);
            this.dgv_satis.TabIndex = 37;
            this.dgv_satis.SelectionChanged += new System.EventHandler(this.dgv_satis_SelectionChanged);
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
            // satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1483, 595);
            this.Controls.Add(this.dgv_satis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "satis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "satis";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.satis_FormClosed);
            this.Load += new System.EventHandler(this.satis_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stokMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_satis)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_musteri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tx_toplamTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_satisTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_fiyat;
        private System.Windows.Forms.TextBox tx_adet;
        private System.Windows.Forms.DataGridView dgv_satis;
        private System.Windows.Forms.ComboBox cbx_urun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_stokMiktari;
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