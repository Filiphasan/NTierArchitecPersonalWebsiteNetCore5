using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.HomePageSliderDtos;
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
    public class HomePageSliderManager : IHomePageSliderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public HomePageSliderManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<HomePageSliderDto>> Add(HomePageSliderAddDto homePageSliderAddDto, string createdByName)
        {
            var slider = _mapper.Map<HomePageSlider>(homePageSliderAddDto);
            slider.CreatedByName = createdByName;
            slider.ModifiedByName = createdByName;
            slider.ModifiedTime = DateTime.Now;
            var addedSlider = await _unitOfWork.HomePageSlider.AddAsync(slider);
            await _unitOfWork.SaveAsync();
            return new DataResult<HomePageSliderDto>(ResultStatus.Success, $"{addedSlider.Title} başlıklı slider başarılı bir şekilde kayıt edilmiştir.", new HomePageSliderDto
            {
                HomePageSlider = addedSlider,
                Message = $"{addedSlider.Title} başlıklı slider başarılı bir şekilde kayıt edilmiştir.",
                ResultStatus = ResultStatus.Success
            });
        }

        public async Task<IResult> Delete(int homePageSliderId, string modifiedByName)
        {
            var slider = await _unitOfWork.HomePageSlider.GetAsync(x => x.Id == homePageSliderId);
            if (slider != null)
            {
                slider.IsDeleted = true;
                slider.ModifiedByName = modifiedByName;
                slider.ModifiedTime = DateTime.Now;
                await _unitOfWork.HomePageSlider.UpdateAsync(slider);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{slider.Title} başlıklı slider başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<HomePageSliderDto>> Get(int homePageSliderId)
        {
            var slider = await _unitOfWork.HomePageSlider.GetAsync(x => x.Id == homePageSliderId);
            if (slider != null)
            {
                return new DataResult<HomePageSliderDto>(ResultStatus.Success, new HomePageSliderDto
                {
                    ResultStatus = ResultStatus.Success,
                    HomePageSlider = slider,

                });
            }
            return new DataResult<HomePageSliderDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new HomePageSliderDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!",
                HomePageSlider = null
            });
        }

        public async Task<IDataResult<HomePageSliderListDto>> GetAll()
        {
            var sliders = await _unitOfWork.HomePageSlider.GetAllAsync();
            if (sliders.Count > -1)
            {
                return new DataResult<HomePageSliderListDto>(ResultStatus.Success, new HomePageSliderListDto
                {
                    ResultStatus = ResultStatus.Success,
                    HomePageSliders = sliders,
                });
            }
            return new DataResult<HomePageSliderListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new HomePageSliderListDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!",
                HomePageSliders = null
            });
        }

        public async Task<IDataResult<HomePageSliderListDto>> GetAllByNonDelete()
        {
            var sliders = await _unitOfWork.HomePageSlider.GetAllAsync(x => x.IsDeleted == false);
            if (sliders.Count > -1)
            {
                return new DataResult<HomePageSliderListDto>(ResultStatus.Success, new HomePageSliderListDto
                {
                    ResultStatus = ResultStatus.Success,
                    HomePageSliders = sliders,
                });
            }
            return new DataResult<HomePageSliderListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new HomePageSliderListDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!",
                HomePageSliders = null
            });
        }

        public async Task<IDataResult<HomePageSliderListDto>> GetAllByNonDeleteAndActive()
        {
            var sliders = await _unitOfWork.HomePageSlider.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (sliders.Count > -1)
            {
                return new DataResult<HomePageSliderListDto>(ResultStatus.Success, new HomePageSliderListDto
                {
                    ResultStatus = ResultStatus.Success,
                    HomePageSliders = sliders,
                });
            }
            return new DataResult<HomePageSliderListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new HomePageSliderListDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!",
                HomePageSliders = null
            });
        }

        public async Task<IDataResult<HomePageSliderUpdateDto>> GetUpdateDto(int homePageSliderId)
        {
            var slider = await _unitOfWork.HomePageSlider.GetAsync(x => x.Id == homePageSliderId);
            if (slider != null)
            {
                var sliderUpdateDto = _mapper.Map<HomePageSliderUpdateDto>(slider);
                return new DataResult<HomePageSliderUpdateDto>(ResultStatus.Success,sliderUpdateDto);
            }
            return new DataResult<HomePageSliderUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int homePageSliderId)
        {
            var slider = await _unitOfWork.HomePageSlider.GetAsync(x => x.Id == homePageSliderId);
            if (slider != null)
            {
                await _unitOfWork.HomePageSlider.DeleteAsync(slider);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{slider.Title} başlıklı slider başarılı bir şekilde veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<HomePageSliderDto>> Update(HomePageSliderUpdateDto homePageSliderUpdateDto, string modifiedByName)
        {
            var slider = _mapper.Map<HomePageSlider>(homePageSliderUpdateDto);
            slider.ModifiedByName = modifiedByName;
            var updatedSlider = await _unitOfWork.HomePageSlider.UpdateAsync(slider);
            await _unitOfWork.SaveAsync();
            return new DataResult<HomePageSliderDto>(ResultStatus.Success, $"{updatedSlider.Title} başlıklı slider başarılı bir şekilde güncellenmiştir.", new HomePageSliderDto
            {
                HomePageSlider = slider,
                ResultStatus = ResultStatus.Success,
                Message = $"{updatedSlider.Title} başlıklı slider başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
