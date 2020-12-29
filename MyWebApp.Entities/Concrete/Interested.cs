using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Interested : EntityBase, IEntity
    {
        public string Text { get; set; }
    }
}
