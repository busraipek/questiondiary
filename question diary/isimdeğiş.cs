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
    public partial class isimdeğiş : Form
    {
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public static string kullaniciadi;
        public static int id; 
        public isimdeğiş()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            if (textBox1.Text != string.Empty)
            {
                SqlCommand addegistir = new SqlCommand("update kullanici set kullaniciadi='" + textBox1.Text + "'where id='" + giris.id + "'", con);
                SqlCommand addegistir2 = new SqlCommand("update soru set kullaniciadi='" + textBox1.Text + "'where id='" + giris.id + "'", con);

                DialogResult sonuc = MessageBox.Show("Bilgileri güncellemek istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    addegistir.ExecuteNonQuery();
                    addegistir2.ExecuteNonQuery();

                    MessageBox.Show("Ad güncellendi");
                    giris giris = new giris();
                    giris.StartPosition = FormStartPosition.CenterScreen;
                    giris.Show();
                    this.Close();
                }

                con.Close();
            }
            else
                MessageBox.Show("Ad girin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.StartPosition = FormStartPosition.CenterScreen;
            profil.Show();
            this.Close();
            
        }
    }
}
