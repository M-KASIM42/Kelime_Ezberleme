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


namespace Kelime_Ezberleme
{
    public partial class Form1 : Form
    {
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");
        SqlCommand komut;
        SqlDataAdapter da;
        string username;
        
        public Form1(string _username)
        {
             username = _username;
            InitializeComponent();
            //textleridoldur();
        }
        public void griddoldur()
        {
            var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");
            var cmd = new SqlCommand("Select * from Sentence where userName=@username", conn);
            cmd.Parameters.AddWithValue("userName", username);
            var sda = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }






        private void dataGridView1_Enter(object sender, EventArgs e)
        {

            //textleridoldur();
        }


        private  void textlerisil()
        {
            wordtext.Clear();
            idtext.Clear();
            meantext.Clear();
            sentence1text.Clear();
            sentence2text.Clear();
            sentence3text.Clear();
        }
        public void textleridoldur()
        {

            idtext.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            wordtext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            meantext.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            sentence1text.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sentence2text.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            sentence3text.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.SelectionBackColor = Color.Blue;
            //textleridoldur();


        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Sentence(word,mean,sentence1,sentence2,sentence3, userName) VALUES(@word,@mean,@sentence1,@sentence2,@sentence3, @userName)";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@word", wordtext.Text);
            komut.Parameters.AddWithValue("@mean", meantext.Text);
            komut.Parameters.AddWithValue("@sentence1", sentence1text.Text);
            komut.Parameters.AddWithValue("@sentence2", sentence2text.Text);
            komut.Parameters.AddWithValue("@sentence3", sentence3text.Text);
            komut.Parameters.AddWithValue("@userName", username);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            textlerisil();
            

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Sentence Where Id=@Id";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@Id", Convert.ToInt32(idtext.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            textlerisil();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Sentence SET word=@word,mean=@mean,sentence1=@sentence1,sentence2=@sentence2,sentence3=@sentence3 Where Id=@Id";
            komut = new SqlCommand (sorgu,baglanti);
            komut.Parameters.AddWithValue("@Id", Convert.ToInt32(idtext.Text));
            komut.Parameters.AddWithValue("@word",wordtext.Text);
            komut.Parameters.AddWithValue("@mean", meantext.Text);
            komut.Parameters.AddWithValue("@sentence1", sentence1text.Text);
            komut.Parameters.AddWithValue("@sentence2", sentence2text.Text);
            komut.Parameters.AddWithValue("@sentence3", sentence3text.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close ();
            griddoldur();
            textlerisil();
        }

        private void deletetext_Click(object sender, EventArgs e)
        {
            textlerisil();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textleridoldur();
        }
    }
}
