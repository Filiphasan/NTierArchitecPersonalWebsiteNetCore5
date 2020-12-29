
using MyWebApp.Entities.Dtos.AdminDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IAdminService
    {
        Task<IDataResult<AdminDto>> Get(int adminId);
        Task<IDataResult<AdminUpdateDto>> GetUpdateDto(int adminId);
        Task<IDataResult<AdminDto>> Update(AdminUpdateDto adminUpdateDto, string modifiedByName);
        Task<IResult> Delete(int adminId, string modifiedByName);
        Task<IResult> HardDelete(int adminId);
    }
}
