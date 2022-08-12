/*
 Lập trình ứng dụng tính lương của các loại nhân viên (Employees, 
Renter, Worker) khác nhau trong công ty:
    - Lập trình hướng đối tượng
    - Cho phép tính lương khác nhau cho từng loại nhân viên
    - Sử dụng: interface, abstract (virtual, override, abstract)
    - Hệ thống cho phép: CRUD nhân viên bất kỳ
 */

/*1. Them n nhan vien vao he thong: Desktop/mobile/web...*/
using PRN_3W_OOP_PRACTICE.OOP.Practice;
using PRN_3W_OOP_PRACTICE.Manager;

Employee e1 = new Employee();
e1.Id = 1;
e1.Name = "Bui Huu Dong";
e1.Address= new Address(10,"CMT8","P.13","Quan 10","HCMC");
e1.Manday = 25;
e1.BaseSalary = 250000;

Renter e2 = new Renter();
e2.Id = 2;
e2.Name = "Nguyen Cong Phuong";
e2.Address = new Address(123, "Huynh van Banh", "P.Cong Vi", "Quan 3", "HCMC");
e2.NetSalary = 6000000;
e2.AddSalary = 150000;


PersonManager personManager = new PersonManager();
personManager.AddAllPerson(e1, e2);
/*Display all to front end*/
var allPersons = personManager.GetAllPerson();
foreach (var person in allPersons)
{
    person.DisplayInfo();
}
Console.ReadKey();  



