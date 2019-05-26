using CrudBackend.Data;
using System.Collections.Generic;

namespace CrudBackend.Repositories
{
    public interface IPersonRepository
    {
        Person Get(int id);
        IEnumerable<Person> GetAll();
        void Add(Person person);
        void Delete(Person person);        
    }
}
