using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.ContactInfoDtos
{
    public class ContactInfoDto : DtoGetBase
    {
        public ContactInfo ContactInfo { get; set; }
    }
}
