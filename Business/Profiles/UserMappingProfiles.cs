using AutoMapper;
using Business.Requests.User;
using Business.Responses.User;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserMappingProfiles:Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<CreateUserRequest, User>().ReverseMap();
            CreateMap<User, ListUserResponse>();
            CreateMap<DeleteUserRequest, User>().ReverseMap();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
        }
    }
}
