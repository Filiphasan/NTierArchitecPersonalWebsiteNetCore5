using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.InterestedDtos;
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
    public class InterestedManager : IInterestedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InterestedManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<InterestedDto>> Add(InterestedAddDto interestedAddDto, string createdByName)
        {
            var interested = _mapper.Map<Interested>(interestedAddDto);
            interested.CreatedByName = createdByName;
            interested.ModifiedByName = createdByName;
            interested.ModifiedTime = DateTime.Now;
            var addedInterested = await _unitOfWork.Interested.AddAsync(interested);
            await _unitOfWork.SaveAsync();
            return new DataResult<InterestedDto>(ResultStatus.Success, $"{interested.Text} hobisi başarılı bir şekilde kayıt edilmiştir.", new InterestedDto
            {
                Interested = addedInterested,
                ResultStatus = ResultStatus.Success,
                Message = $"{interested.Text} hobisi başarılı bir şekilde kayıt edilmiştir."
            });
        }

        public async Task<IResult> Delete(int interestedId, string modifiedByName)
        {
            var interested = await _unitOfWork.Interested.GetAsync(x => x.Id == interestedId);
            if (interested != null)
            {
                interested.IsDeleted = true;
                interested.ModifiedTime = DateTime.Now;
                interested.ModifiedByName = modifiedByName;
                await _unitOfWork.Interested.UpdateAsync(interested);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{interested.Text} hobisi başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<InterestedDto>> Get(int interestedId)
        {
            var interested = await _unitOfWork.Interested.GetAsync(x => x.Id == interestedId);
            if (interested != null)
            {
                return new DataResult<InterestedDto>(ResultStatus.Success, new InterestedDto
                {
                    ResultStatus = ResultStatus.Success,
                    Interested = interested,
                });
            }
            return new DataResult<InterestedDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new InterestedDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!",
                Interested = null
            });
        }

        public async Task<IDataResult<InterestedListDto>> GetAll()
        {
            var interesteds = await _unitOfWork.Interested.GetAllAsync();
            if (interesteds.Count > -1)
            {
                return new DataResult<InterestedListDto>(ResultStatus.Success, new InterestedListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Interesteds = interesteds
                });
            }
            return new DataResult<InterestedListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new InterestedListDto
            {
                ResultStatus = ResultStatus.Error,
                Interesteds = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<InterestedListDto>> GetAllByNonDelete()
        {
            var interesteds = await _unitOfWork.Interested.GetAllAsync(x => x.IsDeleted == false);
            if (interesteds.Count > -1)
            {
                return new DataResult<InterestedListDto>(ResultStatus.Success, new InterestedListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Interesteds = interesteds
                });
            }
            return new DataResult<InterestedListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new InterestedListDto
            {
                ResultStatus = ResultStatus.Error,
                Interesteds = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<InterestedListDto>> GetAllByNonDeleteAndActive()
        {
            var interesteds = await _unitOfWork.Interested.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (interesteds.Count > -1)
            {
                return new DataResult<InterestedListDto>(ResultStatus.Success, new InterestedListDto
                {
                    ResultStatus = ResultStatus.Success,
                    Interesteds = interesteds
                });
            }
            return new DataResult<InterestedListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new InterestedListDto
            {
                ResultStatus = ResultStatus.Error,
                Interesteds = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<InterestedUpdateDto>> GetUpdateDto(int interestedDto)
        {
            var interested = await _unitOfWork.Interested.GetAsync(x => x.Id == interestedDto);
            if (interested != null)
            {
                var interestedUpdateDto = _mapper.Map<InterestedUpdateDto>(interested);
                return new DataResult<InterestedUpdateDto>(ResultStatus.Success,interestedUpdateDto);
            }
            return new DataResult<InterestedUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }


        public async Task<IResult> HardDelete(int interestedId)
        {
            var interested = await _unitOfWork.Interested.GetAsync(x => x.Id == interestedId);
            if (interested != null)
            {
                await _unitOfWork.Interested.DeleteAsync(interested);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{interested.Text} hobisi başarılı bir şekilde veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<InterestedDto>> Update(InterestedUpdateDto ınterestedUpdateDto, string modifiedByName)
        {
            var interested = _mapper.Map<Interested>(ınterestedUpdateDto);
            interested.ModifiedByName = modifiedByName;
            var updatedInterested = await _unitOfWork.Interested.UpdateAsync(interested);
            await _unitOfWork.SaveAsync();
            return new DataResult<InterestedDto>(ResultStatus.Success, $"{updatedInterested.Text} hobisi başarılı bir şekilde güncellenmiştir.", new InterestedDto
            {
                ResultStatus = ResultStatus.Success,
                Interested = updatedInterested,
                Message = $"{updatedInterested.Text} hobisi başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
