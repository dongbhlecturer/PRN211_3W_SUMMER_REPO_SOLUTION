using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  PRN_3W_OOP_PRACTICE.Repositories;
using PRN_3W_OOP_PRACTICE.OOP.Practice;

namespace PRN_3W_OOP_PRACTICE.Manager;

public class PersonManager
{
    /*This class to implement all business logic */
    private IPerson _person;
    public PersonManager()
    {
        _person = new PersonImpl();
    }


    public PersonManager(IPerson person)
    {
        this._person = person;
    }
    public void AddAllPerson(params Person[] lst)
    {
        foreach (Person p in lst)
        {
            if(p != null)   AddPerson(p);
        }
    }
    public void AddPerson(Person p)
    {
        _person.Add(p); 
    }
    public List<Person> GetAllPerson()
    {
        return _person.GetAll();
    }
    //Lay ra nhung nhan vien co tong luong cao nhat

}
