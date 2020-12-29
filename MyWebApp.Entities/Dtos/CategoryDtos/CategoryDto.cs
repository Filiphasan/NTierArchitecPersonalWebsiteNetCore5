using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.CategoryDtos
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
