using AutomobileLibrary.BusinessObjects;
namespace AutomobileLibrary.DataAccess;

public class CarDBContext
{
    /*
        @Desc:
        @Input:
        @Output:
        @Author:
        @DateCreated:

        @ModifiedBy: Dongbh, 20/Aug/2022
     */
    /*define fields*/
    private static List<Car> _carList = new List<Car>()
    {
        /*Object Initalize*/
        new Car{CarID =1, CarName="CRV",Manufacturer="Honda",Price=30_000,
            ReleaseYear=2022},
        new Car{CarID =2, CarName="Ford New",Manufacturer="Ford",Price=40_000,
            ReleaseYear=2021},
        new Car{CarID =3, CarName="MES",Manufacturer="Honda",Price=50_000,
            ReleaseYear=2022},
    };
    /*Create singleton design parttern*/
    private static CarDBContext _instance = null;
    private static readonly object _instanceLock = new object();
    private CarDBContext() { }
    /*define property*/
    public static CarDBContext Instance
    {
        get
        {
            /*Giup lock lai neu nhu instance(object) cua CarDBContext da 
             duoc khoi tao (new)
             */
            lock (_instanceLock)
            {
                if (_instance == null) { _instance = new CarDBContext(); }
                return _instance;
            }
        }
    }
    public List<Car> GetCarList => _carList; //bodies-expression
    /*Lay ra 1 Car dua tren CarId*/
    public Car? GetCarById(int CarId) => _carList.SingleOrDefault(c=>c.CarID == CarId);
    public void AddNew(Car c)
    {
        /*check xem c da co trong db chua?*/
        Car car = GetCarById(c.CarID); //Lay duoc Car neu ton tai

        if (car is null)
        {
            _carList.Add(c);
        }
        else
        {
            throw new Exception("The Car is exists...");
        }
    }

    public void Update(Car c)
    {
        /*check xem c da co trong db chua?*/
        Car car = GetCarById(c.CarID); //Lay duoc Car neu ton tai
        if(c is not null)
        {
            /*Lay chi so (vi tri) cua c*/
            int index = _carList.IndexOf(c);
            _carList[index] = c;
        }
        else
        {
            throw new Exception($"CarID: {c.CarID} invalid...");
        }
    }

    public void Remove(Car c)
    {
        Car car = GetCarById(c.CarID); //Lay duoc Car neu ton tai

        if (car is not null)
        {
            _carList.Remove(c);
        }
        else
        {
            throw new Exception("The Car does not exists...");
        }

    }

}
