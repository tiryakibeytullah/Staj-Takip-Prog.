namespace WindowsFormsApplication1
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veli_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veli_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veli_yakinligi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_adresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ev_adresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egitim_durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci_gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koordinator_ogrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.kimlik,
            this.veli_ad,
            this.veli_soyad,
            this.veli_yakinligi,
            this.is_adresi,
            this.ev_adresi,
            this.egitim_durumu,
            this.telefon,
            this.ogrenci_gmail,
            this.koordinator_ogrt});
            this.dataGridView1.Location = new System.Drawing.Point(15, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // kimlik
            // 
            this.kimlik.DataPropertyName = "kimlik";
            this.kimlik.HeaderText = "TC Kimlik";
            this.kimlik.Name = "kimlik";
            // 
            // veli_ad
            // 
            this.veli_ad.DataPropertyName = "veli_ad";
            this.veli_ad.HeaderText = "Ad";
            this.veli_ad.Name = "veli_ad";
            // 
            // veli_soyad
            // 
            this.veli_soyad.DataPropertyName = "veli_soyad";
            this.veli_soyad.HeaderText = "Soyad";
            this.veli_soyad.Name = "veli_soyad";
            // 
            // veli_yakinligi
            // 
            this.veli_yakinligi.DataPropertyName = "veli_yakinligi";
            this.veli_yakinligi.HeaderText = "Yakınlık";
            this.veli_yakinligi.Name = "veli_yakinligi";
            // 
            // is_adresi
            // 
            this.is_adresi.DataPropertyName = "is_adresi";
            this.is_adresi.HeaderText = "İş Adresi";
            this.is_adresi.Name = "is_adresi";
            // 
            // ev_adresi
            // 
            this.ev_adresi.DataPropertyName = "ev_adresi";
            this.ev_adresi.HeaderText = "Ev Adresi";
            this.ev_adresi.Name = "ev_adresi";
            // 
            // egitim_durumu
            // 
            this.egitim_durumu.DataPropertyName = "egitim_durumu";
            this.egitim_durumu.HeaderText = "Egitim Durumu";
            this.egitim_durumu.Name = "egitim_durumu";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // ogrenci_gmail
            // 
            this.ogrenci_gmail.DataPropertyName = "ogrenci_gmail";
            this.ogrenci_gmail.HeaderText = "Ögrenci Gmail";
            this.ogrenci_gmail.Name = "ogrenci_gmail";
            // 
            // koordinator_ogrt
            // 
            this.koordinator_ogrt.DataPropertyName = "koordinator_ogrt";
            this.koordinator_ogrt.HeaderText = "Koordinatör Ögretmen";
            this.koordinator_ogrt.Name = "koordinator_ogrt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Düzenleme yapmak için tıklayınız";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(354, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(174, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 107);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gmail";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(70, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(663, 395);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn veli_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn veli_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn veli_yakinligi;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_adresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ev_adresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn egitim_durumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn koordinator_ogrt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}
