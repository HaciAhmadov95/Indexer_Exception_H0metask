using Indexe_Exception_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexe_Exception_Practice.Data
{

    internal class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person
                {
                    Id = 1,
                    FullName = "Ahmadov Haciaga",
                    Age = 28
                },
                new Person
                {
                    Id = 2,
                    FullName = "Aslanov Ali",
                    Age = 27
                },
                new Person
                {
                    Id = 3,
                    FullName = "Ismayilova Mermer",
                    Age = 22
                }

            };
        }
    }
}

    
    