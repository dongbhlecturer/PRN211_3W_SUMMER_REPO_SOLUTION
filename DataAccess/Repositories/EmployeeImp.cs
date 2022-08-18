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
    public EmployeeImpl()
    {
        this._employees.Add(new Employee(1, "Nguyen Cong Phuong", "0909123456", 
            true, "Developer"));
    }
    public void Add(Employee e)
    {
        this._employees.Add(e);
    }

    public List<Employee> GetAll()
    {
       return this._employees;
    }
}
