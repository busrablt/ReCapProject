using Business.Abstract;
using Core.Results.Abstract;
using Core.Results.Concreate;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult("New brand added");
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("The brand deleted");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<List<Brand>> GetAllByBrandId(int Id)
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(b => b.BrandId == Id), "Brands listed by Id number");
        }
    }
   
}
