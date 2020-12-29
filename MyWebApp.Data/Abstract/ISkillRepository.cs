using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Data.Abstract
{
    public interface ISkillRepository : IEntityRepository<Skill>
    {
    }
}
