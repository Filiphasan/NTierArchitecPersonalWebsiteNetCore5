using MyWebApp.Entities.Dtos.MessageDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IMessageService
    {
        Task<IDataResult<MessageDto>> Get(int messageId);
        Task<IDataResult<MessageUpdateDto>> GetUpdateDto(int messageId);
        Task<IDataResult<MessageListDto>> GetAll();
        Task<IDataResult<MessageListDto>> GetAllByNonDelete();
        Task<IDataResult<MessageListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<MessageDto>> Add(MessageAddDto messageAddDto, string createdByName);
        Task<IDataResult<MessageDto>> Update(MessageUpdateDto messageUpdateDto, string modifiedByName);
        Task<IResult> CheckMessage(int messageId, string modifiedByName);
        Task<IResult> Delete(int messageId, string modifiedByName);
        Task<IResult> HardDelete(int messageId);
    }
}
