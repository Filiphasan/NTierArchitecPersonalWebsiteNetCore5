using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.CommentDtos
{
    public class CommentDto : DtoGetBase
    {
        public Comment Comment { get; set; }
    }
}
