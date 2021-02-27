﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=14,ColorId=3,ModelYear=2019,DailyPrice=375000,Description="Audi A3"},
                new Car{Id=2,BrandId=14,ColorId=21,ModelYear=2019,DailyPrice=260000,Description="Nissan Juke" },
                new Car{Id=3,BrandId=5,ColorId=16,ModelYear=2019,DailyPrice=80000,Description="Dacia Sandro"},
                new Car{Id=4,BrandId=14,ColorId=9,ModelYear=2019,DailyPrice=164000,Description="Renult Megane"},
                new Car{Id=5,BrandId=9,ColorId=3,ModelYear=2019,DailyPrice=1040000,Description="BWM İ8"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<Car> GetByAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id, int BrandId, int ColorId)
        {
            return _cars.Where(c => c.Id == Id && c.BrandId==BrandId && c.ColorId==ColorId).ToList();
        }
    }
}
