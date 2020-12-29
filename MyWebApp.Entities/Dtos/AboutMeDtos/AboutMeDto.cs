using MyWebApp.Shared.Entities.Abstract;
using MyWebApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using MyWebApp.Shared.Utilities.ComplexTypes;

namespace MyWebApp.Entities.Dtos.AboutMeDtos
{
    public class AboutMeDto : DtoGetBase
    {
        public AboutMe  AboutMe { get; set; }
    }
}
