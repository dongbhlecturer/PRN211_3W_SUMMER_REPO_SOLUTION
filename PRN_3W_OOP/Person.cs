namespace PRN_3W_OOP.OOP;
public class Person
{
    //1. data
    public string Name { get; set; }
    public string Address { get; set; }
    public int License { get; set; }
    public DateTime LicenseDate { get; set; }
    
    //2. constructor
    public Person() { }
    public Person(string name, string address, int license, DateTime licenseDate)
    {
        Name = name;
        Address = address;
        License = license;
        LicenseDate = licenseDate;
    }

    public override string? ToString()
    {
        return $"[Name is: {Name}, Address: {Address}, " +
            $"License: {License}], License Date: {LicenseDate}";
    }
}
