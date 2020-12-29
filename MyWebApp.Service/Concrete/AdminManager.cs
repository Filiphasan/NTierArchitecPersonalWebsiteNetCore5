using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.AdminDtos;
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
    public class AdminManager : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AdminManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public Task<IResult> Delete(int categoryId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<AdminDto>> Get(int aboutMeId = 1)
        {
            var admin = await _unitOfWork.Admin.GetAsync(x => x.Id == aboutMeId);
            return new DataResult<AdminDto>(ResultStatus.Success, new AdminDto
            {
                Admin = admin,
                ResultStatus = ResultStatus.Success,
                Message = "İşlem başarılı."
            });
        }

        public async Task<IDataResult<AdminUpdateDto>> GetUpdateDto(int adminId)
        {
            var admin = await _unitOfWork.Admin.GetAsync(x => x.Id == adminId);
            if (admin != null)
            {
                var adminUpdateDto = _mapper.Map<AdminUpdateDto>(admin);
                return new DataResult<AdminUpdateDto>(ResultStatus.Success,adminUpdateDto);
            }
            return new DataResult<AdminUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<AdminDto>> Update(AdminUpdateDto adminUpdateDto, string modifiedByName)
        {
            var admin = _mapper.Map<Admin>(adminUpdateDto);
            admin.ModifiedByName = modifiedByName;
            var updatedAdmin = await _unitOfWork.Admin.UpdateAsync(admin);
            await _unitOfWork.SaveAsync();
            return new DataResult<AdminDto>(ResultStatus.Success, new AdminDto
            {
                Admin = admin,
                ResultStatus = ResultStatus.Success,
                Message = "İşlem başarılı."
            });
        }
    }
}
