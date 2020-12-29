using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.HomePageSliderDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class HomePageSliderProfile : Profile
    {
        public HomePageSliderProfile()
        {
            CreateMap<HomePageSliderAddDto, HomePageSlider>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<HomePageSliderUpdateDto, HomePageSlider>().ForMember(des => des.ModifiedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<HomePageSlider, HomePageSliderUpdateDto>();
        }
    }
}
