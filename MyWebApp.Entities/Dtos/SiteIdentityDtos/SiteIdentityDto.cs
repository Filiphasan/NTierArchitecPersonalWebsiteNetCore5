using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.SiteIdentityDtos
{
    public class SiteIdentityDto : DtoGetBase
    {
        public SiteIdentity SiteIdentity { get; set; }
    }
}
