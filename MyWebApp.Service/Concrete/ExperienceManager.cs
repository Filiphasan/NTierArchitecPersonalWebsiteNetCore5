using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.ExperienceDtos;
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
    public class ExperienceManager : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExperienceManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ExperienceDto>> Add(ExperienceAddDto experienceAddDto, string createdByName)
        {
            var experience = _mapper.Map<Experience>(experienceAddDto);
            experience.CreatedByName = createdByName;
            experience.ModifiedByName = createdByName;
            experience.ModifiedTime = DateTime.Now;
            var addedExperience = await _unitOfWork.Experience.AddAsync(experience);
            await _unitOfWork.SaveAsync();
            return new DataResult<ExperienceDto>(ResultStatus.Success, $"{addedExperience.Title} başlıklı deneyim başarılı bir şekilde kayıt edilmiştir.", new ExperienceDto
            {
                Experience = addedExperience,
                Message = $"{addedExperience.Title} başlıklı deneyim başarılı bir şekilde kayıt edilmiştir.",
                ResultStatus = ResultStatus.Success
            });
        }

        public async Task<IResult> Delete(int experienceId, string modifiedByName)
        {
            var experience = await _unitOfWork.Experience.GetAsync(x => x.Id == experienceId);
            if (experience != null)
            {
                experience.ModifiedByName = modifiedByName;
                experience.ModifiedTime = DateTime.Now;
                experience.IsDeleted = true;
                await _unitOfWork.Experience.UpdateAsync(experience);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim başarılı bir şekilde slinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<ExperienceDto>> Get(int experienceId)
        {
            var experience = await _unitOfWork.Experience.GetAsync(x => x.Id == experienceId);
            if (experience != null)
            {
                return new DataResult<ExperienceDto>(ResultStatus.Success, new ExperienceDto
                {
                    ResultStatus = ResultStatus.Success,
                    Experience = experience,

                });
            }
            return new DataResult<ExperienceDto>(ResultStatus.Error, "Hata, kayıt bulunamdı!", new ExperienceDto
            {
                ResultStatus = ResultStatus.Error,
                Experience = null,
                Message = "Hata, kayıt bulunamdı!"
            });
        }

        public async Task<IDataResult<ExperienceListDto>> GetAll()
        {
            var experiences = await _unitOfWork.Experience.GetAllAsync();
            if (experiences.Count > -1)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Experiences = experiences
                });
            }
            return new DataResult<ExperienceListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ExperienceListDto
            {
                Experiences = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDelete()
        {
            var experiences = await _unitOfWork.Experience.GetAllAsync(x => x.IsDeleted == false);
            if (experiences.Count > -1)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Experiences = experiences
                });
            }
            return new DataResult<ExperienceListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ExperienceListDto
            {
                Experiences = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ExperienceListDto>> GetAllByNonDeleteAndActive()
        {
            var experiences = await _unitOfWork.Experience.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (experiences.Count > -1)
            {
                return new DataResult<ExperienceListDto>(ResultStatus.Success, new ExperienceListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Experiences = experiences
                });
            }
            return new DataResult<ExperienceListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ExperienceListDto
            {
                Experiences = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ExperienceUpdateDto>> GetUpdateDto(int experienceId)
        {
            var experience = await _unitOfWork.Experience.GetAsync(x => x.Id == experienceId);
            if (experience != null)
            {
                var experienceUpdateDto = _mapper.Map<ExperienceUpdateDto>(experience);
                return new DataResult<ExperienceUpdateDto>(ResultStatus.Success,experienceUpdateDto);
            }
            return new DataResult<ExperienceUpdateDto>(ResultStatus.Success,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int experienceId)
        {
            var experience = await _unitOfWork.Experience.GetAsync(x => x.Id == experienceId);
            if (experience != null)
            {
                await _unitOfWork.Experience.DeleteAsync(experience);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{experience.Title} başlıklı deneyim başarılı bir şekilde veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<ExperienceDto>> Update(ExperienceUpdateDto experienceUpdateDto, string modifiedByName)
        {
            var experience = _mapper.Map<Experience>(experienceUpdateDto);
            experience.ModifiedByName = modifiedByName;
            var updatedExperience = await _unitOfWork.Experience.UpdateAsync(experience);
            await _unitOfWork.SaveAsync();
            return new DataResult<ExperienceDto>(ResultStatus.Success, $"{updatedExperience.Title} başlıklı deneyim başarılı bir şekilde güncellenmiştir.", new ExperienceDto
            {
                ResultStatus = ResultStatus.Success,
                Experience = updatedExperience,
                Message = $"{updatedExperience.Title} başlıklı deneyim başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
