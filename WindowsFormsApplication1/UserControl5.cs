using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class UserControl5 : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public UserControl5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Ögrenci (ad,soyad,sinif_no,bölüm,adres,mail,telefon,sifre,durum1,koordinator_ogrt) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox25.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);

                MessageBox.Show("Kayıtınız Başarıyla Tamamlandı !");
            }
            catch (Exception)
            {              
                MessageBox.Show("Hatalı işlem yaptınız, Boş alan bırakmayınız");
                
            }          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {                  
            textBox8.Enabled = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            textBox15.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Ögretmen (ad,soyad,mail,telefon,sifre,bölüm_ad,durum1) values ('" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + comboBox2.Text + "','" + textBox15.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();

                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox15.Clear();              
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);  

                MessageBox.Show("Kayıtınız Başarıyla Tamamlandı !");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem yaptınız, Boş alan bırakmayınız");

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Veli_Bilgileri (kimlik,veli_ad,veli_soyad,veli_yakinligi,is_adresi,ev_adresi,egitim_durumu,telefon,ogrenci_gmail,koordinator_ogrt) values ('" + textBox14.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + comboBox3.Text + "','"+textBox22.Text+"','"+textBox23.Text+"','"+textBox24.Text+ "')";
                komut.ExecuteNonQuery();
                baglanti.Close();

                textBox14.Clear();               
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);

                MessageBox.Show("Kayıtınız Başarıyla Tamamlandı !");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı işlem yaptınız, Boş alan bırakmayınız");

            }
        }
    }
}
