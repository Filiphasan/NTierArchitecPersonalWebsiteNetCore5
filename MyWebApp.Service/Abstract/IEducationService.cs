using MyWebApp.Entities.Dtos.EducationDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IEducationService
    {
        Task<IDataResult<EducationDto>> Get(int educationId);
        Task<IDataResult<EducationUpdateDto>> GetUpdateDto(int educationId);
        Task<IDataResult<EducationListDto>> GetAll();
        Task<IDataResult<EducationListDto>> GetAllByNonDelete();
        Task<IDataResult<EducationListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<EducationDto>> Add(EducationAddDto educationAddDto, string createdByName);
        Task<IDataResult<EducationDto>> Update(EducationUpdateDto educationUpdateDto, string modifiedByName);
        Task<IResult> Delete(int educationId, string modifiedByName);
        Task<IResult> HardDelete(int educationId);
    }
}
