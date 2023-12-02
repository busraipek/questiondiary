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
    public partial class profil : Form
    {
        public static string kullaniciadi,sifre,isim,gelen;
        public static int id;
        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {

            con.Open();
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = " ";
            dataGridView2.Columns[0].Width = 100;
            dataGridView2.RowTemplate.Height = 50;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            SqlCommand cmd = new SqlCommand("select kullaniciadi, soru from soru where id='" + giris.id + "' order by soruid desc", con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr["soru"].ToString()+"\n");
                label5.Text = dr["kullaniciadi"].ToString() + "   #" + giris.id.ToString() ;
            }
            dataGridView2.ClearSelection();
            con.Close();
     
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arayüz arayüz = new arayüz();
            arayüz.StartPosition = FormStartPosition.CenterScreen;
            arayüz.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            isimdeğiş isimdeğiş = new isimdeğiş();
            isimdeğiş.StartPosition = FormStartPosition.CenterScreen;
            isimdeğiş.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.StartPosition = FormStartPosition.CenterScreen;
            giris.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            şifredeğiştir şifredeğiştir = new şifredeğiştir();
            şifredeğiştir.StartPosition = FormStartPosition.CenterScreen;
            şifredeğiştir.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string secilen = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            cevap cevap = new cevap();
            cevap.gelen = secilen;
            cevap.StartPosition = FormStartPosition.CenterScreen;
            cevap.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

                SqlCommand komut = new SqlCommand("delete from kullanici where id='" + giris.id + "'", con);
                DialogResult sonuc = MessageBox.Show("Hesabı silmek istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (sonuc == DialogResult.Yes)
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Hesap silindi");

                giris giris = new giris();
                giris.StartPosition = FormStartPosition.CenterScreen;
                giris.Show();
                this.Hide();
                    }
                    con.Close();
        }
    }
}
 
