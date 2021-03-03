using DataAccess.Abstract;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.ColorId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.ColorId
                             select new CarDetailsDto { BrandName = b.BrandName, Id = c.Id,ColorName=color.ColorName ,DailyPrice=c.DailyPrice};
                return result.ToList();

                           
            }
        }
    }
}
