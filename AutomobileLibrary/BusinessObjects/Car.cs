namespace AutomobileLibrary.BusinessObjects;
public class Car
{
    public int CarID { get; set; }
    public string CarName { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public int ReleaseYear { get; set; }
    public Car() { }

    public Car(int carID, string carName, string manufacturer, decimal price, int releaseYear)
    {
        CarID = carID;
        CarName = carName;
        Manufacturer = manufacturer;
        Price = price;
        ReleaseYear = releaseYear;
    }
}
