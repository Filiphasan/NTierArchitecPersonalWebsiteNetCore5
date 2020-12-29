using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.AdminDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SessionController : Controller
    {
        private readonly IAdminService _adminService;

        public SessionController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public async Task<IActionResult> LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(AdminLoginDto adminLoginDto)
        {
            var adminInfo = await _adminService.Get(1);
            var admin = adminInfo.Data.Admin;
            using var md5 = MD5.Create();
            var result1 = md5.ComputeHash(Encoding.ASCII.GetBytes(adminLoginDto.Password));
            var strResult = BitConverter.ToString(result1);
            if (admin.Email == adminLoginDto.Email && admin.PasswordHash == strResult.Replace("-", ""))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,adminLoginDto.Email)
                };
                var identity = new ClaimsIdentity(claims,"login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home",new { area="Admin"});
            }
            return View(adminLoginDto);
        }

        [HttpGet]
        public async Task<IActionResult> ForgotPassword()
        {
            var adminInfo = await _adminService.Get(1);
            ViewBag.SQ = adminInfo.Data.Admin.SecurituQuestion;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string sqAnswer)
        {
            //if (string.IsNullOrEmpty(sqAnswer))
            //{
            //    return View(sqAnswer);
            //}
            //var adminInfo = await _adminService.Get(1);
            //var admin = adminInfo.Data.Admin;
            //ViewBag.SQ = admin.SecurituQuestion;
            //using var md5 = MD5.Create();
            //var result1 = md5.ComputeHash(Encoding.ASCII.GetBytes(sqAnswer));
            //var strResult = BitConverter.ToString(result1);
            //if (admin.SQAnswerHash == strResult.Replace("-", ""))
            //{
            //    //Bu kısımda şifre yenilenip mail veya sms olarak iletilecek.
            //    Random random = new Random();
            //    var rndPsswrd = random.Next(100000, 999999).ToString();
            //    using var md = MD5.Create();
            //    var result = md.ComputeHash(Encoding.ASCII.GetBytes(rndPsswrd));
            //    var str = BitConverter.ToString(result);
            //    var adminNew = new AdminUpdateDto
            //    {
            //        Email = admin.Email,
            //        SecurituQuestion = admin.SecurituQuestion,
            //        IsActive = admin.IsActive,
            //        IsDeleted = admin.IsDeleted,
            //        Id = admin.Id,
            //        SQAnswerHash = admin.SQAnswerHash,
            //        PasswordHash = str.Replace("-", "")
            //    };
            //    await _adminService.Update(adminNew, "Hasan Erdal");
            //    return RedirectToAction("LogIn");
            //}
            return View(sqAnswer);
        }
    }
}
