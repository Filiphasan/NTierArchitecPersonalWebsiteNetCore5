using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.AboutMeDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AboutMeController : Controller
    {
        private readonly IAboutMeService _aboutMeService;

        public AboutMeController(IAboutMeService aboutMeService)
        {
            _aboutMeService = aboutMeService;
        }

        public async Task<IActionResult> Index()
        {
            var aboutMe = await _aboutMeService.Get(1);
            if (aboutMe.ResultStatus == ResultStatus.Success)
            {
                return View(aboutMe.Data);
            }
            if (aboutMe.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id = 1)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var aboutMe = await _aboutMeService.GetUpdateDto(id);
            if (aboutMe.ResultStatus == ResultStatus.Success)
            {
                return View(aboutMe.Data);
            }
            if (aboutMe.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AboutMeUpdateDto aboutMeUpdateDto, IFormFile fileImage, IFormFile fileCV)
        {
            if (ModelState.IsValid)
            {
                if (fileImage != null)
                {
                    string imgExtension = Path.GetExtension(fileImage.FileName);
                    string imgName = Guid.NewGuid() + imgExtension;
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/uploads/img/{imgName}");
                    using var streamImg = new FileStream(imgPath, FileMode.Create);
                    await fileImage.CopyToAsync(streamImg);
                    aboutMeUpdateDto.ImagePath = $"/uploads/img/{imgName}";
                }
                if (fileCV != null)
                {
                    string cvExtension = Path.GetExtension(fileCV.FileName);
                    string cvName = Guid.NewGuid() + cvExtension;
                    string cvPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/uploads/cv/{cvName}");
                    using var streamCV = new FileStream(cvPath, FileMode.Create);
                    await fileCV.CopyToAsync(streamCV);
                    aboutMeUpdateDto.MyCVPath = $"/uploads/cv/{cvName}";
                }
                await _aboutMeService.Update(aboutMeUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View(aboutMeUpdateDto);
        }

        public async Task<IActionResult> Details(int id = 1)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var aboutMe = await _aboutMeService.Get(id);
            if (aboutMe.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (aboutMe.ResultStatus == ResultStatus.Success)
            {
                return View(aboutMe.Data);
            }
            return NotFound();
        }
    }
}
