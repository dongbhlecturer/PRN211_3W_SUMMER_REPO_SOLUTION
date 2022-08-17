using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories;

public class EmployeeImpl : IEmployee
{
    private List<Employee> _employees = new List<Employee>();
    public void Add(Employee e)
    {
        this._employees.Add(e);
    }
}
