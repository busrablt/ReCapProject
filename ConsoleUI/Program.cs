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
            //InsertMetod();
            CarDetailsDtoMethod();
        }

        private static void CarDetailsDtoMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "-" + car.ColorName +"-"+car.BrandName+"-"+car.DailyPrice);

            }
        }

        private static void InsertMetod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car newCar1 = new Car { BrandId = 1, ColorId = 2, DailyPrice = 205000, ModelYear = 2021, Descriptions = "Otomatik Dizel" };
            carManager.Add(newCar1);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Descriptions);
            }
        }
    }
}
