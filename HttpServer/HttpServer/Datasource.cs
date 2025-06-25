using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HttpServer
{
    public class Datasource
    {
        //Connect to database

        //private string _connectionString = "connection string";

        //public string ConnectionString { get { return _connectionString; } }

        //public string connectionString = "connection string";

        //What type of content do i want to serve? Lets go with the geogia tech project

        //Create unit test for this method that checks whether the select statement is valid
        public static void ReadBook()
        {
            //Store connectionString in local Appsettings.json.
            string connectionString = " ";
            //https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn

            int ISBN = 0;
            string bookName = " ";

            //TODO: change this to a prepared statement later
            string querySring = "USE GeorgiaTechLibrary; SELECT BookName, ISBN FROM Books;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(querySring, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    //Store table in objecWin32Exception: The certificate chain was issued by an ts
                    Console.WriteLine(reader.GetString(0));
                    bookName = reader.GetString(0);
                    ISBN = reader.GetInt32(1);
                    
                    Console.WriteLine(bookName + ISBN);
                }

                reader.Close();
            }

        }

        public string readAppsettings()
        {
            string fileText = File.ReadAllText("Appsettings.json"); //TODO: Implement relative path. Currently searches SolohttpServer\HttpServer\HttpServer\bin\Debug\net8.0
            string regexString = @"/([A-Z])\w+/g";

            Regex regex = new Regex(regexString);

            Match match = regex.Match(fileText);

            string connectionString = " ";

            match.Value.Trim();

            //return connectionString;
            return match.Value.Trim();
        }
    }
}
