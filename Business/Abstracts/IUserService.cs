﻿using Business.Requests.User;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);

        IDataResult<User> Add(CreateUserRequest request);
        IResult Update(UpdateUserRequest user);
        IResult Delete(int userId);
    }
}
