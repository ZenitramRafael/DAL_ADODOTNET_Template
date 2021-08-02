using System;
using System.Data.SqlClient;

namespace ADODOTNET_DataAccess
{
    public class PeopleData
    {
        public static void GetPeople()
        {
            string connectionString = "Data Source=DESKTOP-UN0PLOQ\\SQLEXPRESS;Initial Catalog=Example;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM Example.dbo.ADODOTNET_Person";

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string firstname = dr["firstname"].ToString();
                        string lastname = dr["lastname"].ToString();
                        Console.WriteLine(firstname + " " + lastname);
                    }
                }
            }
        }
           
    }
}
