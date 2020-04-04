namespace WindowsFormsApplication1
{
    partial class UserControl3
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
            this.ıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeri_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sahibi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeri_yetkilisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isyeri_adresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenci_gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staj_kabul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıd,
            this.isyeri_ad,
            this.sahibi,
            this.isyeri_yetkilisi,
            this.is_telefon,
            this.e_mail,
            this.isyeri_adresi,
            this.il,
            this.ilçe,
            this.ogrenci_gmail,
            this.staj_kabul});
            this.dataGridView1.Location = new System.Drawing.Point(21, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // ıd
            // 
            this.ıd.DataPropertyName = "ıd";
            this.ıd.HeaderText = "Id";
            this.ıd.Name = "ıd";
            // 
            // isyeri_ad
            // 
            this.isyeri_ad.DataPropertyName = "isyeri_ad";
            this.isyeri_ad.HeaderText = "İş Yeri Adı";
            this.isyeri_ad.Name = "isyeri_ad";
            // 
            // sahibi
            // 
            this.sahibi.DataPropertyName = "sahibi";
            this.sahibi.HeaderText = "İş Yeri Sahibi";
            this.sahibi.Name = "sahibi";
            // 
            // isyeri_yetkilisi
            // 
            this.isyeri_yetkilisi.DataPropertyName = "isyeri_yetkilisi";
            this.isyeri_yetkilisi.HeaderText = "İş Yeri Yetkilisi";
            this.isyeri_yetkilisi.Name = "isyeri_yetkilisi";
            // 
            // is_telefon
            // 
            this.is_telefon.DataPropertyName = "is_telefon";
            this.is_telefon.HeaderText = "İş Yeri Telefon";
            this.is_telefon.Name = "is_telefon";
            // 
            // e_mail
            // 
            this.e_mail.DataPropertyName = "e_mail";
            this.e_mail.HeaderText = "E-Mail";
            this.e_mail.Name = "e_mail";
            // 
            // isyeri_adresi
            // 
            this.isyeri_adresi.DataPropertyName = "isyeri_adresi";
            this.isyeri_adresi.HeaderText = "İş Yeri Adresi";
            this.isyeri_adresi.Name = "isyeri_adresi";
            // 
            // il
            // 
            this.il.DataPropertyName = "il";
            this.il.HeaderText = "İl";
            this.il.Name = "il";
            // 
            // ilçe
            // 
            this.ilçe.DataPropertyName = "ilçe";
            this.ilçe.HeaderText = "İlçe";
            this.ilçe.Name = "ilçe";
            // 
            // ogrenci_gmail
            // 
            this.ogrenci_gmail.DataPropertyName = "ogrenci_gmail";
            this.ogrenci_gmail.HeaderText = "Giden Ögrenci Gmail";
            this.ogrenci_gmail.Name = "ogrenci_gmail";
            // 
            // staj_kabul
            // 
            this.staj_kabul.DataPropertyName = "staj_kabul";
            this.staj_kabul.HeaderText = "Staj Durumu";
            this.staj_kabul.Name = "staj_kabul";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 50);
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
            this.groupBox1.Location = new System.Drawing.Point(351, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 100);
            this.groupBox1.TabIndex = 3;
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
            this.button2.Location = new System.Drawing.Point(69, 71);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ögrenci Staj Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(171, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 96);
            this.groupBox2.TabIndex = 5;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(530, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Onaylanan";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(607, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Onaylanmayan";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(730, 419);
            this.Load += new System.EventHandler(this.UserControl3_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn isyeri_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sahibi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isyeri_yetkilisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn isyeri_adresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn il;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenci_gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn staj_kabul;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
