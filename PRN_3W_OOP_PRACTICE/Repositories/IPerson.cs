using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRN_3W_OOP_PRACTICE.OOP.Practice;

namespace PRN_3W_OOP_PRACTICE.Repositories;

public interface IPerson
{
    void Add(Person p);
    void Update(Person p);
    void Delete(Person p);
    Person GetById(int id);
    List<Person> GetAll();
}
