using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.AboutMeDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class AboutMeProfile : Profile
    {
        public AboutMeProfile()
        {
            CreateMap<AboutMeUpdateDto, AboutMe>().ForMember(x => x.ModifiedTime, o => o.MapFrom(x => DateTime.Now));
            CreateMap<AboutMe, AboutMeUpdateDto>();
        }
    }
}
