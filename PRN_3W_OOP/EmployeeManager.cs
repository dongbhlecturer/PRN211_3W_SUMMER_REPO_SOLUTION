

namespace PRN_3W_OOP.OOP;

public class EmployeeManager
{
    //1. properties
    const int NumberOfEmp = 10;
    private Employee[] _employees; //array static
    private int _count; //dem so luong co that trong array

    public EmployeeManager()
    {
        this._employees = new Employee[NumberOfEmp];
        this._count = 0;
    }
    public EmployeeManager(Employee[] employees)
    {
        this._employees = employees;
        this._count = employees.Length;
    }

    public void Add(Employee e)
    {
        if (e == null) return;
        Employee[] tmpEmp = new Employee[this._employees.Length];
        //check xem size ok ko?
        if(this._count >= this._employees.Length)
        {
            tmpEmp = new Employee[this._count * 2];
            for (int i = 0; i < this._count; i++)
            {
                tmpEmp[i] = this._employees[i];
            }
            
        }
        tmpEmp[this._count++] = e;
        _employees = tmpEmp;
    }

    public void Display()
    {
        foreach (Employee e in _employees)
        {
            Console.WriteLine(e);
        }
    }
}
