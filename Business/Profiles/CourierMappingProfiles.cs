using AutoMapper;
using Business.Requests.Courier;
using Business.Responses.Courier;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourierMappingProfiles:Profile
    {
        public CourierMappingProfiles()
        {
            CreateMap<Courier, ListCourierResponse>();
            CreateMap<CreateCourierRequest, Courier>();
            CreateMap<DeleteCourierRequest, Courier>();
            CreateMap<UpdateCourierRequest, Courier>();
        }
    }
}
