using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SkillDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using MyWebApp.Shared.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Concrete
{
    public class SkillManager : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SkillManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SkillDto>> Add(SkillAddDto skillAddDto, string createdByName)
        {
            var skill = _mapper.Map<Skill>(skillAddDto);
            skill.CreatedByName = createdByName;
            skill.ModifiedByName = createdByName;
            skill.ModifiedTime = DateTime.Now;
            var addedSkill = await _unitOfWork.Skill.AddAsync(skill);
            await _unitOfWork.SaveAsync();
            return new DataResult<SkillDto>(ResultStatus.Success, $"{addedSkill.Title} isimli yetenek başarılı bir şekilde kayıt edilmiştir.", new SkillDto
            {
                Skill = addedSkill,
                Message = $"{addedSkill.Title} isimli yetenek başarılı bir şekilde kayıt edilmiştir.",
                ResultStatus = ResultStatus.Success
            });
        }

        public async Task<IResult> Delete(int skillId, string modifiedByName)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == skillId);
            if (skill != null)
            {
                skill.IsDeleted = true;
                skill.ModifiedByName = modifiedByName;
                skill.ModifiedTime = DateTime.Now;
                await _unitOfWork.Skill.UpdateAsync(skill);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{skill.Title} isimli yetenek başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<SkillDto>> Get(int skillId)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == skillId);
            if (skill != null)
            {
                return new DataResult<SkillDto>(ResultStatus.Success, new SkillDto
                {
                    Skill = skill,
                    ResultStatus = ResultStatus.Success,
                });
            }
            return new DataResult<SkillDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new SkillDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!",
                Skill = null
            });
        }

        public async Task<IDataResult<SkillListDto>> GetAll()
        {
            var skills = await _unitOfWork.Skill.GetAllAsync();
            if (skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SkillListDto
            {
                ResultStatus = ResultStatus.Error,
                Skills = skills,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDelete()
        {
            var skills = await _unitOfWork.Skill.GetAllAsync(x => x.IsDeleted == false);
            if (skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SkillListDto
            {
                ResultStatus = ResultStatus.Error,
                Skills = skills,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SkillListDto>> GetAllByNonDeleteAndActive()
        {
            var skills = await _unitOfWork.Skill.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (skills.Count > -1)
            {
                return new DataResult<SkillListDto>(ResultStatus.Success, new SkillListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Skills = skills
                });
            }
            return new DataResult<SkillListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SkillListDto
            {
                ResultStatus = ResultStatus.Error,
                Skills = skills,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SkillUpdateDto>> GetUpdateDto(int skillId)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == skillId);
            if (skill != null)
            {
                var skillUpdateDto = _mapper.Map<SkillUpdateDto>(skill);
                return new DataResult<SkillUpdateDto>(ResultStatus.Success,skillUpdateDto);
            }
            return new DataResult<SkillUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int skillId)
        {
            var skill = await _unitOfWork.Skill.GetAsync(x => x.Id == skillId);
            if (skill != null)
            {
                await _unitOfWork.Skill.DeleteAsync(skill);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{skill.Title} isimli yetenek başarılı bir şekilde veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<SkillDto>> Update(SkillUpdateDto skillUpdateDto, string modifiedByName)
        {
            var skill = _mapper.Map<Skill>(skillUpdateDto);
            skill.ModifiedByName = modifiedByName;
            var updatedSkill = await _unitOfWork.Skill.UpdateAsync(skill);
            await _unitOfWork.SaveAsync();
            return new DataResult<SkillDto>(ResultStatus.Success, $"{updatedSkill.Title} isimli yetenek başarılı bir şekilde güncellenmiştir.", new SkillDto
            {
                ResultStatus = ResultStatus.Success,
                Skill = updatedSkill,
                Message = $"{updatedSkill.Title} isimli yetenek başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
