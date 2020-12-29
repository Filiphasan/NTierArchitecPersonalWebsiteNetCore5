using MyWebApp.Entities.Dtos.SocialMediaAccountDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface ISocialMediaAccountService
    {
        Task<IDataResult<SocialMediaAccountDto>> Get(int socialMediaAccountId);
        Task<IDataResult<SocialMediaAccountUpdateDto>> GetUpdateDto(int socialMediaAccountId);
        Task<IDataResult<SocialMediaAccountListDto>> GetAll();
        Task<IDataResult<SocialMediaAccountListDto>> GetAllByNonDelete();
        Task<IDataResult<SocialMediaAccountListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<SocialMediaAccountDto>> Add(SocialMediaAccountAddDto socialMediaAccountAddDto, string createdByName);
        Task<IDataResult<SocialMediaAccountDto>> Update(SocialMediaAccountUpdateDto socialMediaAccountUpdateDto, string modifiedByName);
        Task<IResult> Delete(int socialMediaAccountId, string modifiedByName);
        Task<IResult> HardDelete(int socialMediaAccountId);
    }
}
