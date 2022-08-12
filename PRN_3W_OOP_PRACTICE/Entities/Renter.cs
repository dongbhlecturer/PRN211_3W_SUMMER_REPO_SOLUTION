using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP_PRACTICE.OOP.Practice;

internal class Renter : Person
{
    public double NetSalary { get; set; }
    public double AddSalary { get; set; } = 0;
    public override double CalculatorSalary()
    {
        return NetSalary + AddSalary;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Salary(renter) is: {CalculatorSalary()}");
    }
}
