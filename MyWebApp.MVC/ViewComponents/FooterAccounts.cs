using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.SocialMediaAccountDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class FooterAccounts : ViewComponent
    {
        private readonly ISocialMediaAccountService _socialMediaAccountService;

        public FooterAccounts(ISocialMediaAccountService socialMediaAccountService)
        {
            _socialMediaAccountService = socialMediaAccountService;
        }
        public IViewComponentResult Invoke()
        {
            var list = GetAccounts().Result;
            return View(list);
        }
        public async Task<SocialMediaAccountListDto> GetAccounts()
        {
            var accounts = await _socialMediaAccountService.GetAllByNonDeleteAndActive();
            return accounts.Data;
        }
    }
}
