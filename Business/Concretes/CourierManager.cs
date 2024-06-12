using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Business.Requests.Courier;
using Business.Requests.User;
using Business.Responses.Courier;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourierManager : ICourierService
    {
        ICourierDal _courierDal;
        IUserService _userService;
        IMapper _mapper;
        public CourierManager(ICourierDal courierDal,IMapper mapper,IUserService userService)
        {
            _courierDal = courierDal;
            _mapper = mapper;
            _userService = userService;
        }
        public IResult Add(CreateCourierRequest request)
        {
            CreateUserRequest userRequest = _mapper.Map<CreateUserRequest>(request.CreateUserRequest);
            var user = _userService.Add(userRequest);
            Courier courier = _mapper.Map<Courier>(request);
            courier.User = _mapper.Map<User>(request.CreateUserRequest);
            courier.User.UserId = user.Data.UserId;
            _courierDal.Add(courier);
            return new SuccessResult(Messages.CourierAdded);
        }

        public IResult Delete(DeleteCourierRequest request)
        {
            Courier courier = _mapper.Map<Courier>(request);
            _courierDal.Delete(courier);
            return new Result(true, Messages.CourierDeleted);
        }

        public IDataResult<List<ListCourierResponse>> GetAll()
        {
            List<Courier> courier = _courierDal.GetAll(include: c => c.Include(c => c.User));
            List<ListCourierResponse> responses = _mapper.Map<List<ListCourierResponse>>(courier);
            return new SuccessDataResult<List<ListCourierResponse>>(responses,Messages.ProductsListed);
        }

        public IDataResult<Courier> GetById(int courierId)
        {
            return new SuccessDataResult<Courier>(_courierDal.Get(c => c.CourierId == courierId));
        }

        public IResult Update(UpdateCourierRequest request)
        {
            UpdateUserRequest userRequest = _mapper.Map<UpdateUserRequest>(request.UpdateUserRequest);
            var user = _userService.Update(userRequest);
            Courier courier = _mapper.Map<Courier>(request);
            courier.User = _mapper.Map<User>(userRequest);
            _courierDal.Update(courier);
            return new SuccessResult(Messages.CourierUpdated);
        }
    }
}
