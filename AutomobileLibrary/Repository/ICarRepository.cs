using System;
using System.Collections;
using System.Collections.Generic;
using AutomobileLibrary.BusinessObjects;

namespace AutomobileLibrary.Repository;

public interface ICarRepository
{
    IEnumerable<Car> GetCars();
    string[] GetAllManufacturers();
    Car GetCarById(int carId);
    void AddCar(Car car);
    void UpdateCar(Car car);
    void DeleteCar(Car car);
}
