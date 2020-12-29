using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.SocialMediaAccountDtos;
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
    public class AccountController : Controller
    {
        private readonly ISocialMediaAccountService _accountService;

        public AccountController(ISocialMediaAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<IActionResult> Index()
        {
            var accounts = await _accountService.GetAll();
            if (accounts.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (accounts.ResultStatus == ResultStatus.Success)
            {
                return View(accounts.Data);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SocialMediaAccountAddDto accountAddDto)
        {
            if (ModelState.IsValid)
            {
                await _accountService.Add(accountAddDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View(accountAddDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var account = await _accountService.GetUpdateDto(id);
            if (account.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (account.ResultStatus == ResultStatus.Success)
            {
                return View(account.Data);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SocialMediaAccountUpdateDto accountUpdateDto)
        {
            if (ModelState.IsValid)
            {
                await _accountService.Update(accountUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            return View(accountUpdateDto);
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var account = await _accountService.Get(id);
            if (account.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (account.ResultStatus == ResultStatus.Success)
            {
                return View(account.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> DoHardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            await _accountService.HardDelete(id);
            return RedirectToAction("Index");
        }
    }
}
