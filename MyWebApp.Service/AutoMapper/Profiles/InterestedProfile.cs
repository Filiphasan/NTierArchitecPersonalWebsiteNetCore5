using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.InterestedDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class InterestedProfile : Profile
    {
        public InterestedProfile()
        {
            CreateMap<InterestedAddDto, Interested>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<InterestedUpdateDto, Interested>().ForMember(des => des.ModifiedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Interested, InterestedUpdateDto>();
        }
    }
}
