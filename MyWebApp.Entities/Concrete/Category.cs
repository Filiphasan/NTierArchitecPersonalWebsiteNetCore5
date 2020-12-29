using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Category : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string CategoryFA { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
