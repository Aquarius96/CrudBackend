using CrudBackend.Data;
using CrudBackend.Models;
using System.Collections.Generic;

namespace CrudBackend.Repositories
{
    public interface IPersonRepository
    {
        Person Get(int id);
        IEnumerable<Person> GetAll();
        void Add(AddPersonModel person);
        void Delete(Person person);        
    }
}
