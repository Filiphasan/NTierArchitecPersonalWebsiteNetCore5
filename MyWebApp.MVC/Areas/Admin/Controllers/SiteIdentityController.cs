using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using MyWebApp.Entities.Dtos.SiteIdentityDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Authorization;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SiteIdentityController : Controller
    {
        private readonly ISiteIdentityService _siteIdentityService;

        public SiteIdentityController(ISiteIdentityService siteIdentityService)
        {
            _siteIdentityService = siteIdentityService;
        }
        public async Task<IActionResult> Index()
        {
            var identity = await _siteIdentityService.Get(1);
            return View(identity.Data);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id=1)
        {
            var identity = await _siteIdentityService.GetUpdateDto(id);
            if (identity.ResultStatus == ResultStatus.Success)
            {
                return View(identity.Data);
            }
            if (identity.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SiteIdentityUpdateDto siteIdentityUpdateDto)
        {
            if (ModelState.IsValid)
            {
                await _siteIdentityService.Update(siteIdentityUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> Details(int id = 1)
        {
            var identity = await _siteIdentityService.Get(id);
            if (identity.ResultStatus == ResultStatus.Success)
            {
                return View(identity.Data);
            }
            if (identity.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            return View();
        }
    }
}
