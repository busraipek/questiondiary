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
    public partial class arayüz : Form
    {

        static string baglanti = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=questiondiary;Integrated Security=True";
        SqlConnection con = new SqlConnection(baglanti);
        public string gidici;
        public arayüz()
        {
            InitializeComponent();
        }

        public void arayüz_Load(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;

            con.Open();
            dataGridView1.ColumnCount = 1; 
            dataGridView1.Columns[0].Name = " ";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.AllCells;


            SqlCommand cmd = new SqlCommand("select id, kullaniciadi, soru from soru order by soruid desc", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["kullaniciadi"].ToString() + "  #"+dr["id"].ToString()+"\n"+ dr["soru"].ToString()+"\n");
                gidici = dr["soru"].ToString();
            }
            dataGridView1.ClearSelection();

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.StartPosition = FormStartPosition.CenterScreen;
            profil.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {            
            con.Open();

            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].Name = " ";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            SqlCommand cmd = new SqlCommand("select id, kullaniciadi, soru from soru order by soruid desc", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["kullaniciadi"].ToString() + "  #" + dr["id"].ToString() + "\n" + dr["soru"].ToString() + "\n");

            }
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            soru soru = new soru();
            soru.StartPosition = FormStartPosition.CenterScreen;
            soru.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string secilen = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cevap cevap = new cevap();
            cevap.gelen = secilen;
            cevap.StartPosition = FormStartPosition.CenterScreen;
            cevap.Show();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            
        }
    }
}
