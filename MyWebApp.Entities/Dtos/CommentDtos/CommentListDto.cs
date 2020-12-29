using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.CommentDtos
{
    public class CommentListDto : DtoGetBase
    {
        public IList<Comment> Comments { get; set; }
    }
}
