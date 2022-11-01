namespace ServisProje.Views.Yedekleme
{
    partial class YedeklemeView
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ıconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.gOREVLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yETKİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEkle = new FontAwesome.Sharp.IconToolStripButton();
            this.btnSil = new FontAwesome.Sharp.IconToolStripButton();
            this.btnDuzenle = new FontAwesome.Sharp.IconToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblIceAktarTabloAdı = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDosyaYol = new System.Windows.Forms.TextBox();
            this.btnIceAktar = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDısaAktar = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.cbxTablo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnYedektenDon = new System.Windows.Forms.Button();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 35);
            this.tabControl1.Location = new System.Drawing.Point(10, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 509);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EKLE/SİL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 413);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıconDropDownButton1,
            this.toolStripSeparator1,
            this.btnEkle,
            this.btnSil,
            this.btnDuzenle});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip1.Size = new System.Drawing.Size(696, 47);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ıconDropDownButton1
            // 
            this.ıconDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ıconDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOREVLERToolStripMenuItem,
            this.yETKİLERToolStripMenuItem});
            this.ıconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ıconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.ıconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ıconDropDownButton1.Name = "ıconDropDownButton1";
            this.ıconDropDownButton1.Size = new System.Drawing.Size(43, 34);
            this.ıconDropDownButton1.Text = "ıconDropDownButton1";
            // 
            // gOREVLERToolStripMenuItem
            // 
            this.gOREVLERToolStripMenuItem.Name = "gOREVLERToolStripMenuItem";
            this.gOREVLERToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.gOREVLERToolStripMenuItem.Text = "GOREVLER";
            this.gOREVLERToolStripMenuItem.Click += new System.EventHandler(this.gOREVLERToolStripMenuItem_Click);
            // 
            // yETKİLERToolStripMenuItem
            // 
            this.yETKİLERToolStripMenuItem.Name = "yETKİLERToolStripMenuItem";
            this.yETKİLERToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.yETKİLERToolStripMenuItem.Text = "YETKİLER";
            this.yETKİLERToolStripMenuItem.Click += new System.EventHandler(this.yETKİLERToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnEkle
            // 
            this.btnEkle.AutoSize = false;
            this.btnEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEkle.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnEkle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnEkle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEkle.IconSize = 30;
            this.btnEkle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(32, 32);
            this.btnEkle.Text = "Ekle";
            this.btnEkle.ToolTipText = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.AutoSize = false;
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnSil.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnSil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSil.IconSize = 30;
            this.btnSil.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(32, 32);
            this.btnSil.Text = "Sil";
            this.btnSil.ToolTipText = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.AutoSize = false;
            this.btnDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzenle.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnDuzenle.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDuzenle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDuzenle.IconSize = 30;
            this.btnDuzenle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(32, 32);
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.ToolTipText = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.lblIceAktarTabloAdı);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage2.Size = new System.Drawing.Size(702, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İÇE AKTAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(10, 131);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(682, 325);
            this.dataGridView2.TabIndex = 8;
            // 
            // lblIceAktarTabloAdı
            // 
            this.lblIceAktarTabloAdı.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIceAktarTabloAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIceAktarTabloAdı.Location = new System.Drawing.Point(10, 91);
            this.lblIceAktarTabloAdı.Name = "lblIceAktarTabloAdı";
            this.lblIceAktarTabloAdı.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblIceAktarTabloAdı.Size = new System.Drawing.Size(682, 40);
            this.lblIceAktarTabloAdı.TabIndex = 4;
            this.lblIceAktarTabloAdı.Text = "Tablo Adı :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDosyaYol);
            this.panel1.Controls.Add(this.btnIceAktar);
            this.panel1.Controls.Add(this.btnAc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 81);
            this.panel1.TabIndex = 0;
            // 
            // txtDosyaYol
            // 
            this.txtDosyaYol.Location = new System.Drawing.Point(89, 21);
            this.txtDosyaYol.Name = "txtDosyaYol";
            this.txtDosyaYol.ReadOnly = true;
            this.txtDosyaYol.Size = new System.Drawing.Size(288, 20);
            this.txtDosyaYol.TabIndex = 7;
            // 
            // btnIceAktar
            // 
            this.btnIceAktar.Enabled = false;
            this.btnIceAktar.Location = new System.Drawing.Point(464, 19);
            this.btnIceAktar.Name = "btnIceAktar";
            this.btnIceAktar.Size = new System.Drawing.Size(75, 23);
            this.btnIceAktar.TabIndex = 5;
            this.btnIceAktar.Text = "İçe Aktar";
            this.btnIceAktar.UseVisualStyleBackColor = true;
            this.btnIceAktar.Click += new System.EventHandler(this.btnIceAktar_Click);
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(383, 19);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(75, 23);
            this.btnAc.TabIndex = 6;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dosya Yolu :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage3.Size = new System.Drawing.Size(702, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DIŞA AKTAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(10, 131);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(682, 325);
            this.dataGridView3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label2.Size = new System.Drawing.Size(682, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tablo Adı :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDısaAktar);
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.cbxTablo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 81);
            this.panel2.TabIndex = 9;
            // 
            // btnDısaAktar
            // 
            this.btnDısaAktar.Enabled = false;
            this.btnDısaAktar.Location = new System.Drawing.Point(355, 18);
            this.btnDısaAktar.Name = "btnDısaAktar";
            this.btnDısaAktar.Size = new System.Drawing.Size(75, 23);
            this.btnDısaAktar.TabIndex = 5;
            this.btnDısaAktar.Text = "Dışa Aktar";
            this.btnDısaAktar.UseVisualStyleBackColor = true;
            this.btnDısaAktar.Click += new System.EventHandler(this.btnDısaAktar_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(274, 18);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // cbxTablo
            // 
            this.cbxTablo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTablo.FormattingEnabled = true;
            this.cbxTablo.Items.AddRange(new object[] {
            "VIEW_ANLASMALARVEGUNLER"});
            this.cbxTablo.Location = new System.Drawing.Point(66, 20);
            this.cbxTablo.Name = "cbxTablo";
            this.cbxTablo.Size = new System.Drawing.Size(202, 21);
            this.cbxTablo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tablo :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnYedektenDon);
            this.tabPage4.Controls.Add(this.btnYedekle);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(702, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "YEDEKLE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnYedektenDon
            // 
            this.btnYedektenDon.Location = new System.Drawing.Point(202, 62);
            this.btnYedektenDon.Name = "btnYedektenDon";
            this.btnYedektenDon.Size = new System.Drawing.Size(111, 43);
            this.btnYedektenDon.TabIndex = 3;
            this.btnYedektenDon.Text = "Yedekten Dön";
            this.btnYedektenDon.UseVisualStyleBackColor = true;
            this.btnYedektenDon.Click += new System.EventHandler(this.btnYedektenDon_Click);
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(51, 62);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(111, 43);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // YedeklemeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "YedeklemeView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(730, 570);
            this.Load += new System.EventHandler(this.YedeklemeView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconDropDownButton ıconDropDownButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconToolStripButton btnEkle;
        private FontAwesome.Sharp.IconToolStripButton btnSil;
        private FontAwesome.Sharp.IconToolStripButton btnDuzenle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripMenuItem gOREVLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yETKİLERToolStripMenuItem;
        private System.Windows.Forms.Label lblIceAktarTabloAdı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDosyaYol;
        private System.Windows.Forms.Button btnIceAktar;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDısaAktar;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox cbxTablo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYedektenDon;
        private System.Windows.Forms.Button btnYedekle;
    }
}
