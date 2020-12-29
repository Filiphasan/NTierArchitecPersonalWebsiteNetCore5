using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.EducationDtos
{
    public class EducationListDto : DtoGetBase
    {
        public IList<Education> Educations { get; set; }
    }
}
