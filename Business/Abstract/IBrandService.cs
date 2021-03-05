using Core.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllByBrandId(int Id);
    }
}
