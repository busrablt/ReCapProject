using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car newCar1 = new Car {Id = 34, BrandId = 5, ColorId = 25, DailyPrice = 205000, ModelYear = 2021, Description = "Toyota Corolla" };
            carManager.Add(newCar1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }

            foreach (var cars in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(cars.Description);
            }







        }
    }
}
