using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SiteIdentityDtos;
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
    public class SiteIdentityManager : ISiteIdentityService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SiteIdentityManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> Delete(int siteIdentityId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SiteIdentityDto>> Get(int siteIdentityId = 1)
        {
            var siteIdentity = await _unitOfWork.SiteIdentity.GetAsync(x => x.Id == siteIdentityId);
            if (siteIdentity != null)
            {
                return new DataResult<SiteIdentityDto>(ResultStatus.Success, new SiteIdentityDto
                {
                    ResultStatus = ResultStatus.Success,
                    SiteIdentity = siteIdentity
                });
            }
            return new DataResult<SiteIdentityDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new SiteIdentityDto
            {
                ResultStatus = ResultStatus.Error,
                SiteIdentity = null,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<SiteIdentityUpdateDto>> GetUpdateDto(int siteIdentityId)
        {
            var identity = await _unitOfWork.SiteIdentity.GetAsync(x => x.Id == siteIdentityId);
            if (identity != null)
            {
                var identityUpdateDto = _mapper.Map<SiteIdentityUpdateDto>(identity);
                return new DataResult<SiteIdentityUpdateDto>(ResultStatus.Success,identityUpdateDto);
            }
            return new DataResult<SiteIdentityUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int siteIdentityId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<SiteIdentityDto>> Update(SiteIdentityUpdateDto siteIdentityUpdateDto, string modifiedByName)
        {
            var siteIdentity = _mapper.Map<SiteIdentity>(siteIdentityUpdateDto);
            siteIdentity.ModifiedByName = modifiedByName;
            var updatedSiteIdentity = await _unitOfWork.SiteIdentity.UpdateAsync(siteIdentity);
            await _unitOfWork.SaveAsync();
            return new DataResult<SiteIdentityDto>(ResultStatus.Success, "Site kimlik bilgileri başarılı bir şekilde güncellenmiştir.", new SiteIdentityDto
            {
                ResultStatus = ResultStatus.Success,
                Message = "Site kimlik bilgileri başarılı bir şekilde güncellenmiştir.",
                SiteIdentity = updatedSiteIdentity
            });
        }
    }
}
