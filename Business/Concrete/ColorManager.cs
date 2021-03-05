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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        //constractor
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult("New color added");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult("The brand added");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), "All colors listed");
        }

        public IDataResult<List<Color>> GetAllByColorId(int Id)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(color => color.ColorId == Id), "Colors listed by id number");
        }
    }
}
