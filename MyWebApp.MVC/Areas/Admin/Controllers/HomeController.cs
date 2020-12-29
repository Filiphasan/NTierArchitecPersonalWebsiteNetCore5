using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.AdminDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ISkillService _skillService;
        private readonly IHomePageSliderService _homePageSliderService;
        private readonly IMessageService _messageService;
        private readonly IEducationService _educationService;
        private readonly IExperienceService _experienceService;
        private readonly IInterestedService _interestedService;
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IAdminService _adminService;
        public HomeController(ISkillService skillService, IHomePageSliderService homePageSliderService, IMessageService messageService, IEducationService educationService, IExperienceService experienceService, IInterestedService interestedService, IArticleService articleService, ICategoryService categoryService, IAdminService adminService)
        {
            _skillService = skillService;
            _homePageSliderService = homePageSliderService;
            _messageService = messageService;
            _educationService = educationService;
            _experienceService = experienceService;
            _interestedService = interestedService;
            _articleService = articleService;
            _categoryService = categoryService;
            _adminService = adminService;
        }
        public async Task<IActionResult> Index()
        {
            var skills = await _skillService.GetAll();
            var sliders = await _homePageSliderService.GetAll();
            var messages = await _messageService.GetAll();
            var educations = await _educationService.GetAll();
            var experiences = await _experienceService.GetAll();
            var interesteds = await _interestedService.GetAll();
            var articles = await _articleService.GetAll();
            var categories = await _categoryService.GetAll();
            ViewBag.SkillCount = skills.Data.Skills.Count;
            ViewBag.SliderCount = sliders.Data.HomePageSliders.Count;
            ViewBag.MessageCount = messages.Data.Messages.Count;
            ViewBag.EducationCount = educations.Data.Educations.Count;
            ViewBag.ExperienceCount = experiences.Data.Experiences.Count;
            ViewBag.InterestedCount = interesteds.Data.Interesteds.Count;
            ViewBag.ArticleCount = articles.Data.Articles.Count;
            ViewBag.CategoryCount = categories.Data.Categories.Count;
            return View();
        }
        public async Task<IActionResult> Setting()
        {
            var admin = await _adminService.Get(1);
            if (admin.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (admin.ResultStatus == ResultStatus.Success)
            {
                return View(admin.Data);
            }
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> EditAdmin(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var admin = await _adminService.GetUpdateDto(id);
            if (admin.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (admin.ResultStatus == ResultStatus.Success)
            {
                return View(admin.Data);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditAdmin(AdminUpdateDto adminUpdateDto,string oldPsswrd, string oldSQHash)
        {
            if (ModelState.IsValid)
            {
                if (oldPsswrd != adminUpdateDto.PasswordHash)
                {
                    using var md5 = MD5.Create();
                    var result1 = md5.ComputeHash(Encoding.ASCII.GetBytes(adminUpdateDto.PasswordHash));
                    var strResult = BitConverter.ToString(result1);
                    adminUpdateDto.PasswordHash = strResult.Replace("-", "");
                }
                if (oldSQHash != adminUpdateDto.SQAnswerHash)
                {
                    using var md5New = MD5.Create();
                    var result2 = md5New.ComputeHash(Encoding.ASCII.GetBytes(adminUpdateDto.SQAnswerHash));
                    var strResult2 = BitConverter.ToString(result2);
                    adminUpdateDto.SQAnswerHash = strResult2.Replace("-","");
                }
                await _adminService.Update(adminUpdateDto, "Hasan Erdal");
                return RedirectToAction("Setting");
            }
            return View(adminUpdateDto);
        }
    }
}
