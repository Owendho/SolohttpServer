using System;
using System.Collections.Generic;
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

            string querySring = "SELECT ISBN, BookName FROM Book;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(querySring, connection))
            {
                connection.Open();

            }
        }
    }
}
