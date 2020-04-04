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
    public partial class Form6 : Form
    {

        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        public UserControl4 control;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
            komut = new OleDbCommand();
            baglantı.Open();
            komut.Connection = baglantı;
            komut.CommandText = "Update Ögretmen set ad='" + textBox2.Text + "',soyad='" + textBox3.Text + "',mail='" + textBox4.Text + "',telefon='" + textBox5.Text + "',sifre='" + textBox6.Text + "',bölüm_ad='" + comboBox1.Text + "',durum1='" + textBox7.Text + "' where ogrt_no=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglantı.Close();
            control.griddoldur5();
            this.Hide();

            MessageBox.Show("Güncelleme işlemi tamamlandı !");
        }
    }
}
