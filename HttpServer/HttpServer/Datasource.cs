using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HttpServer
{
    public class Datasource
    {
        //Connect to database

        //private string _connectionString = "connection string";

        //public string ConnectionString { get { return _connectionString; } }

        //public string connectionString = "connection string";

        //What type of content do i want to serve? Lets go with the geogia tech project

        public static void ReadBook()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

            int ISBN = 0;
            string fName = " ";
            string lName = " ";

            //TODO: change this to a prepared statement later
            string querySring = "SELECT ISBN, BookName FROM Book;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querySring, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //Store table in objects
                    Console.WriteLine(reader.GetString(0));
                    ISBN = reader.GetInt32(1);
                    fName = reader.GetString(2);
                    lName = reader.GetString(3);
                    
                }

                reader.Close();
            }

        }
    }
}
