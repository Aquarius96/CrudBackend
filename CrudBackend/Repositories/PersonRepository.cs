using System.Collections.Generic;
using System.Linq;
using CrudBackend.Data;
using CrudBackend.Models;

namespace CrudBackend.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _context;

        public PersonRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(AddPersonModel model)
        {
            var person = new Person
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                Age = model.Age
            };
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
