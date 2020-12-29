using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class SocialMediaAccount : EntityBase, IEntity
    {
        public string AccountFA { get; set; }
        public string AccountUrl { get; set; }
    }
}
