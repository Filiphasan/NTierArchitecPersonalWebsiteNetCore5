using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Concrete
{
    public class Admin : EntityBase, IEntity
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SecurituQuestion { get; set; }
        public string SQAnswerHash { get; set; }
    }
}
