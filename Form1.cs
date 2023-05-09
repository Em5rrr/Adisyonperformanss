using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adisyonperformans2
{  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   
        private void Form1_Load(object sender, EventArgs e)
        {        
            if (button1.Enabled == true)
            {
                pictureBox1.Visible = false;
                dataGridView1.Visible = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                checkedListBox1.Enabled = false;
                checkedListBox2.Enabled = false;
                checkedListBox3.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");           
            DataSet ds = new DataSet();
            bagla.Open();    
            if (bagla.State == ConnectionState.Open)
            {
                MessageBox.Show("Database'e bağlantı başarılı.");
            }
            else
            {
                MessageBox.Show("Database'e bağlantı başarısız");
            }
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            dataGridView1.Visible = true;
            checkedListBox1.Enabled = true;
            checkedListBox2.Enabled = true;
            checkedListBox3.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            pictureBox1.Visible = true;               
        }
        private void button2_Click(object sender, EventArgs e)
        {            
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM ICECEK", bagla);
            DataSet ds = new DataSet();
            bagla.Open();
            adp.Fill(ds, "ICECEK");
            dataGridView1.DataSource = ds.Tables["ICECEK"];          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM YANURUN", bagla);
            DataSet ds = new DataSet();
            bagla.Open();
            adp.Fill(ds, "YANURUN");
            dataGridView1.DataSource = ds.Tables["YANURUN"];        
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM ANAYEMEK", bagla);
            DataSet ds = new DataSet();
            bagla.Open();
            adp.Fill(ds, "ANAYEMEK");        
            dataGridView1.DataSource = ds.Tables["ANAYEMEK"];
            dataGridView1.Columns[0].HeaderText = "50gr";
            dataGridView1.Columns[1].HeaderText = "100gr";
            dataGridView1.Columns[2].HeaderText = "200gr";
            dataGridView1.Columns[3].HeaderText = "300gr";
            dataGridView1.Columns[4].HeaderText = "500gr";
            dataGridView1.Columns[5].HeaderText = "700gr";
            dataGridView1.Columns[6].HeaderText = "1000gr";
        }       
        private void button5_Click(object sender, EventArgs e)
        {            
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            bagla.Open();
            SQLiteCommand order = new SQLiteCommand();
            order.Connection = bagla;
            if (textBox1.Text == "KOLA")
            {
                order.CommandText = "INSERT INTO ICECEK (KOLA) VALUES ('" +"x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "FANTA")
            {
                order.CommandText = "INSERT INTO ICECEK (FANTA) VALUES ('" +"x"+ "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "SPRITE")
            {
                order.CommandText = "INSERT INTO ICECEK (SPRITE) VALUES ('" +"x"+ "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "AYRAN")
            {
                order.CommandText = "INSERT INTO ICECEK (AYRAN) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "SALGAM")
            {
                order.CommandText = "INSERT INTO ICECEK (SALGAM) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "SODA")
            {
                order.CommandText = "INSERT INTO ICECEK (SODA) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox1.Text == "SU")
            {
                order.CommandText = "INSERT INTO ICECEK (SU) VALUES ('" +"x"+ "')";
                order.ExecuteNonQuery();
            }           
            else if (textBox1.Text=="")
            { 
                MessageBox.Show("Lütfen Bir İçecek Giriniz");
            }               
            SQLiteConnection bagla1 = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM ICECEK", bagla1);
            DataSet ds = new DataSet();
            bagla1.Open();
            adp.Fill(ds, "ICECEK");
            dataGridView1.DataSource = ds.Tables["ICECEK"];           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            bagla.Open();
            SQLiteCommand order = new SQLiteCommand();
            order.Connection = bagla;
            if (textBox2.Text == "CORBA")
            {
                order.CommandText = "INSERT INTO YANURUN (CORBA) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "SALATA")
            {
                order.CommandText = "INSERT INTO YANURUN (SALATA) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "MEZE")
            {
                order.CommandText = "INSERT INTO YANURUN (MEZE) VALUES ('" +"x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "EKMEK")
            {
                order.CommandText = "INSERT INTO YANURUN (EKMEK) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "PATATES")
            {
                order.CommandText = "INSERT INTO YANURUN (PATATES) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "TATLI")
            {
                order.CommandText = "INSERT INTO YANURUN (TATLI) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "YOGURT")
            {
                order.CommandText = "INSERT INTO YANURUN (YOGURT) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Bir Yan ürün Giriniz");
            }            
            SQLiteConnection bagla1 = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM YANURUN", bagla1);
            DataSet ds = new DataSet();
            bagla1.Open();
            adp.Fill(ds, "YANURUN");
            dataGridView1.DataSource = ds.Tables["YANURUN"];           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            bagla.Open();
            SQLiteCommand order = new SQLiteCommand();
            order.Connection = bagla;
            if (textBox3.Text == "50GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR50) VALUES ('" +"x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "100GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR100) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "200GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR200) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "300GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR300) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "500GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR500) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "700GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR700) VALUES ('" + "x" + "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "1000GR")
            {
                order.CommandText = "INSERT INTO ANAYEMEK (GR1000) VALUES ('" + "x"+ "')";
                order.ExecuteNonQuery();
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Lütfen Bir Miktar Giriniz");
            }
            SQLiteConnection bagla1 = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            SQLiteDataAdapter adp = new SQLiteDataAdapter("SELECT * FROM ANAYEMEK", bagla1);
            DataSet ds = new DataSet();
            bagla1.Open();
            adp.Fill(ds, "ANAYEMEK");
            dataGridView1.DataSource = ds.Tables["ANAYEMEK"];          
            bagla.Close();
            bagla1.Close();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = checkedListBox1.Text;
        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = checkedListBox2.Text;
        }
        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = checkedListBox3.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            button1.Enabled = true;   
            if (button1.Enabled == true)
            {
                dataGridView1.Visible = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                checkedListBox1.Enabled = false;
                checkedListBox2.Enabled = false;
                checkedListBox3.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                pictureBox1.Visible = false;
            }     
            MessageBox.Show("Database ile bağlantınız koparılmıştır.");
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            bagla.Open();
            SQLiteCommand order = new SQLiteCommand();
            order.Connection = bagla;
            order.CommandText = "DELETE FROM ICECEK";
            order.ExecuteNonQuery();
            order.CommandText = "DELETE FROM ANAYEMEK";
            order.ExecuteNonQuery();
            order.CommandText = "DELETE FROM YANURUN";
            order.ExecuteNonQuery();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SQLiteConnection bagla = new SQLiteConnection("Data source=.\\adisyonperformanss.db;Version=3");
            bagla.Open();
            SQLiteCommand order = new SQLiteCommand();
            order.Connection = bagla;
            order.CommandText = "DELETE FROM ICECEK";
            order.ExecuteNonQuery();
            order.CommandText = "DELETE FROM ANAYEMEK";
            order.ExecuteNonQuery();
            order.CommandText = "DELETE FROM YANURUN";
            order.ExecuteNonQuery();
        }
    }
}
