using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.ContactInfoDtos;
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
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactInfoManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<IResult> Delete(int contactInfoId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ContactInfoDto>> Get(int contactInfoId = 1)
        {
            var contactInfo = await _unitOfWork.ContactInfo.GetAsync(x => x.Id == contactInfoId);
            if (contactInfo != null)
            {
                return new DataResult<ContactInfoDto>(ResultStatus.Success, new ContactInfoDto
                {
                    ContactInfo = contactInfo,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ContactInfoDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new ContactInfoDto
            {
                ContactInfo = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<ContactInfoUpdateDto>> GetUpdateDto(int contactInfoId)
        {
            var contactInfo = await _unitOfWork.ContactInfo.GetAsync(x => x.Id == contactInfoId);
            if (contactInfo != null)
            {
                var contactInfoUpdateDto = _mapper.Map<ContactInfoUpdateDto>(contactInfo);
                return new DataResult<ContactInfoUpdateDto>(ResultStatus.Success,contactInfoUpdateDto);
            }
            return new DataResult<ContactInfoUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public Task<IResult> HardDelete(int contactInfoId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ContactInfoDto>> Update(ContactInfoUpdateDto contactInfoUpdateDto, string modifiedByName)
        {
            var contactInfo = _mapper.Map<ContactInfo>(contactInfoUpdateDto);
            contactInfo.ModifiedByName = modifiedByName;
            var updatedContactInfo = await _unitOfWork.ContactInfo.UpdateAsync(contactInfo);
            await _unitOfWork.SaveAsync();
            return new DataResult<ContactInfoDto>(ResultStatus.Success, new ContactInfoDto
            {
                ContactInfo = updatedContactInfo,
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
