using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.ArticleDtos
{
    public class ArticleDto : DtoGetBase
    {
        public Article Article { get; set; }
    }
}
