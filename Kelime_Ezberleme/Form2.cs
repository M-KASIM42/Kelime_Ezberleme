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
    public partial class Form2 : Form
    {
        bool isthere;
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = kullaniciaditext.Text;
            string password = parolatext.Text;
            conn.Open();
            var cmd = new SqlCommand("Select * from giris2", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (username == reader["Kullaniciadi"].ToString().TrimEnd() && password==reader["Password"].ToString().TrimEnd())
                {
                    isthere = true;
                    break;
                }
                else
                {
                    isthere = false;
                }
            }
            if (isthere)
            {
                MessageBox.Show("Başarılı giriş");
                var form1 = new Form1(username);
                form1.Show();

            }
            else
                MessageBox.Show("Yanlış kullanıcı adı veya parola");
            conn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*
private void deletebutton_Click(object sender, EventArgs e)
{
   string sorgu = "DELETE FROM giris2 Where Kullaniciadi=@1 AND Password=@Password";
   var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");

   conn.Open();

   var cmd = new SqlCommand(sorgu,conn);
   cmd.Parameters.AddWithValue("@1", kullaniciaditext);
   cmd.Parameters.AddWithValue("@Password", parolatext);
   cmd.ExecuteNonQuery();
   conn.Close();
}
*/
    }
}
