using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.SocialMediaAccountDtos;
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
    public class SocialMediaAccountManager : ISocialMediaAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SocialMediaAccountManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SocialMediaAccountDto>> Add(SocialMediaAccountAddDto socialMediaAccountAddDto, string createdByName)
        {
            var account = _mapper.Map<SocialMediaAccount>(socialMediaAccountAddDto);
            account.CreatedByName = createdByName;
            account.ModifiedByName = createdByName;
            account.ModifiedTime = DateTime.Now;
            var addedAccount = await _unitOfWork.SocialMediaAccount.AddAsync(account);
            await _unitOfWork.SaveAsync();
            return new DataResult<SocialMediaAccountDto>(ResultStatus.Success, "Sosyal medya hesabı başarılı bir şekilde kayıt edilmiştir.", new SocialMediaAccountDto
            {
                Message = "Sosyal medya hesabı başarılı bir şekilde kayıt edilmiştir.",
                ResultStatus = ResultStatus.Success,
                SocialMediaAccount = addedAccount
            });
        }

        public async Task<IResult> Delete(int socialMediaAccountId, string modifiedByName)
        {
            var account = await _unitOfWork.SocialMediaAccount.GetAsync(x => x.Id == socialMediaAccountId);
            if (account != null)
            {
                account.IsDeleted = true;
                account.ModifiedTime = DateTime.Now;
                account.ModifiedByName = modifiedByName;
                await _unitOfWork.SocialMediaAccount.UpdateAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"Sosyal medya bilgisi başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kaynak bulunamadı!");
        }

        public async Task<IDataResult<SocialMediaAccountDto>> Get(int socialMediaAccountId)
        {
            var account = await _unitOfWork.SocialMediaAccount.GetAsync(x => x.Id == socialMediaAccountId);
            if (account != null)
            {
                return new DataResult<SocialMediaAccountDto>(ResultStatus.Success, new SocialMediaAccountDto
                {
                    ResultStatus = ResultStatus.Success,
                    SocialMediaAccount = account
                });
            }
            return new DataResult<SocialMediaAccountDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new SocialMediaAccountDto
            {
                ResultStatus = ResultStatus.Error,
                SocialMediaAccount = null,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<SocialMediaAccountListDto>> GetAll()
        {
            var accounts = await _unitOfWork.SocialMediaAccount.GetAllAsync();
            if (accounts.Count > -1)
            {
                return new DataResult<SocialMediaAccountListDto>(ResultStatus.Success, new SocialMediaAccountListDto
                {
                    ResultStatus = ResultStatus.Success,
                    SocialMediaAccounts = accounts
                });
            }
            return new DataResult<SocialMediaAccountListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SocialMediaAccountListDto
            {
                ResultStatus = ResultStatus.Error,
                SocialMediaAccounts = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SocialMediaAccountListDto>> GetAllByNonDelete()
        {
            var accounts = await _unitOfWork.SocialMediaAccount.GetAllAsync(x => x.IsDeleted == false);
            if (accounts.Count > -1)
            {
                return new DataResult<SocialMediaAccountListDto>(ResultStatus.Success, new SocialMediaAccountListDto
                {
                    ResultStatus = ResultStatus.Error,
                    SocialMediaAccounts = accounts
                });
            }
            return new DataResult<SocialMediaAccountListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SocialMediaAccountListDto
            {
                ResultStatus = ResultStatus.Error,
                SocialMediaAccounts = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SocialMediaAccountListDto>> GetAllByNonDeleteAndActive()
        {
            var accounts = await _unitOfWork.SocialMediaAccount.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true);
            if (accounts.Count > -1)
            {
                return new DataResult<SocialMediaAccountListDto>(ResultStatus.Success, new SocialMediaAccountListDto
                {
                    ResultStatus = ResultStatus.Error,
                    SocialMediaAccounts = accounts
                });
            }
            return new DataResult<SocialMediaAccountListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new SocialMediaAccountListDto
            {
                ResultStatus = ResultStatus.Error,
                SocialMediaAccounts = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<SocialMediaAccountUpdateDto>> GetUpdateDto(int socialMediaAccountId)
        {
            var account = await _unitOfWork.SocialMediaAccount.GetAsync(x => x.Id == socialMediaAccountId);
            if (account != null)
            {
                var accountUpdateDto = _mapper.Map<SocialMediaAccountUpdateDto>(account);
                return new DataResult<SocialMediaAccountUpdateDto>(ResultStatus.Success,accountUpdateDto);
            }
            return new DataResult<SocialMediaAccountUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int socialMediaAccountId)
        {
            var account = await _unitOfWork.SocialMediaAccount.GetAsync(x => x.Id == socialMediaAccountId);
            if (account != null)
            {
                await _unitOfWork.SocialMediaAccount.DeleteAsync(account);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"Sosyal medya hesabı başarılı bir şekilde güncellenmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<SocialMediaAccountDto>> Update(SocialMediaAccountUpdateDto socialMediaAccountUpdateDto, string modifiedByName)
        {
            var account = _mapper.Map<SocialMediaAccount>(socialMediaAccountUpdateDto);
            account.ModifiedByName = modifiedByName;
            var updatedAccount = await _unitOfWork.SocialMediaAccount.UpdateAsync(account);
            await _unitOfWork.SaveAsync();
            return new DataResult<SocialMediaAccountDto>(ResultStatus.Success, "Sosyal medya hesabı başarılı bir şekilde güncellenmiştir.", new SocialMediaAccountDto
            {
                ResultStatus = ResultStatus.Success,
                SocialMediaAccount = updatedAccount,
                Message = "Sosyal medya hesabı başarılı bir şekilde güncellenmiştir."
            });
        }
    }
}
