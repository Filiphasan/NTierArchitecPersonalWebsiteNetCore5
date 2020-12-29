using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.ExperienceDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class ExperienceProfile : Profile
    {
        public ExperienceProfile()
        {
            CreateMap<ExperienceAddDto, Experience>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ExperienceUpdateDto, Experience>().ForMember(des => des.ModifiedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Experience, ExperienceUpdateDto>();
        }
    }
}
