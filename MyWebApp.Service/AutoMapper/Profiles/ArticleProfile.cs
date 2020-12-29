using AutoMapper;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.ArticleDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Service.AutoMapper.Profiles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>().ForMember(des => des.CreatedTime, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(des => des.ModifiedTime, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Article, ArticleUpdateDto>();
        }
    }
}
