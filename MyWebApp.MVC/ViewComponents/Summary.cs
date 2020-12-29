using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.SummaryDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class Summary : ViewComponent
    {
        private readonly ISummaryService _summaryService;

        public Summary(ISummaryService summaryService)
        {
            _summaryService = summaryService;
        }
        public IViewComponentResult Invoke()
        {
            var data = GetSummary().Result;
            return View(data);
        }
        public async Task<SummaryDto> GetSummary()
        {
            var summary = await _summaryService.Get(1);
            return summary.Data;
        }
    }
}
