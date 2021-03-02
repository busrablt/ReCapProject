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
            //BrandManager brandManager = new BrandManager(new EfBrandDal()); 
            Car newCar1 = new Car { BrandId = 1, ColorId = 2, DailyPrice = 205000, ModelYear = "2021", Descriptions = "Toyota Corolla" };
            carManager.Add(newCar1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }

          







        }
    }
}
