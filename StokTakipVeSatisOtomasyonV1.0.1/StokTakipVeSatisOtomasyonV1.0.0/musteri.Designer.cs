namespace StokTakipVeSatisOtomasyonV1._0._0
{
    partial class musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteri));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_soyAd = new System.Windows.Forms.TextBox();
            this.tx_tel = new System.Windows.Forms.TextBox();
            this.tx_mail = new System.Windows.Forms.TextBox();
            this.dgv_musteri = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteri)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1415, 38);
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
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "MÜŞTERİ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StokTakipVeSatisOtomasyonV1._0._0.Properties.Resources.x_23_512;
            this.pictureBox2.Location = new System.Drawing.Point(1382, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tx_adres);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tx_ad);
            this.groupBox1.Controls.Add(this.tx_soyAd);
            this.groupBox1.Controls.Add(this.tx_tel);
            this.groupBox1.Controls.Add(this.tx_mail);
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(6, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 447);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(13, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Adres";
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(18, 284);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(267, 22);
            this.tx_adres.TabIndex = 5;
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
            this.btn_temizle.Location = new System.Drawing.Point(356, 283);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(169, 56);
            this.btn_temizle.TabIndex = 9;
            this.btn_temizle.Text = "Temizle";
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
            this.btn_guncelle.Location = new System.Drawing.Point(356, 208);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(169, 56);
            this.btn_guncelle.TabIndex = 8;
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
            this.btn_sil.Location = new System.Drawing.Point(356, 134);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(169, 56);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 30);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mail";
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
            this.btn_ekle.Location = new System.Drawing.Point(356, 54);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(169, 56);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "SoyAd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ad";
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(16, 54);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(163, 22);
            this.tx_ad.TabIndex = 1;
            this.tx_ad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kopyalaEngelle_KeyDown);
            this.tx_ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_harf_KeyPress);
            // 
            // tx_soyAd
            // 
            this.tx_soyAd.Location = new System.Drawing.Point(18, 112);
            this.tx_soyAd.Name = "tx_soyAd";
            this.tx_soyAd.Size = new System.Drawing.Size(165, 22);
            this.tx_soyAd.TabIndex = 2;
            this.tx_soyAd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kopyalaEngelle_KeyDown);
            this.tx_soyAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_harf_KeyPress);
            // 
            // tx_tel
            // 
            this.tx_tel.Location = new System.Drawing.Point(16, 168);
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(189, 22);
            this.tx_tel.TabIndex = 3;
            this.tx_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kopyalaEngelle_KeyDown);
            this.tx_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_sayi_KeyPress);
            // 
            // tx_mail
            // 
            this.tx_mail.Location = new System.Drawing.Point(18, 226);
            this.tx_mail.Name = "tx_mail";
            this.tx_mail.Size = new System.Drawing.Size(267, 22);
            this.tx_mail.TabIndex = 4;
            // 
            // dgv_musteri
            // 
            this.dgv_musteri.AllowUserToAddRows = false;
            this.dgv_musteri.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            this.dgv_musteri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_musteri.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_musteri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_musteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musteri.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_musteri.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_musteri.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_musteri.Location = new System.Drawing.Point(575, 51);
            this.dgv_musteri.MultiSelect = false;
            this.dgv_musteri.Name = "dgv_musteri";
            this.dgv_musteri.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_musteri.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_musteri.RowHeadersWidth = 51;
            this.dgv_musteri.RowTemplate.Height = 24;
            this.dgv_musteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_musteri.Size = new System.Drawing.Size(844, 440);
            this.dgv_musteri.TabIndex = 32;
            this.dgv_musteri.SelectionChanged += new System.EventHandler(this.dgv_musteri_SelectionChanged);
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
            // musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1415, 496);
            this.Controls.Add(this.dgv_musteri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musteri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.musteri_FormClosed);
            this.Load += new System.EventHandler(this.musteri_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musteri)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_soyAd;
        private System.Windows.Forms.TextBox tx_tel;
        private System.Windows.Forms.TextBox tx_mail;
        private System.Windows.Forms.DataGridView dgv_musteri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_adres;
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