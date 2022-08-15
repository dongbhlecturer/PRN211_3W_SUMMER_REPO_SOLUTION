using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_3W_OOP_PRACTICE.OOP.GenericCollection;

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        return y.CalculatorSalary().CompareTo(x.CalculatorSalary());
    }
}

