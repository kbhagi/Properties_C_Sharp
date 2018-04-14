using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Bossypants";
            string bookTitle = book.Title;

        }
    }
    public class Book
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
    }
    
}
