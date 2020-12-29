using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.EducationDtos
{
    public class EducationDto : DtoGetBase
    {
        public Education Education { get; set; }
    }
}
