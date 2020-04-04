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
    public partial class Form7 : Form
    {
        OleDbConnection baglanti;
        OleDbDataAdapter da;
        OleDbCommand komut;
        DataSet ds;

        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "ADANA")
            {
                comboBox2.Items.Add("Aladağ");
                comboBox2.Items.Add("Ceyhan");
                comboBox2.Items.Add("Çukurova");
                comboBox2.Items.Add("Feke");
                comboBox2.Items.Add("İmamoğlu");
                comboBox2.Items.Add("Karaisalı");
                comboBox2.Items.Add("Karataş");
                comboBox2.Items.Add("Kozan‎");
            }
            else if (comboBox1.Text == "ADIYAMAN")
            {
                comboBox2.Items.Add("Besni");
                comboBox2.Items.Add("Çelikhan");
                comboBox2.Items.Add("Gerger");
                comboBox2.Items.Add("Gölbaşı");
                comboBox2.Items.Add("Çakırhöyük");
                comboBox2.Items.Add("Gölbaşı");
            }
            else if (comboBox1.Text == "AFYONKARAHİSAR")
            {
                comboBox2.Items.Add("Başmakçı");
                comboBox2.Items.Add("Bayat");
                comboBox2.Items.Add("Bolvadin");
                comboBox2.Items.Add("Çay");
                comboBox2.Items.Add("Çobanlar");
                comboBox2.Items.Add("Dazkırı");
            }
            else if (comboBox1.Text == "AĞRI")
            {
                comboBox2.Items.Add("Eleşkirt");
                comboBox2.Items.Add("Hamur");
                comboBox2.Items.Add("Patnos");
                comboBox2.Items.Add("Taşlıçay");
            }
            else if (comboBox1.Text == "AMASYA")
            {
                comboBox2.Items.Add("Göynücek");
                comboBox2.Items.Add("Gümüşhacıköy");
                comboBox2.Items.Add("Hamamözü");
                comboBox2.Items.Add("Merzifon");
                comboBox2.Items.Add("Taşova");
                comboBox2.Items.Add("Suluova");
            }
            else if (comboBox1.Text == "ANKARA")
            {
                comboBox2.Items.Add("Akyurt");
                comboBox2.Items.Add("Altındağ");
                comboBox2.Items.Add("Ayaş");
                comboBox2.Items.Add("Balâ");
                comboBox2.Items.Add("Beypazarı");
                comboBox2.Items.Add("Çamlıdere");
                comboBox2.Items.Add("Çankaya");
                comboBox2.Items.Add("Çubuk");
                comboBox2.Items.Add("Elmadağ");
                comboBox2.Items.Add("Etimesgut");
                comboBox2.Items.Add("Evren");
                comboBox2.Items.Add("Gölbaşı");
                comboBox2.Items.Add("Güdül");
                comboBox2.Items.Add("Haymana");
                comboBox2.Items.Add("Kalecik");
                comboBox2.Items.Add("Keçiören");
                comboBox2.Items.Add("Kızılcahamam");
                comboBox2.Items.Add("Mamak");
            }
            else if (comboBox1.Text == "ANTALYA")
            {
                comboBox2.Items.Add("Akseki");
                comboBox2.Items.Add("Aksu");
                comboBox2.Items.Add("Alanya");
                comboBox2.Items.Add("Demre");
                comboBox2.Items.Add("Döşemealtı");
                comboBox2.Items.Add("Elmalı");
            }
            else if (comboBox1.Text == "ARTVİN")
            {
                comboBox2.Items.Add("Ardanuç");
                comboBox2.Items.Add("Artvin Merkez");
                comboBox2.Items.Add("Arhavi");
                comboBox2.Items.Add("Borçka");
                comboBox2.Items.Add("Hopa");
                comboBox2.Items.Add("Murgul");

            }
            else if (comboBox1.Text == "ARTVİN")
            {
                comboBox2.Items.Add("Bozdoğan");
                comboBox2.Items.Add("Buharkent");
                comboBox2.Items.Add("Çine");
                comboBox2.Items.Add("Didim");
                comboBox2.Items.Add("Efeler");
                comboBox2.Items.Add("Germencik");
            }
            else if (comboBox1.Text == "BALIKESİR")
            {
                comboBox2.Items.Add("Altıeylül");
                comboBox2.Items.Add("Ayvalık");
                comboBox2.Items.Add("Balya");
                comboBox2.Items.Add("Bandırma");
                comboBox2.Items.Add("Bigadiç");
                comboBox2.Items.Add("Burhaniye");
            }
            else if (comboBox1.Text == "BİLECİK")
            {
                comboBox2.Items.Add("Bilecik ");
                comboBox2.Items.Add("Bozüyük");
                comboBox2.Items.Add("Gölpazarı");
                comboBox2.Items.Add("İnhisar");
                comboBox2.Items.Add("Osmaneli");
                comboBox2.Items.Add("Pazaryeri");
            }
            else if (comboBox1.Text == "BİNGÖL")
            {
                comboBox2.Items.Add("Kiğı ");
                comboBox2.Items.Add("Solhan");
                comboBox2.Items.Add("Yayladere");
                comboBox2.Items.Add("Yedisu");
            }
            else if (comboBox1.Text == "BİTLİS")
            {
                comboBox2.Items.Add("Bitlis Merkez");
                comboBox2.Items.Add("Adilcevaz");
                comboBox2.Items.Add("Ahlat");
                comboBox2.Items.Add("Güroymak");
                comboBox2.Items.Add("Hizan");
                comboBox2.Items.Add("Mutki");
            }
            else if (comboBox1.Text == "BOLU")
            {
                comboBox2.Items.Add("Dörtdivan");
                comboBox2.Items.Add("Gerede");
                comboBox2.Items.Add("Göynük");
                comboBox2.Items.Add("Mudurnu");
                comboBox2.Items.Add("Seben");
                comboBox2.Items.Add("Düzce");
            }
            else if (comboBox1.Text == "BURDUR")
            {
                comboBox2.Items.Add("Burdur Merkez");
                comboBox2.Items.Add("Ağlasun");
                comboBox2.Items.Add("Altınyayla");
                comboBox2.Items.Add("Bucak");
                comboBox2.Items.Add("Çavdır");
                comboBox2.Items.Add("Çeltikçi");
            }
            else if (comboBox1.Text == "BURSA")
            {
                comboBox2.Items.Add("Büyükorhan");
                comboBox2.Items.Add("Gemlik");
                comboBox2.Items.Add("Gürsu");
                comboBox2.Items.Add("Harmancık");
            }
            else if (comboBox1.Text == "ÇANAKKALE")
            {
                comboBox2.Items.Add("Bayramiç");
                comboBox2.Items.Add("Biga");
                comboBox2.Items.Add("Bozcaada");
                comboBox2.Items.Add("Çan");
                comboBox2.Items.Add("Eceabat");
                comboBox2.Items.Add("Gelibolu");
            }
            else if (comboBox1.Text == "ÇANKIRI")
            {
                comboBox2.Items.Add("Atkaracalar");
                comboBox2.Items.Add("Korgun");
                comboBox2.Items.Add("Çerkeş");
                comboBox2.Items.Add("Eldivan");
                comboBox2.Items.Add("Ilgaz");
                comboBox2.Items.Add("Kızılırmak");
            }
            else if (comboBox1.Text == "ÇORUM")
            {
                comboBox2.Items.Add("Alaca");
                comboBox2.Items.Add("Bayat");
                comboBox2.Items.Add("Boğazkale");
                comboBox2.Items.Add("Dodurga");
                comboBox2.Items.Add("İskilip");
                comboBox2.Items.Add("Laçin");
            }
            else if (comboBox1.Text == "DENİZLİ")
            {
                comboBox2.Items.Add("Acıpayam");
                comboBox2.Items.Add("Babadağ");
                comboBox2.Items.Add("Baklan");
                comboBox2.Items.Add("Beyağaç");
                comboBox2.Items.Add("Bozkurt");
                comboBox2.Items.Add("Çal");
            }
            else if (comboBox1.Text == "DİYARBAKIR")
            {
                comboBox2.Items.Add("Bağlar");
                comboBox2.Items.Add("Bismil");
                comboBox2.Items.Add("Çermik");
                comboBox2.Items.Add("Dicle");
                comboBox2.Items.Add("Eğil");
                comboBox2.Items.Add("Ergani");
            }
            else if (comboBox1.Text == "EDİRNE")
            {
                comboBox2.Items.Add("Enez");
                comboBox2.Items.Add("Havsa");
                comboBox2.Items.Add("Keşan");
                comboBox2.Items.Add("Lalapaşa");
                comboBox2.Items.Add("Meriç");
                comboBox2.Items.Add("Süloğlu");
            }
            else if (comboBox1.Text == "ELAZIĞ")
            {
                comboBox2.Items.Add("Ağın");
                comboBox2.Items.Add("Alacakaya");
                comboBox2.Items.Add("Arıcak");
                comboBox2.Items.Add("Karakoçan");
                comboBox2.Items.Add("Keban");
                comboBox2.Items.Add("Kovancılar");
            }
            else if (comboBox1.Text == "ERZİNCAN")
            {
                comboBox2.Items.Add("Çayırlı");
                comboBox2.Items.Add("İliç");
                comboBox2.Items.Add("Kemah");
                comboBox2.Items.Add("Otlukbeli");
                comboBox2.Items.Add("Tercan");
                comboBox2.Items.Add("Refahiye");
            }
            else if (comboBox1.Text == "ERZURUM")
            {
                comboBox2.Items.Add("Aşkale");
                comboBox2.Items.Add("Aziziye");
                comboBox2.Items.Add("Çat");
                comboBox2.Items.Add("Hınıs");
            }
            else if (comboBox1.Text == "ESKİŞEHİR")
            {
                comboBox2.Items.Add("Alpu");
                comboBox2.Items.Add("Beylikova");
                comboBox2.Items.Add("Çifteler");
                comboBox2.Items.Add("Günyüzü");
                comboBox2.Items.Add("İnönü");
                comboBox2.Items.Add("Mihalgazi");
            }
            else if (comboBox1.Text == "İSTANBUL")
            {
                comboBox2.Items.Add("Adalar");
                comboBox2.Items.Add("Arnavutköy");
                comboBox2.Items.Add("Ataşehir");
                comboBox2.Items.Add("Bağcılar");
                comboBox2.Items.Add("Avcılar");
                comboBox2.Items.Add("Bahçelievler");
                comboBox2.Items.Add("Bakırköy");
                comboBox2.Items.Add("Başakşehir");
                comboBox2.Items.Add("Bayrampaşa");
                comboBox2.Items.Add("Beşiktaş");
                comboBox2.Items.Add("Beykoz");
                comboBox2.Items.Add("Beylikdüzü");
                comboBox2.Items.Add("Esenyurt");
                comboBox2.Items.Add("Eyüp");
                comboBox2.Items.Add("Fatih");
                comboBox2.Items.Add("Gaziosmanpaşa");
                comboBox2.Items.Add("Güngören");
                comboBox2.Items.Add("Kadıköy");
                comboBox2.Items.Add("Küçükçekmece");
                comboBox2.Items.Add("Kartal");
                comboBox2.Items.Add("Sancaktepe");
                comboBox2.Items.Add("Sarıyer");
                comboBox2.Items.Add("Silivri");
                comboBox2.Items.Add("Sultanbeyli");
            }
            else if (comboBox1.Text == "İZMİR")
            {
                comboBox2.Items.Add("Aliağa");
                comboBox2.Items.Add("Balçova");
                comboBox2.Items.Add("Bayındır");
                comboBox2.Items.Add("Bayraklı");
                comboBox2.Items.Add("Bergama");
                comboBox2.Items.Add("Beydağ");
                comboBox2.Items.Add("Bornova");
                comboBox2.Items.Add("Buca");
            }
            else if (comboBox1.Text == "ORDU")
            {
                comboBox2.Items.Add("Akkuş");
                comboBox2.Items.Add("Altınordu");
                comboBox2.Items.Add("Aybastı");
                comboBox2.Items.Add("Çamaş");
                comboBox2.Items.Add("Çatalpınar");
                comboBox2.Items.Add("Çaybaşı");
                comboBox2.Items.Add("Gölköy");
                comboBox2.Items.Add("Fatsa");
            }
            else if (comboBox1.Text == "RİZE")
            {
                comboBox2.Items.Add("Ardeşen");
                comboBox2.Items.Add("Çamlıhemşin");
                comboBox2.Items.Add("Çayeli");
                comboBox2.Items.Add("Derepazarı");
                comboBox2.Items.Add("Fındıklı");
                comboBox2.Items.Add("Güneysu");
                comboBox2.Items.Add("Hemşin");

            }
            else if (comboBox1.Text == "TRABZON")
            {
                comboBox2.Items.Add("Akçaabat");
                comboBox2.Items.Add("Araklı");
                comboBox2.Items.Add("Beşikdüzü");
                comboBox2.Items.Add("Arsin");

            }
            else if (comboBox1.Text == "YALOVA")
            {
                comboBox2.Items.Add("Yalova Merkez");
                comboBox2.Items.Add("Armutlu");
                comboBox2.Items.Add("Altınova");
                comboBox2.Items.Add("Çiftlikköy");
                comboBox2.Items.Add("Fındıklı");
                comboBox2.Items.Add("Çınarcık");
                comboBox2.Items.Add("Termal");

            }
            else if (comboBox1.Text == "OSMANİYE")
            {
                comboBox2.Items.Add("Osmaniye Merkez");
                comboBox2.Items.Add("Bahçe");
                comboBox2.Items.Add("Düziçi");
                comboBox2.Items.Add("Hasanbeyli");
                comboBox2.Items.Add("Kadirli");
                comboBox2.Items.Add("Sumbas");
                comboBox2.Items.Add("Toprakkale");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=uygulama1.accdb");
                komut = new OleDbCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "insert into staj_bilgileri (isyeri_ad,sahibi,isyeri_yetkilisi,is_telefon,e_mail,isyeri_adresi,il,ilçe,ogrenci_gmail,koordinator_ogrt,staj_kabul) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox3.Text + "')";
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
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);

                MessageBox.Show("Kayıtınız Başarıyla Tamamlandı !");
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt İşleminde Hata ! Boş Alan Bırakmayınız");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        { 
           
        }
    }
}
