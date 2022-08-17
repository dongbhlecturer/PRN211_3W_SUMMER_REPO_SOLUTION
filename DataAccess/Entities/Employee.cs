using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public bool IsGender     { get; set; }
    public string Type { get; set; }

    public Employee(int id, string name, string phone, bool isGender, string type)
    {
        Id = id;
        Name = name;
        Phone = phone;
        IsGender = isGender;
        Type = type;
    }
}
