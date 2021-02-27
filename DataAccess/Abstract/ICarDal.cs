using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetById(int Id,int BrandId, int ColorId);
        List<Car> GetByAll();
    }
}
