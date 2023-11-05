using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexe_Exception_Practice
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private Book[] books;

        public Library(int size = 100)
        {
            books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
            return books[index];
            }
            set 
            {
            books[index] = value;
            }

        }

    }
}
