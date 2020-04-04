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
    public partial class Form1 : Form
    {
        public static string text;
        public static string durum;

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        OleDbDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                text = textBox1.Text;
                durum = comboBox1.Text;



                string giris = comboBox1.Text, mail = "1", sifre = "1", durum1 = "1";
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                baglanti.Open();
                komut = new OleDbCommand("Select * from " + giris + " where mail='" + textBox1.Text + "'", baglanti);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    mail = dr["mail"].ToString();
                    sifre = dr["sifre"].ToString();
                    durum1 = dr["durum1"].ToString();
                }
                if (textBox1.Text == mail && textBox2.Text == sifre && comboBox1.Text == durum1)
                {
                    Form1 formkapa = new Form1();
                    formkapa.Close();
                    Form2 ac = new Form2();
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");

            }
           

                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               
                textBox2.PasswordChar = '\0';
            }           
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
