using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.MessageDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class MessageProfile : Profile
    {
        public MessageProfile()
        {
            CreateMap<MessageAddDto, Message>().ForMember(des => des.CreatedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<MessageUpdateDto, Message>().ForMember(des => des.ModifiedTime,opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Message, MessageUpdateDto>();
        }
    }
}
