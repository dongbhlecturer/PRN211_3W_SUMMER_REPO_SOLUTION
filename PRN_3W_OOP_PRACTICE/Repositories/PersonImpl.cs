using PRN_3W_OOP_PRACTICE.OOP.Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP_PRACTICE.Repositories;

public class PersonImpl : IPerson
{
    private List<Person> _persons = new List<Person>(); //ADO.net/EFc
    public void Add(Person p)
    {
        this._persons.Add(p);   
    }

    public void Delete(Person p)
    {
        this._persons.Remove(p);
    }

    public List<Person> GetAll()
    {
        return this._persons;
    }

    public Person? GetById(int id)
    {
        foreach (Person p in this._persons)
        {
            if (p.Id == id) { return p; }
            
        }
        return null;
    }

    public void Update(Person p)
    {
        //tu lam
    }
}
