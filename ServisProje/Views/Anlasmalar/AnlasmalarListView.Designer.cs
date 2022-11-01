namespace ServisProje.Views.Anlasmalar
{
    partial class AnlasmalarListView
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEkle = new FontAwesome.Sharp.IconToolStripButton();
            this.btnSil = new FontAwesome.Sharp.IconToolStripButton();
            this.btnDuzenle = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYazdır = new FontAwesome.Sharp.IconToolStripButton();
            this.SilinmisGunler = new FontAwesome.Sharp.IconToolStripButton();
            this.SilinmisAnlasmalar = new FontAwesome.Sharp.IconToolStripButton();
            this.ıconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtAd = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(654, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Anlaşmalar Listesi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEkle,
            this.btnSil,
            this.btnDuzenle,
            this.toolStripSeparator1,
            this.btnYazdır,
            this.SilinmisGunler,
            this.SilinmisAnlasmalar,
            this.ıconToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(10, 47);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip1.Size = new System.Drawing.Size(654, 47);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnEkle.Text = "Anlaşma Ekle";
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
            this.btnSil.Text = "Seçili Üyeyi Sil";
            this.btnSil.ToolTipText = "Seçili Anlaşmayı Sil";
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
            this.btnDuzenle.Text = "Seçili Üyeyi Düzenle";
            this.btnDuzenle.ToolTipText = "Seçili Anlaşmayı Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btnYazdır
            // 
            this.btnYazdır.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYazdır.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnYazdır.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btnYazdır.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnYazdır.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(34, 34);
            this.btnYazdır.Text = "Listeyi Yazdır";
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // SilinmisGunler
            // 
            this.SilinmisGunler.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SilinmisGunler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SilinmisGunler.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.SilinmisGunler.IconColor = System.Drawing.Color.DimGray;
            this.SilinmisGunler.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SilinmisGunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SilinmisGunler.Name = "SilinmisGunler";
            this.SilinmisGunler.Size = new System.Drawing.Size(34, 34);
            this.SilinmisGunler.Text = "Silinmiş Günler";
            this.SilinmisGunler.Click += new System.EventHandler(this.ıconToolStripButton1_Click);
            // 
            // SilinmisAnlasmalar
            // 
            this.SilinmisAnlasmalar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SilinmisAnlasmalar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SilinmisAnlasmalar.IconChar = FontAwesome.Sharp.IconChar.History;
            this.SilinmisAnlasmalar.IconColor = System.Drawing.Color.DimGray;
            this.SilinmisAnlasmalar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SilinmisAnlasmalar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SilinmisAnlasmalar.Name = "SilinmisAnlasmalar";
            this.SilinmisAnlasmalar.Size = new System.Drawing.Size(34, 34);
            this.SilinmisAnlasmalar.Text = "Silinmiş Anlaşmalar";
            this.SilinmisAnlasmalar.Click += new System.EventHandler(this.EskiAnlasmalar_Click);
            // 
            // ıconToolStripButton1
            // 
            this.ıconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ıconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.ıconToolStripButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(239)))));
            this.ıconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ıconToolStripButton1.Name = "ıconToolStripButton1";
            this.ıconToolStripButton1.Size = new System.Drawing.Size(34, 34);
            this.ıconToolStripButton1.Text = "Listeyi Yazdır";
            this.ıconToolStripButton1.ToolTipText = "Seçilen Anlaşma Detayı";
            this.ıconToolStripButton1.Click += new System.EventHandler(this.ıconToolStripButton1_Click_1);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtAd,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripComboBox1});
            this.toolStrip2.Location = new System.Drawing.Point(10, 94);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip2.Size = new System.Drawing.Size(654, 33);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 20);
            this.toolStripLabel1.Text = "Tanım :";
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(76, 23);
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 20);
            this.toolStripLabel2.Text = "Plaka :";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(76, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 20);
            this.toolStripLabel3.Text = "Sırala :";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(200, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(654, 409);
            this.dataGridView1.TabIndex = 8;
            // 
            // AnlasmalarListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnlasmalarListView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(674, 546);
            this.Load += new System.EventHandler(this.AnlasmalarListView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnEkle;
        private FontAwesome.Sharp.IconToolStripButton btnSil;
        private FontAwesome.Sharp.IconToolStripButton btnDuzenle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconToolStripButton btnYazdır;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtAd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private FontAwesome.Sharp.IconToolStripButton SilinmisAnlasmalar;
        private FontAwesome.Sharp.IconToolStripButton SilinmisGunler;
        private FontAwesome.Sharp.IconToolStripButton ıconToolStripButton1;
    }
}
