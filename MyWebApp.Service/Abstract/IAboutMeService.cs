using MyWebApp.Entities.Dtos.AboutMeDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IAboutMeService
    {
        Task<IDataResult<AboutMeDto>> Get(int aboutMeId);
        Task<IDataResult<AboutMeUpdateDto>> GetUpdateDto(int aboutMeId);
        Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}
