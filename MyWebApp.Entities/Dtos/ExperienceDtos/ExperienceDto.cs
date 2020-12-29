using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.ExperienceDtos
{
    public class ExperienceDto : DtoGetBase
    {
        public Experience Experience { get; set; }
    }
}
