using Core.Utilities.Results.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        User GetByMail(string email);
        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
        
    }
}
