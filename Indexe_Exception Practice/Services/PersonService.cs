using Indexe_Exception_Practice.Data;
using Indexe_Exception_Practice.Models;
using Indexe_Exception_Practice.Services.İnterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexe_Exception_Practice.Services
{
    internal class PersonService : IPersonService
    {
        private readonly AppDbContext _context;
        public PersonService()
        {
            _context = new AppDbContext();
        }
        public Person GetById(int? id)
        {

            if (id is null) throw new ArgumentNullException();

            Person? existPeople = _context.People().FirstOrDefault(x => x.Id == id);

            if (existPeople != null) throw new NullReferenceException();

            return existPeople;


        }
                    
                
        
        
    }
}
