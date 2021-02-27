using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

      

        public List<Car> GetByAll()
        {
           return  _carDal.GetByAll();
        }

        public List<Car> GetById(int Id, int BrandId, int ColorId)
        {
            return _carDal.GetById(Id, BrandId, ColorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
