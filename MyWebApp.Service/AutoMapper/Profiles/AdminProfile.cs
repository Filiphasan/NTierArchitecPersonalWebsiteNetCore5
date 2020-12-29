using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class AdminProfile : Profile
    {
        public AdminProfile()
        {
            CreateMap<AdminUpdateDto, Admin>().ForMember(des => des.ModifiedTime, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Admin, AdminUpdateDto>();
        }
    }
}
