using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;
using DataAccess.Entities;

namespace DataAccess.BusinessLogic;

public class EmployeeManager
{
    private IEmployee _employee;
    public EmployeeManager()
    {
        this._employee = new EmployeeImpl();
    }
    public void AddEmployee(Employee e)
    {
        this._employee.Add(e);
    }
    public List<Employee> GetAllEmployee()
    {
        return this._employee.GetAll(); 
    }
}
