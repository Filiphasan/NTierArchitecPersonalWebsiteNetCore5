using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.InterestedDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class Interesteds : ViewComponent
    {
        private readonly IInterestedService _interestedService;

        public Interesteds(IInterestedService interestedService)
        {
            _interestedService = interestedService;
        }
        public IViewComponentResult Invoke()
        {
            var datas = GetInteresteds().Result;
            return View(datas);
        }
        public async Task<InterestedListDto> GetInteresteds()
        {
            var interesteds = await _interestedService.GetAllByNonDeleteAndActive();
            return interesteds.Data;
        }
    }
}
