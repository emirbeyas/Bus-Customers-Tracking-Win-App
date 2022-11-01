namespace ServisProje.Views.Araclar
{
    partial class AraclarListView
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ıconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            this.ıconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            this.ıconToolStripButton3 = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnYazdır = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip3.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(582, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Araçlar Listesi";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıconToolStripButton1,
            this.ıconToolStripButton2,
            this.ıconToolStripButton3,
            this.toolStripSeparator3,
            this.btnYazdır});
            this.toolStrip2.Location = new System.Drawing.Point(10, 47);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip2.Size = new System.Drawing.Size(582, 47);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ıconToolStripButton1
            // 
            this.ıconToolStripButton1.AutoSize = false;
            this.ıconToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ıconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ıconToolStripButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ıconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconToolStripButton1.IconSize = 30;
            this.ıconToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ıconToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ıconToolStripButton1.Name = "ıconToolStripButton1";
            this.ıconToolStripButton1.Size = new System.Drawing.Size(32, 32);
            this.ıconToolStripButton1.Text = "Anlaşma Ekle";
            this.ıconToolStripButton1.ToolTipText = "Araç Ekle";
            this.ıconToolStripButton1.Click += new System.EventHandler(this.ıconToolStripButton1_Click);
            // 
            // ıconToolStripButton2
            // 
            this.ıconToolStripButton2.AutoSize = false;
            this.ıconToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ıconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ıconToolStripButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ıconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconToolStripButton2.IconSize = 30;
            this.ıconToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ıconToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ıconToolStripButton2.Name = "ıconToolStripButton2";
            this.ıconToolStripButton2.Size = new System.Drawing.Size(32, 32);
            this.ıconToolStripButton2.Text = "Seçili Üyeyi Sil";
            this.ıconToolStripButton2.ToolTipText = "Seçili Aracı Sil";
            this.ıconToolStripButton2.Click += new System.EventHandler(this.ıconToolStripButton2_Click);
            // 
            // ıconToolStripButton3
            // 
            this.ıconToolStripButton3.AutoSize = false;
            this.ıconToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ıconToolStripButton3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.ıconToolStripButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.ıconToolStripButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconToolStripButton3.IconSize = 30;
            this.ıconToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ıconToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ıconToolStripButton3.Name = "ıconToolStripButton3";
            this.ıconToolStripButton3.Size = new System.Drawing.Size(32, 32);
            this.ıconToolStripButton3.Text = "Seçili Üyeyi Düzenle";
            this.ıconToolStripButton3.ToolTipText = "Seçili Aracı Düzenle";
            this.ıconToolStripButton3.Click += new System.EventHandler(this.ıconToolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripTextBox3});
            this.toolStrip1.Location = new System.Drawing.Point(10, 94);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip1.Size = new System.Drawing.Size(582, 33);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripLabel1.Text = "Personel :";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 20);
            this.toolStripLabel2.Text = "Plaka :";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(46, 20);
            this.toolStripLabel3.Text = "Marka :";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 160);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(582, 315);
            this.dataGridView1.TabIndex = 9;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.toolStripComboBox1});
            this.toolStrip3.Location = new System.Drawing.Point(10, 127);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.toolStrip3.Size = new System.Drawing.Size(582, 33);
            this.toolStrip3.Stretch = true;
            this.toolStrip3.TabIndex = 10;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 20);
            this.toolStripLabel4.Text = "Sırala :";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(200, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // AraclarListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lblTitle);
            this.Name = "AraclarListView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(602, 485);
            this.Load += new System.EventHandler(this.AraclarListView_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private FontAwesome.Sharp.IconToolStripButton ıconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton ıconToolStripButton2;
        private FontAwesome.Sharp.IconToolStripButton ıconToolStripButton3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private FontAwesome.Sharp.IconToolStripButton btnYazdır;
    }
}
