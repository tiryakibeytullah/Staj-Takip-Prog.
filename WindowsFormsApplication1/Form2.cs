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
    
    public partial class Form2 : Form
    {
        
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 asd = new UserControl1();
            panel1.Controls.Add(asd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 asd = new UserControl2();
            panel1.Controls.Add(asd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 asd = new UserControl3();
            panel1.Controls.Add(asd);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Form1.durum=="Ögrenci")
            {                
                button4.Visible = false;                           
                button6.Visible = false;
            }
            else if (Form1.durum == "Ögretmen")
            {
                button6.Visible = false;
            }
                          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl4 asd = new UserControl4();
            panel1.Controls.Add(asd);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl5 asd = new UserControl5();
            panel1.Controls.Add(asd);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToShortDateString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult sor;
            sor = MessageBox.Show("Çıkış Yapmak İstiyor Musunuz ?","Çık",MessageBoxButtons.YesNo);
            if (sor==DialogResult.Yes)
            {
                Form1 ac = new Form1();
                ac.Show();
                this.Hide();
            }
           
        }
    }
}
