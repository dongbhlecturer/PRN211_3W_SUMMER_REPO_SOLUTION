using PRN_3W_OOP_PRACTICE.OOP.GenericCollection;
/*
 Lập trình ứng dụng tính lương của các loại nhân viên (Employees, 
Renter, Worker) khác nhau trong công ty:
    - Lập trình hướng đối tượng
    - Cho phép tính lương khác nhau cho từng loại nhân viên
    - Sử dụng: interface, abstract (virtual, override, abstract)
    - Hệ thống cho phép: CRUD nhân viên bất kỳ
    - Sắp xếp tăng dần/giảm dần theo lương (IComparable/IComparer)
 */
/*1. Khoi tao list cac object kieu Person*/
Employee e1 = new Employee();
e1.Id = 1;
e1.Name = "Bui Huu Dong";
e1.Address = new Address(10, "CMT8", "P.13", "Quan 10", "HCMC");
e1.Manday = 25;
e1.BaseSalary = 250_000;

Renter e2 = new Renter();
e2.Id = 2;
e2.Name = "Nguyen Cong Phuong";
e2.Address = new Address(123, "Huynh van Banh", "P.Cong Vi", "Quan 3", "HCMC");
e2.NetSalary = 6_000_000;
e2.AddSalary = 150_000;

Employee e3 = new Employee();
e3.Id = 1;
e3.Name = "Pack Hang Seo";
e3.Address = new Address(11, "Phan Dinh Phung", "P.Quan Hoa", "Quan Cau Giay",
    "Ha Noi");
e3.Manday = 30;
e3.BaseSalary = 450_000;

/*2. Dua 3 object tren vao mot list*/

var lstPerson = new List<Person> { e1, e2, e3 };//vua khai bao lai vua khoi tao
/*3. Sap xep tang dan theo luong*/
//lstPerson.Sort(new PersonComparer());
/*4. Demo lambda: khong can dinh nghia them Comparer nhu ở mục 3 nữa mà truyền động*/

static int ComparePerson(Person x, Person y)
{
    return -x.Name.Length + y.Name.Length;
}

lstPerson.Sort(ComparePerson);





foreach (Person p in lstPerson)
{
    Console.WriteLine($"[Name: {p.Name} - Salary:{p.CalculatorSalary()}]");
}

Console.WriteLine("***********************************");
/*Demo ve Lambda Expresion*/

/*Dung Lambda standard de sap xep tang dan theo luong*/

var data = lstPerson.OrderBy(p => p.CalculatorSalary());
foreach (Person p in data)
{
    Console.WriteLine($"[Name: {p.Name} - Salary:{p.CalculatorSalary()}]");
}
/*Tinh tong luong cua n Person va in ra man hinh*/

double sumSalary = lstPerson.Sum(p=>p.CalculatorSalary());
Console.WriteLine($"Tong luong cua {lstPerson.Count} emps are: {sumSalary}");

Console.WriteLine("***********************************");
/*Dung LINQ to Object (cu phap moi) de truy van vao mot tap hop*/
var dataPerson = from p in lstPerson 
                 where p.Name.ToUpper().Contains("SEO")
                 select p;
foreach (Person p in dataPerson)
{
    Console.WriteLine($"[Name: {p.Name} - Salary:{p.CalculatorSalary()}]");
}