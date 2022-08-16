using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN_3W_OOP_PRACTICE.OOP.GenericCollection;

namespace PRN_3W_OOP_GENERIC_COLLECTION.Repositories;

public class PersonRepo : IGenericRepo<Person>
{
    private IList<Person> _persons;
    public PersonRepo()
    {
        _persons = new List<Person>();
    }
    
    public void Add(Person e)
    {
       if(e != null) this._persons.Add(e);
    }

    public void Delete(Person e)
    {
       this._persons.Remove(e);
    }

    public IEnumerable<Person> GetAll()
    {
        return _persons;
    }

    public Person GetById(int id)
    {
        foreach (Person p in this._persons)
        {
            if (p.Id == id) { return p; }

        }
        return null;
    }

    public void Update(Person e)
    {
        //
    }
}
