using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.AdminDtos
{
    public class AdminDto : DtoGetBase
    {
        public Admin Admin { get; set; }
    }
}
