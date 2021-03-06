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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult("New customer added");
        }

        public IDataResult<List<Customer>> GetAllByCustomerId(int Id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.CustormerId==Id));
        }
    }
}
