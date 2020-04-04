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
    public partial class UserControl2 : UserControl
    {

        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public Form4 frm2;

        public UserControl2()
        {
            InitializeComponent();
            frm2 = new Form4();
            frm2.control = this;
        }

      

        public void griddoldur3()
        {
            if (Form1.durum == "Ögrenci")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from Veli_Bilgileri where ogrenci_gmail = '" + Form1.text + "'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Veli_Bilgileri");
                dataGridView1.DataSource = ds.Tables["Veli_Bilgileri"];
                baglanti.Close();
            }
            else if (Form1.durum == "Ögretmen")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from Veli_Bilgileri where koordinator_ogrt='" + Form1.text + "'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Veli_Bilgileri");
                dataGridView1.DataSource = ds.Tables["Veli_Bilgileri"];
                baglanti.Close();

            }

            else
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from Veli_Bilgileri", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Veli_Bilgileri");
                dataGridView1.DataSource = ds.Tables["Veli_Bilgileri"];
                baglanti.Close();

            }
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            if (Form1.durum == "Ögretmen")
            {
                button1.Visible = false;
            }
            else if (Form1.durum == "Müdür")
            {
                button1.Visible = false;
            }
        
            else if (Form1.durum == "Ögrenci")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }

            griddoldur3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm2.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm2.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm2.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm2.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm2.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm2.textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm2.textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm2.textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm2.textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm2.textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Veli_Bilgileri where Id=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            griddoldur3();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            da = new OleDbDataAdapter("Select * from Veli_Bilgileri where ogrenci_gmail Like '" + textBox2.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Veli_Bilgileri");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Veli_Bilgileri"];
            textBox2.Clear();
        }
    }
}
