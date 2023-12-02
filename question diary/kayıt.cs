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
    public partial class kayıt : Form
    {
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public kayıt()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text!=string.Empty)
                {
                    string kayit = "insert into kullanici(kullaniciadi,sifre,sifretekrar) values (@kullaniciadi,@sifre,@sifretekrar)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifretekrar", textBox3.Text);

                    if (textBox2.Text != textBox3.Text)
                    {
                        MessageBox.Show("Girilen Şifreler Aynı Değil");
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    else
                    {
                        SqlCommand ac = new SqlCommand("select * from kullanici where kullaniciadi='" + textBox1.Text + "'", con);
                        SqlDataReader ab = ac.ExecuteReader();
                        if (ab.Read())
                        {
                            MessageBox.Show("Bu Kullanıcı Adı Alınmış");
                        }
                        else
                        {
                            ab.Close();
                            {
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla Kayıt Olundu, Giriş Yapabilirsiniz");

                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                            }
                        Form giris = new giris();
                        giris.StartPosition = FormStartPosition.CenterScreen;
                        giris.Show();
                            this.Close();
                            con.Close();
                        }
                    }

                }
                else
                    MessageBox.Show("Tüm kutucukları doldurmalısınız");        
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.StartPosition = FormStartPosition.CenterScreen;
            giris.Show();
            this.Close();
        }
    }
}


