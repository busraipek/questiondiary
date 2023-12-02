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
 
    public partial class şifredeğiştir : Form
    {   
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public static string sifre,kullaniciadi;
        public static int id;
        public şifredeğiştir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.StartPosition = FormStartPosition.CenterScreen;
            profil.Show();
            this.Close();
        }

        private void girişbuton_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                SqlCommand komut = new SqlCommand("select * from kullanici where id='" + giris.id + "'and sifre='" + textBox1.Text + "'", con);
                SqlDataReader ab = komut.ExecuteReader();
                if (ab.Read())
                {
                    ab.Close();
                    SqlCommand sifredegistir = new SqlCommand("update kullanici set sifre='" + textBox2.Text + "' ,sifretekrar= '" + textBox2.Text + "'where id='" + giris.id + "'", con); ;
                    DialogResult sonuc = MessageBox.Show("Bilgileri güncellemek istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.Yes)
                    {
                        sifredegistir.ExecuteNonQuery();
                        MessageBox.Show("Şifre güncellendi");
                        this.Close();
                        giris giris = new giris();
                        giris.StartPosition = FormStartPosition.CenterScreen;
                        giris.Show();
                    }
                    con.Close();
                }             
                else
                    MessageBox.Show("Şifre yanlış");
                con.Close();
            }
            else
                MessageBox.Show("Şifre değiştirilmedi");
        }
    }
    }

