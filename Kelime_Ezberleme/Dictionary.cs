using System.Data.SqlClient;

namespace Kelime_Ezberleme
{
    public class Dictionary
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Mean { get; set; }
        public string Sentence1 { get; set; }
        public string Sentence2 { get; set; }
        public string Sentence3 { get; set; }
    }
    public  class RDMS
    {
        private static string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind";

        public static void ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                using (var conn = new SqlConnection(connection))
                {
                    conn.Open();
                    command.Connection = conn;
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
                
            }
        }
        public static void DELETE(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connection))
                {
                    cmd.Connection = conn;
                    ExecuteNonQuery(cmd);
                    
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
    
}
