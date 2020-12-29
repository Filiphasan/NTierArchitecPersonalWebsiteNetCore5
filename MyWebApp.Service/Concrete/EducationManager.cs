using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.EducationDtos;
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
    public class EducationManager : IEducationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EducationManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<EducationDto>> Add(EducationAddDto educationAddDto, string createdByName)
        {
            var education = _mapper.Map<Education>(educationAddDto);
            education.CreatedByName = createdByName;
            education.ModifiedByName = createdByName;
            education.ModifiedTime = DateTime.Now;
            var addedEducation = await _unitOfWork.Education.AddAsync(education);
            await _unitOfWork.SaveAsync();
            return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto
            {
                Education = addedEducation,
                ResultStatus = ResultStatus.Success,
                Message = "İşlem başarılı.."
            });
        }

        public async Task<IResult> Delete(int educationId, string modifiedByName)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == educationId);
            if (education != null)
            {
                education.IsDeleted = true;
                education.ModifiedTime = DateTime.Now;
                education.ModifiedByName = modifiedByName;
                await _unitOfWork.Education.UpdateAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{education.Title} başlıklı eğitim başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı.");
        }

        public async Task<IDataResult<EducationDto>> Get(int educationId)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == educationId);
            if (education != null)
            {
                return new DataResult<EducationDto>(ResultStatus.Success, new EducationDto
                {
                    ResultStatus = ResultStatus.Success,
                    Education = education
                });
            }
            return new DataResult<EducationDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new EducationDto
            {
                ResultStatus = ResultStatus.Error,
                Education = null,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<EducationListDto>> GetAll()
        {
            var educations = await _unitOfWork.Education.GetAllAsync();
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Educations = educations
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı", new EducationListDto
            {
                ResultStatus = ResultStatus.Error,
                Educations = null,
                Message = "Hata, kayıtlar bulunamadı"
            });
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDelete()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDeleted == false);
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Educations = educations
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı", new EducationListDto
            {
                ResultStatus = ResultStatus.Error,
                Educations = null,
                Message = "Hata, kayıtlar bulunamadı"
            });
        }

        public async Task<IDataResult<EducationListDto>> GetAllByNonDeleteAndActive()
        {
            var educations = await _unitOfWork.Education.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (educations.Count > -1)
            {
                return new DataResult<EducationListDto>(ResultStatus.Success, new EducationListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Educations = educations
                });
            }
            return new DataResult<EducationListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı", new EducationListDto
            {
                ResultStatus = ResultStatus.Error,
                Educations = null,
                Message = "Hata, kayıtlar bulunamadı"
            });
        }

        public async Task<IDataResult<EducationUpdateDto>> GetUpdateDto(int educationId)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == educationId);
            if (education != null)
            {
                var educationUpdateDto = _mapper.Map<EducationUpdateDto>(education);
                return new DataResult<EducationUpdateDto>(ResultStatus.Success,educationUpdateDto);
            }
            return new DataResult<EducationUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int educationId)
        {
            var education = await _unitOfWork.Education.GetAsync(x => x.Id == educationId);
            if (education != null)
            {
                await _unitOfWork.Education.DeleteAsync(education);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{education.Title} başlıklı eğitim veritabanından başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<EducationDto>> Update(EducationUpdateDto educationUpdateDto, string modifiedByName)
        {
            var education = _mapper.Map<Education>(educationUpdateDto);
            education.ModifiedByName = modifiedByName;
            var updatedEducation = await _unitOfWork.Education.UpdateAsync(education);
            await _unitOfWork.SaveAsync();
            return new DataResult<EducationDto>(ResultStatus.Success, $"{updatedEducation.Title} başlıklı eğitim başarılı bir şekilde güncellenmiştir.", new EducationDto
            {
                ResultStatus = ResultStatus.Success,
                Education = updatedEducation,
                Message = $"{updatedEducation.Title} başlıklı eğitim başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
