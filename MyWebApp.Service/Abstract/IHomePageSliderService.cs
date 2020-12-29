using MyWebApp.Entities.Dtos.HomePageSliderDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IHomePageSliderService
    {
        Task<IDataResult<HomePageSliderDto>> Get(int homePageSliderId);
        Task<IDataResult<HomePageSliderUpdateDto>> GetUpdateDto(int homePageSliderId);
        Task<IDataResult<HomePageSliderListDto>> GetAll();
        Task<IDataResult<HomePageSliderListDto>> GetAllByNonDelete();
        Task<IDataResult<HomePageSliderListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<HomePageSliderDto>> Add(HomePageSliderAddDto homePageSliderAddDto, string createdByName);
        Task<IDataResult<HomePageSliderDto>> Update(HomePageSliderUpdateDto homePageSliderUpdateDto, string modifiedByName);
        Task<IResult> Delete(int homePageSliderId, string modifiedByName);
        Task<IResult> HardDelete(int homePageSliderId);
    }
}
