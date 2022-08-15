using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PRN_3W_OOP_PRACTICE.OOP.GenericCollection;

public abstract class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Address Address { get; set; } //Has-A

    public Person() { }

    public Person(int id, string? name, Address address)
    {
        Id = id;
        Name = name;
        Address = address;
    }

    //Tinh luong de dung chung cho all employees type: abstract method
    public abstract double CalculatorSalary();
    //Method voi virtual keyword: lop con thich thi thay doi
    public virtual void DisplayInfo() => WriteLine($"ID: {Id}, Name: {Name}, Address: {Address}");

}
