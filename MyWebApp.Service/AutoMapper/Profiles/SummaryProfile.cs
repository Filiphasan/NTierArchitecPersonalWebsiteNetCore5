using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SummaryDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class SummaryProfile : Profile
    {
        public SummaryProfile()
        {
            CreateMap<SummaryUpdateDto, Summary>().ForMember(des => des.ModifiedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Summary, SummaryUpdateDto>();
        }
    }
}
