using AutomobileLibrary.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AutomobileLibrary.DataAccess; //DBContext

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        private CarDBContext _db = CarDBContext.Instance;
        public void AddCar(Car car) => _db.AddNew(car);
        

        public void DeleteCar(Car car) => _db.Remove(car);

        public string[] GetAllManufacturers() => _db.Manufacturers;
       

        public Car? GetCarById(int carId) => _db.GetCarById(carId);    

        public IEnumerable<Car> GetCars() => _db.GetCarList;
      
        public void UpdateCar(Car car) => _db.Update(car);
    }
}
