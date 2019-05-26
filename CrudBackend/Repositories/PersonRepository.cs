using System.Collections.Generic;
using System.Linq;
using CrudBackend.Data;

namespace CrudBackend.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Person person)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
        }

        public void Delete(Person person)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }

        public Person Get(int id)
        {
            return _context.Persons.FirstOrDefault(person => person.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _context.Persons;
        }
    }
}
