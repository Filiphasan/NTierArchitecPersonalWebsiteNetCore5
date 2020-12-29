using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Skill : EntityBase, IEntity
    {
        public string Title { get; set;}
        public int PercentageValue { get; set; }
    }
}
