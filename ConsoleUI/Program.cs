using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car newCar = new Car { Id = 34, BrandId = 5, ColorId = 25, DailyPrice = 205000, ModelYear = 2021, Description = "Toyota Corolla" };
            carManager.Add(newCar);

            foreach (var car in carManager.GetByAll())
            {
                Console.WriteLine(car.Description);
            }

            
           

        }
    }
}
