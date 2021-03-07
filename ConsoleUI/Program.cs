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
            //CarDetailsDtoMethod();
            CarManagerMethod();

        }

        private static void CarManagerMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            Car newCar1 = new Car { BrandId = 2, ColorId = 2,CarName="Toyotaa" ,DailyPrice = 205000, ModelYear = 2021, Descriptions = "Otomatik " };
            carManager.Add(newCar1);
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "---" + car.Descriptions);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailsDtoMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + "-" + car.ColorName +"-"+car.BrandName+"-"+car.DailyPrice);

            }
        }

        
    }
}
