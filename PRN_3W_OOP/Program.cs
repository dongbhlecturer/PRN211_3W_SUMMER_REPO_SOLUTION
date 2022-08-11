
using PRN_3W_OOP.OOP;

//1. init object
/*
Product p = new Product();
p.ProductId = 2;
p.ProductName = "Laptop Dell 27inch";
p.ListPrice = 1500.0;
p.Desc = "Laptop Dell moi nhat nam 2022";

p.IncreasePrice(5);
Console.WriteLine(p);
*/
//1. Khai bao mot mang de chua n phan tu la Employee


Employee[] emps =
{
    new Employee(1, 30, 250000, "Dong", "Quan 10, HCM", 123456, new System.DateTime()),
    new Employee(2, 23, 350000, "Huy", "Quan 11, HCM", 1234569, new System.DateTime()),
    new Employee(3, 25, 150000, "Hai", "Quan 12, HCM", 1234568, new System.DateTime()),
};
EmployeeManager em = new EmployeeManager(emps);
Employee e = new Employee(4, 20, 650000, "Ma Van Meo", "Quan 10, HCM", 1234546, new System.DateTime());

em.Add(e);
em.Display();


Console.ReadKey();  
