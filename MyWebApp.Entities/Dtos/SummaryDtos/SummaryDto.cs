using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.SummaryDtos
{
    public class SummaryDto : DtoGetBase
    {
        public Summary Summary { get; set; }
    }
}
