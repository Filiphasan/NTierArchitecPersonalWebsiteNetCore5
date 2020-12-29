using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.AboutMeDtos;
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
    public class AboutMeManager : IAboutMeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AboutMeManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            var result = await _unitOfWork.AboutMe.AnyAsync(x => x.Id == categoryId);
            if (result)
            {
                var aboutMe = await _unitOfWork.AboutMe.GetAsync(x => x.Id == categoryId);
                aboutMe.IsDeleted = true;
                aboutMe.ModifiedByName = modifiedByName;
                aboutMe.ModifiedTime = DateTime.Now;
                await _unitOfWork.AboutMe.UpdateAsync(aboutMe);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"Hakkımda bilgisi başarılı bir şekilde güncellenmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, Kayıt bulunamadı!");
        }

        public async Task<IDataResult<AboutMeDto>> Get(int aboutMeId)
        {
            var aboutMe = await _unitOfWork.AboutMe.GetAsync(x => x.Id == aboutMeId);
            if (aboutMe != null)
            {
                return new DataResult<AboutMeDto>(ResultStatus.Success, new AboutMeDto
                {
                    AboutMe = aboutMe,
                    ResultStatus = ResultStatus.Success,
                    Message = "İşlem Başarılı."
                });
            }
            return new DataResult<AboutMeDto>(ResultStatus.Error, new AboutMeDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, Kayıt bulunamadı!",
                AboutMe = null
            });
        }

        public async Task<IDataResult<AboutMeUpdateDto>> GetUpdateDto(int aboutMeId)
        {
            var aboutMe = await _unitOfWork.AboutMe.GetAsync(x => x.Id == aboutMeId);
            if (aboutMe != null)
            {
                var aboutMeUpdatedDto = _mapper.Map<AboutMeUpdateDto>(aboutMe);
                return new DataResult<AboutMeUpdateDto>(ResultStatus.Success, aboutMeUpdatedDto);
            }
            return new DataResult<AboutMeUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int categoryId)
        {
            return new Result(ResultStatus.Success, "Maalesef silinemez!");
        }

        public async Task<IDataResult<AboutMeDto>> Update(AboutMeUpdateDto aboutMeUpdateDto, string modifiedByName)
        {
            var aboutMe = _mapper.Map<AboutMe>(aboutMeUpdateDto);
            aboutMe.ModifiedByName = modifiedByName;
            var updatedAboutMe = await _unitOfWork.AboutMe.UpdateAsync(aboutMe);
            await _unitOfWork.SaveAsync();
            return new DataResult<AboutMeDto>(ResultStatus.Success, "Hakkımda bilgisi başarıyla güncellenmiştir.", new AboutMeDto
            {
                ResultStatus = ResultStatus.Success,
                AboutMe = updatedAboutMe,
                Message = "Hakkımda bilgisi başarıyla güncellenmiştir."
            });
        }
    }
}
