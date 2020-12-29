using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SocialMediaAccountDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class SocialMediaAccountProfile : Profile
    {
        public SocialMediaAccountProfile()
        {
            CreateMap<SocialMediaAccountAddDto, SocialMediaAccount>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<SocialMediaAccountUpdateDto, SocialMediaAccount>().ForMember(des => des.ModifiedTime, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<SocialMediaAccount, SocialMediaAccountUpdateDto>();
        }
    }
}
