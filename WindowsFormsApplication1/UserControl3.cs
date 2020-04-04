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
    public partial class UserControl3 : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        public Form5 frm3;

        public UserControl3()
        {
            InitializeComponent();
            frm3 = new Form5();
            frm3.control = this;
        }

       public void griddoldur4()
        {
            if (Form1.durum == "Ögrenci")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from staj_bilgileri where ogrenci_gmail = '" + Form1.text + "'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "staj_bilgileri");
                dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
                baglanti.Close();
            }
            else if (Form1.durum == "Ögretmen")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from staj_bilgileri where koordinator_ogrt = '" + Form1.text + "'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "staj_bilgileri");
                dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
                baglanti.Close();

            }
            if (Form1.durum == "Müdür")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select * from staj_bilgileri", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "staj_bilgileri");
                dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
                baglanti.Close();
            }
        }


        private void UserControl3_Load(object sender, EventArgs e)
        {
            if (Form1.durum == "Ögretmen")
            {
                button1.Visible = true;
            }
            else if (Form1.durum == "Müdür")
            {
                button1.Visible = false;
            }        
            else if (Form1.durum == "Ögrenci")
            {
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                button3.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }

            griddoldur4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm3.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm3.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm3.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm3.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm3.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm3.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm3.textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm3.comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm3.comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm3.textBox8.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm3.textBox9.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm3.comboBox3.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from staj_bilgileri where ıd=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            griddoldur4();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("Select * from staj_bilgileri where ogrenci_gmail Like '" + textBox2.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "staj_bilgileri");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("Select * from staj_bilgileri where staj_kabul='Onaylandı'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "staj_bilgileri");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("Select * from staj_bilgileri where staj_kabul='Onaylanmadı'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "staj_bilgileri");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["staj_bilgileri"];
        }
    }
}
