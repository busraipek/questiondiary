using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace question_diary
{
    public partial class giris : Form
    {
        public static string kullaniciadi,sifre;
        public static string id;
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public giris()
        {
            InitializeComponent();
        }

        private void girişbuton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {

                SqlCommand komut = new SqlCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", con);
                SqlDataReader ab = komut.ExecuteReader();
                if (ab.Read())
                {
                    sifre = ab.GetValue(2).ToString();
                    id = ab.GetValue(0).ToString();
                    kullaniciadi = ab.GetValue(1).ToString();
                    this.Hide();
                    arayüz arayüz = new arayüz();
                    arayüz.StartPosition = FormStartPosition.CenterScreen;
                    arayüz.Show();
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış");
                con.Close();
            }
            else
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez");
        }
            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                kayıt kayıt = new kayıt();
                kayıt.StartPosition = FormStartPosition.CenterScreen;
                kayıt.Show();
                this.Close();                
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
