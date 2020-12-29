using MyWebApp.Entities.Concrete;
using MyWebApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Entities.Dtos.HomePageSliderDtos
{
    public class HomePageSliderDto : DtoGetBase
    {
        public HomePageSlider HomePageSlider { get; set; }
    }
}
