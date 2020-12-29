using MyWebApp.Entities.Dtos.ExperienceDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IExperienceService
    {
        Task<IDataResult<ExperienceDto>> Get(int experienceId);
        Task<IDataResult<ExperienceUpdateDto>> GetUpdateDto(int experienceId);
        Task<IDataResult<ExperienceListDto>> GetAll();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDelete();
        Task<IDataResult<ExperienceListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<ExperienceDto>> Add(ExperienceAddDto experienceAddDto, string createdByName);
        Task<IDataResult<ExperienceDto>> Update(ExperienceUpdateDto experienceUpdateDto, string modifiedByName);
        Task<IResult> Delete(int experienceId, string modifiedByName);
        Task<IResult> HardDelete(int experienceId);
    }
}
