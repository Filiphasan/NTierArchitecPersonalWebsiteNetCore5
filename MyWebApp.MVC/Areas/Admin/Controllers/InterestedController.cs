using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.InterestedDtos;
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
    public class InterestedController : Controller
    {
        private readonly IInterestedService _interestedService;

        public InterestedController(IInterestedService interestedService)
        {
            _interestedService = interestedService;
        }

        public async Task<IActionResult> Index()
        {
            var interesteds = await _interestedService.GetAll();
            if (interesteds.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (interesteds.ResultStatus == ResultStatus.Success)
            {
                return View(interesteds.Data);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(InterestedAddDto interestedAddDto)
        {
            if (ModelState.IsValid)
            {
                await _interestedService.Add(interestedAddDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View(interestedAddDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var interested = await _interestedService.GetUpdateDto(id);
            if (interested.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (interested.ResultStatus == ResultStatus.Success)
            {
                return View(interested.Data);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(InterestedUpdateDto interestedUpdateDto)
        {
            if (ModelState.IsValid)
            {
                await _interestedService.Update(interestedUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View(interestedUpdateDto);
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var interested = await _interestedService.Get(id);
            if (interested.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (interested.ResultStatus == ResultStatus.Success)
            {
                return View(interested.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> DoHardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            await _interestedService.HardDelete(id);
            return RedirectToAction("Index");
        }
    }
}
