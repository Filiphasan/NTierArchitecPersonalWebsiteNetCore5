using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class ContactInfo : EntityBase, IEntity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ShortAdress { get; set; }
        public string LongAdress { get; set; }
    }
}
