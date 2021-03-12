using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Rejestr_osobowy
{
    class Manager
    {
        private IList<Person> _person;

    public Manager()
        {
            _person = new List<Person>();
        }
    public IEnumerable<Person> GetAll()
        {
            return _person;
        }
    public int generateId()
        {
            var id = 1;

            if (_person.Any())
            {
                id = _person.Max(x => x.Id) + 1;
            }
            return id;
        }
    public Person CreatePerson(string Name, string Surname, int Age, string Gender)
        {
            int id = generateId();
            Person p = new Person(id, Name, Surname, Age, Gender);
            _person.Add(p);
            return p;
        }
    }
}
