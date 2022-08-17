using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
namespace DataAccess.Repositories;

public interface IEmployee
{
    void Add(Employee e);
}
