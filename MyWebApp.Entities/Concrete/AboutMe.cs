using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class AboutMe : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string MyJob { get; set; }
        public string MyJobFA { get; set; }
        public DateTime BirthDate { get; set; }
        public string MyCVPath { get; set; }
    }
}
