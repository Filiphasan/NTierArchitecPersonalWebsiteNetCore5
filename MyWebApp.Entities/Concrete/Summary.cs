﻿using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Summary : EntityBase, IEntity
    {
        public string Content { get; set; }
    }
}
