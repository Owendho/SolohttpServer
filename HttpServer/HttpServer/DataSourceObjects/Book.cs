using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer.DataSourceObjects
{
    public class Book
    {
        public string BookName { get; set; }
        public int ISBN { get; set; }

        public Book(string bookName, int isbn) {
            BookName = bookName;
            ISBN = isbn;
        }

    }
}
