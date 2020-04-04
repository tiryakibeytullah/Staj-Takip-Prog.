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
    public partial class Form4 : Form
    {
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        public UserControl2 control;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
            komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "Update Veli_Bilgileri set kimlik='" + textBox2.Text + "',veli_ad='" + textBox3.Text + "',veli_soyad='" + textBox4.Text + "',veli_yakinligi='" + textBox5.Text + "',is_adresi='" + textBox6.Text + "',ev_adresi='" + textBox7.Text + "',egitim_durumu='" + textBox8.Text + "',telefon='" + textBox9.Text + "',ogrenci_gmail='" + textBox10.Text + "',koordinator_ogrt='" + textBox11.Text + "' where Id=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglantı.Close();
            control.griddoldur3();
            this.Hide();

            MessageBox.Show("Güncelleme işlemi tamamlandı !");
        }
    }
}
