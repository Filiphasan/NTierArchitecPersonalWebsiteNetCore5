using MyWebApp.Entities.Dtos.InterestedDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IInterestedService
    {
        Task<IDataResult<InterestedDto>> Get(int interestedId);
        Task<IDataResult<InterestedUpdateDto>> GetUpdateDto(int interestedDto);
        Task<IDataResult<InterestedListDto>> GetAll();
        Task<IDataResult<InterestedListDto>> GetAllByNonDelete();
        Task<IDataResult<InterestedListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<InterestedDto>> Add(InterestedAddDto interestedAddDto, string createdByName);
        Task<IDataResult<InterestedDto>> Update(InterestedUpdateDto ınterestedUpdateDto, string modifiedByName);
        Task<IResult> Delete(int interestedId, string modifiedByName);
        Task<IResult> HardDelete(int interestedId);
    }
}
