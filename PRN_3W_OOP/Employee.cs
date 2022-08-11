using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP.OOP;

public class Employee:Person //IS-A
{
    public int Id { get; set; }
    public int Manday { get; set; }
    public double RateSalary { get; set; }
    public static string NameOfCompany ="Fpt Co."; 

    public Employee()
    {

    }

    public Employee(int id, int manday, double rateSalary)
    {
        Id = id;
        Manday = manday;
        RateSalary = rateSalary;
    }
    public Employee(int id, int manday, double rateSalary, string name, string address, int license, DateTime licenseDate):base(name,address,license,licenseDate)
    {
        Id = id;
        Manday = manday;
        RateSalary = rateSalary;
    }

    public double GetSalary()
    {
        return Manday * RateSalary;
    }

    public override string? ToString()
    {
        return $"[Id: {Id}, Manday: {Manday}, Base Salary: {RateSalary}]," +
            $"NameOfCompany: {NameOfCompany},{base.ToString()}";
    }
}
