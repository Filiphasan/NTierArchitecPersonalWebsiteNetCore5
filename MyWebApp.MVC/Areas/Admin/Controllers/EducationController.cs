using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.EducationDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public async Task<IActionResult> Index()
        {
            var educations = await _educationService.GetAll();
            if (educations.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (educations.ResultStatus == ResultStatus.Success)
            {
                return View(educations.Data);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EducationAddDto educationAddDto)
        {
            if (ModelState.IsValid)
            {
                await _educationService.Add(educationAddDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var education = await _educationService.GetUpdateDto(id);
            if (education.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (education.ResultStatus == ResultStatus.Success)
            {
                return View(education.Data);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EducationUpdateDto educationUpdateDto)
        {
            if (ModelState.IsValid)
            {
                await _educationService.Update(educationUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var education = await _educationService.Get(id);
            if (education.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (education.ResultStatus == ResultStatus.Success)
            {
                return View(education.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var education = await _educationService.Get(id);
            if (education.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (education.ResultStatus == ResultStatus.Success)
            {
                return View(education.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> DoHardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            await _educationService.HardDelete(id);
            return RedirectToAction("Index");
        }
    }
}
