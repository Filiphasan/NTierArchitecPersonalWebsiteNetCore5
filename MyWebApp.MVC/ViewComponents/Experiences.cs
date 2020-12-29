using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.ExperienceDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class Experiences : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public Experiences(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IViewComponentResult Invoke()
        {
            var datas = GetExperiences().Result;
            return View(datas);
        }
        public async Task<ExperienceListDto> GetExperiences()
        {
            var experiences = await _experienceService.GetAllByNonDeleteAndActive();
            return experiences.Data;
        }
    }
}
