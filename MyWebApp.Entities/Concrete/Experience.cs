using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Experience : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Workplace { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
