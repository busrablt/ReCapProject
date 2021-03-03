using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColordId(int ColorId);
        List<Car> GetAll();
        List<CarDetailsDto> GetCarDetails();
    }

}
