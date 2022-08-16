using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP_GENERIC_COLLECTION.Repositories;

public interface IGenericRepo<E>
{
    void Add(E e);
    void Update(E e);
    void Delete(E e);
    E GetById(int id);
    IEnumerable<E> GetAll();
}
