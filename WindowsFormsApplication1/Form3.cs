using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        public UserControl1 control;

        public Form3()
        {
            InitializeComponent();
        }
          
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                komut = new OleDbCommand();
                baglantı.Open();
                komut.Connection = baglantı;
                komut.CommandText = "Update Ögrenci set ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',sinif_no='" + textBox4.Text + "',bölüm='" + comboBox1.Text + "',adres='" + textBox5.Text + "',mail='" + textBox6.Text + "',telefon='" + textBox7.Text + "',sifre='" + textBox8.Text + "',durum1='" + textBox9.Text + "',koordinator_ogrt='" + textBox10.Text + "' where ogr_no=" + textBox1.Text + "";
                komut.ExecuteNonQuery();
                baglantı.Close();
                control.griddoldur2();
                this.Hide();               
                MessageBox.Show("Güncelleme işlemi tamamlandı !");
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme işleminde hata ! Boş alan bırakmayınız");
            }
           
        }
    }
}
