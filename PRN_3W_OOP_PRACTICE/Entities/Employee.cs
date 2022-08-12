using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP_PRACTICE.OOP.Practice;

internal class Employee : Person
{
    public int Manday { get; set; }
    public double BaseSalary { get; set; }

    public override double CalculatorSalary()
    {
        return Manday * BaseSalary;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Salary (Employee) is: {CalculatorSalary()}");
    }
}
