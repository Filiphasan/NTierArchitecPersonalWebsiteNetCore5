using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class MessagesController : Controller
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public async Task<IActionResult> Index()
        {
            var messages = await _messageService.GetAll();
            if (messages.ResultStatus == ResultStatus.Success)
            {
                return View(messages.Data);
            }
            if (messages.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            return View();
        }

        public async Task<IActionResult> Checked(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            await _messageService.CheckMessage(id, "Hasan Erdal");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var message = await _messageService.Get(id);
            if (message.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (message.ResultStatus == ResultStatus.Success)
            {
                return View(message.Data);
            }
            return View();
        }

        public async Task<IActionResult> DoHardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            await _messageService.HardDelete(id);
            return RedirectToAction("Index");
        }
    }
}
