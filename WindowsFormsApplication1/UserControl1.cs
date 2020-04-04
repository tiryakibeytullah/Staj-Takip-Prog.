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
    public partial class UserControl1 : UserControl
    {           
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;
        public Form3 frm;
        
        public UserControl1()
        {
            InitializeComponent();
            frm = new Form3();
            frm.control = this;
        }

       
        public  void griddoldur2()
        {
            if (Form1.durum == "Ögretmen")
            {
              baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
              da = new OleDbDataAdapter("Select*from Ögrenci where koordinator_ogrt='" + Form1.text + "'", baglanti);
              ds = new DataSet();
              da.Fill(ds, "Ögrenci");
              dataGridView1.DataSource=ds.Tables["Ögrenci"];
              baglanti.Close();   

            }

            else if (Form1.durum == "Ögrenci")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select*from Ögrenci where mail='" + Form1.text + "'" , baglanti);
                ds = new DataSet();
                da.Fill(ds, "Ögrenci");
                dataGridView1.DataSource = ds.Tables["Ögrenci"];
                baglanti.Close();
                 
            }

            if (Form1.durum == "Müdür")
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                da = new OleDbDataAdapter("Select*from Ögrenci ", baglanti);
                ds = new DataSet();
                da.Fill(ds, "Ögrenci");
                dataGridView1.DataSource = ds.Tables["Ögrenci"];
                baglanti.Close();
            }


        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
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
            griddoldur2();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {      
            frm.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.textBox9.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.textBox10.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "delete from Ögrenci where ogr_no="+textBox1.Text+"";
            komut.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            griddoldur2();
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            da = new OleDbDataAdapter("Select * from Ögrenci where mail Like '" + textBox2.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Ögrenci");
            baglanti.Close();
            dataGridView1.DataSource = ds.Tables["Ögrenci"];
        }
    }
}
