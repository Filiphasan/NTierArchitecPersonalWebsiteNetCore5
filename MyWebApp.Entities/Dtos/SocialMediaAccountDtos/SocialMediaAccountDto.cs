using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.SocialMediaAccountDtos
{
    public class SocialMediaAccountDto : DtoGetBase
    {
        public SocialMediaAccount SocialMediaAccount { get; set; }
    }
}
