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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string password = textBox2.Text;
            string repassword = textBox3.Text;
            string email = textBox4.Text;
            string phone = textBox5.Text;
            var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");
            conn.Open();
            var cmd = new SqlCommand("Insert Into giris2(Kullaniciadi,Password,Re_Password,email,phone) VALUES(@1,@2,@3,@4,@5)", conn);
            cmd.Parameters.AddWithValue("@1", kullaniciadi);
            cmd.Parameters.AddWithValue("@2", password);
            cmd.Parameters.AddWithValue("@3", repassword);
            cmd.Parameters.AddWithValue("@4", email);
            cmd.Parameters.AddWithValue("@5", phone);

            var conn2 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;");
            conn2.Open();
            var cmd2 = new SqlCommand("Select * from giris2 where Kullaniciadi=@username", conn2);
            cmd2.Parameters.AddWithValue("@username",kullaniciadi);
            var sda = new SqlDataAdapter(cmd2);
            var ds = new DataSet();
            sda.Fill(ds);
            conn2.Close();
            var temp = true;
            foreach (char item in phone)
            {

                
                if(!(item=='0' || item == '1' || item == '2' || item == '3' || item == '4' || item == '5' || item == '6' || item == '7' || item == '8' || item == '9')){
                    temp = false;
                    break;
                } 
            }
            int a = 0;
            int c = 0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                a++;
            }
            if (!password.Equals(repassword))
            {
                MessageBox.Show("parolalar uyuşmuyor");
                c++;
            }
            if (a >= 1)
            {
                MessageBox.Show("Bu kullanıcı adı zaten var");
                c++;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("@ karakteri giriniz!!!");
                c++;
            }
            if (!email.Contains(".com"))
            {
                MessageBox.Show(".com icermeli");
                c++;
            }
            if (!temp)
            {
                MessageBox.Show("telefon numarasi karakter içeremez");
                c++;
            }
            if ((phone.Length != 11))
            {
                MessageBox.Show("Telefon numarasi 11 karakterden olusmali");
                c++;
            }
            if(c == 0)
            {
                 cmd.ExecuteNonQuery();
                 conn.Close();
                MessageBox.Show("Kayıt Başarılı");
                 var form = new Form2();
                 form.Show();
            }
                

                

            
            

        }
    }
}
