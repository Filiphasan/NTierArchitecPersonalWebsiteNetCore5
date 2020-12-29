using MyWebApp.Entities.Dtos.SiteIdentityDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface ISiteIdentityService
    {
        Task<IDataResult<SiteIdentityDto>> Get(int siteIdentityId);
        Task<IDataResult<SiteIdentityUpdateDto>> GetUpdateDto(int siteIdentityId);
        Task<IDataResult<SiteIdentityDto>> Update(SiteIdentityUpdateDto siteIdentityUpdateDto, string modifiedByName);
        Task<IResult> Delete(int siteIdentityId, string modifiedByName);
        Task<IResult> HardDelete(int siteIdentityId);
    }
}
