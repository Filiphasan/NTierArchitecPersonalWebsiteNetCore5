using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SkillDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class SkillProfile : Profile
    {
        public SkillProfile()
        {
            CreateMap<SkillAddDto, Skill>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<SkillUpdateDto, Skill>().ForMember(des => des.ModifiedTime, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Skill, SkillUpdateDto>();
        }
    }
}
