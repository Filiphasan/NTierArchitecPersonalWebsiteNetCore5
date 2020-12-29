using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.SkillDtos
{
    public class SkillDto : DtoGetBase
    {
        public Skill Skill { get; set; }
    }
}
