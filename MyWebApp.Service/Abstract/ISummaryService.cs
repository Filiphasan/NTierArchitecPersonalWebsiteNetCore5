using MyWebApp.Entities.Dtos.SummaryDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface ISummaryService
    {
        Task<IDataResult<SummaryDto>> Get(int summaryId);
        Task<IDataResult<SummaryUpdateDto>> GetUpdateDto(int summaryId);
        Task<IDataResult<SummaryDto>> Update(SummaryUpdateDto summaryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int summaryId, string modifiedByName);
        Task<IResult> HardDelete(int summaryId);
    }
}
