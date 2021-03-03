using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            //_cars = new List<Car>
            //{
            //    new Car{Id=1,BrandId=14,ColorId=3,ModelYear=2019,DailyPrice=375000,Descriptions="Audi A3"},
            //    new Car{Id=2,BrandId=14,ColorId=21,ModelYear=2019,DailyPrice=260000,Descriptions="Nissan Juke" },
            //    new Car{Id=3,BrandId=5,ColorId=16,ModelYear=2019,DailyPrice=80000,Descriptions="Dacia Sandro"},
            //    new Car{Id=4,BrandId=14,ColorId=9,ModelYear=2019,DailyPrice=164000,Descriptions="Renult Megane"},
            //    new Car{Id=5,BrandId=9,ColorId=3,ModelYear=2019,DailyPrice=1040000,Descriptions="BWM İ8"},
            //};
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
            //Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            //carToUpdate.Id = car.Id;
            //carToUpdate.ColorId = car.ColorId;
            //carToUpdate.BrandId = car.BrandId;
            //carToUpdate.ModelYear = car.ModelYear;
            //carToUpdate.DailyPrice = car.DailyPrice;
            //carToUpdate.Descriptions = car.Descriptions;
        }

        public List<Car> GetByAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id, int BrandId, int ColorId)
        {
            return _cars.Where(c => c.Id == Id && c.BrandId==BrandId && c.ColorId==ColorId).ToList();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
