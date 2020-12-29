using MyWebApp.Entities.Dtos.SkillDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface ISkillService
    {
        Task<IDataResult<SkillDto>> Get(int skillId);
        Task<IDataResult<SkillUpdateDto>> GetUpdateDto(int skillId);
        Task<IDataResult<SkillListDto>> GetAll();
        Task<IDataResult<SkillListDto>> GetAllByNonDelete();
        Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<SkillDto>> Add(SkillAddDto skillAddDto, string createdByName);
        Task<IDataResult<SkillDto>> Update(SkillUpdateDto skillUpdateDto, string modifiedByName);
        Task<IResult> Delete(int skillId, string modifiedByName);
        Task<IResult> HardDelete(int skillId);
    }
}
