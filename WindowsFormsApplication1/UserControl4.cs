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
    public partial class UserControl4 : UserControl
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public Form6 frm4;

        public UserControl4()
        {
            InitializeComponent();
            frm4 = new Form6();
            frm4.control = this;
        }

        public void griddoldur5()
        {
            if (Form1.durum == "Ögretmen")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select*from Ögretmen where mail='" + Form1.text + "'", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Ögretmen");
                dataGridView1.DataSource = ds.Tables["Ögretmen"];
                baglanti.Close();
            }
            else if (Form1.durum == "Müdür")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select*from Ögretmen", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Ögretmen");
                dataGridView1.DataSource = ds.Tables["Ögretmen"];
                baglanti.Close();
            }
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            griddoldur5();
            if (Form1.durum == "Ögrenci")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }
            else if (Form1.durum == "Ögretmen")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm4.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm4.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm4.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm4.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm4.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm4.textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();           
            frm4.comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm4.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Ögretmen where ogrt_no=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            griddoldur5();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("Select * from Ögretmen where mail Like '" + textBox2.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Ögretmen");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Ögretmen"];
        }
    }
}
