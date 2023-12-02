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
    public partial class cevap : Form
    {
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public static string kullaniciadi, soru;
        public static int id,son;
        public string gelen;

        public cevap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (textBox1.Text != string.Empty)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.ColumnCount = 1;
                dataGridView1.Columns[0].Width = 100;

                SqlCommand sorgu = new SqlCommand("SELECT soruid,soru FROM soru where soru = '"+label1.Text+"'", con);
                SqlDataReader dr = sorgu.ExecuteReader();
                while (dr.Read())
                {
                    int son = Convert.ToInt32(dr["soruid"]);
                }
                dr.Close();
                    string kayit = "insert into cevap(soruid,id,kullaniciadi,soru,cevap) values (@soruid,@id,@kullaniciadi,@soru,@cevap)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@soruid",son);
                    komut.Parameters.AddWithValue("@id", giris.id);
                    komut.Parameters.AddWithValue("@kullaniciadi", giris.kullaniciadi);
                    komut.Parameters.AddWithValue("@soru", label1.Text);
                    komut.Parameters.AddWithValue("@cevap", giris.kullaniciadi + "  #"+giris.id+"\n"+textBox1.Text+"\n");

                    komut.ExecuteNonQuery();


                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("select id, kullaniciadi, cevap from cevap where soru='"+ label1.Text+"'", con);
                SqlDataReader ab = cmd.ExecuteReader();
                while (ab.Read())
                {
                    dataGridView1.Rows.Add(ab["cevap"].ToString()+"\n");
                }
                textBox1.Clear();
                ab.Close();
                con.Close();
            }
        }

        private void cevap_Load(object sender, EventArgs e)
        {
            con.Open();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            label1.Text = gelen.ToString() ;

            SqlCommand komut = new SqlCommand("select * from cevap where soru='" + label1.Text + "'", con);
            SqlDataReader ab = komut.ExecuteReader();
            while (ab.Read())
            {
                dataGridView1.Rows.Add(ab["cevap"].ToString());
            }
            ab.Close();
            con.Close();
        }
    }
}
