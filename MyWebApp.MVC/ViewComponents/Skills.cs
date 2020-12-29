using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.SkillDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class Skills : ViewComponent
    {
        private readonly ISkillService _skillService;

        public Skills(ISkillService skillService)
        {
            _skillService = skillService;
        }
        public IViewComponentResult Invoke()
        {
            var datas = GetSkills().Result;
            return View(datas);
        }
        public async Task<SkillListDto> GetSkills()
        {
            var skills = await _skillService.GetAllByNonDeleteAndActive();
            return skills.Data;
        }
    }
}
