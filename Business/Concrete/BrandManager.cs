using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concreate;
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

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTeam);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        public IDataResult<List<Brand>> GetAllByBrandId(int Id)
        {
            return new SuccessDataResult<List<Brand>>( _brandDal.GetAll(b => b.BrandId == Id),Messages.BrandListedById );
        }
    }
   
}
