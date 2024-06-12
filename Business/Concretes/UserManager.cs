using AutoMapper;
using Azure.Core;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.User;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IMapper _mapper;
        public UserManager(IUserDal userDal,IMapper mapper)
        {
            _mapper = mapper;
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        //public void Add(User user)
        //{
        //    _userDal.Add(user);
        //}

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(c => c.UserId == userId));
        }

        public IDataResult<User> Add(CreateUserRequest request)
        {
            User user = _mapper.Map<User>(request);
            _userDal.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserAdded);
        }

        public IResult Delete(int userId)
        {
            _userDal.Delete(_userDal.Get(c => c.UserId == userId));
            return new Result(true, Messages.UserDeleted);
        }

        public IResult Update(UpdateUserRequest request)
        {
            User user = _mapper.Map<User>(request);
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
