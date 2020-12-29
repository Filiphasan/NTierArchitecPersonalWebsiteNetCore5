using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.EducationDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class Educations : ViewComponent
    {
        private readonly IEducationService _educationService;

        public Educations(IEducationService educationService)
        {
            _educationService = educationService;
        }
        public IViewComponentResult Invoke()
        {
            var datas = GetEducations().Result;
            return View(datas);
        }
        public async Task<EducationListDto> GetEducations()
        {
            var educations = await _educationService.GetAllByNonDeleteAndActive();
            return educations.Data;
        }
    }
}
