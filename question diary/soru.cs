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
    public partial class soru : Form
    {
        public static string kullaniciadi;
        public static int id;
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public soru()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (textBox1.Text != string.Empty)
            {

                string kayit = "insert into soru(id,kullaniciadi,soru) values (@id,@kullaniciadi,@soru)";
                SqlCommand komut = new SqlCommand(kayit, con);

                komut.Parameters.AddWithValue("@id", giris.id);
                komut.Parameters.AddWithValue("@kullaniciadi", giris.kullaniciadi.ToString()) ;
                komut.Parameters.AddWithValue("@soru", textBox1.Text);
                komut.ExecuteNonQuery();
                              
                
                this.Close();
                con.Close();
            }
            else
                MessageBox.Show("Soru yok");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

