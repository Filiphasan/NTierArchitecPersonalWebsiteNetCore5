using MyWebApp.Entities.Dtos.CommentDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface ICommentService
    {
        Task<IDataResult<CommentDto>> Get(int commentId);
        Task<IDataResult<CommentUpdateDto>> GetUpdateDto(int commentId);
        Task<IDataResult<CommentListDto>> GetAll();
        Task<IDataResult<CommentListDto>> GetAllByNonDelete();
        Task<IDataResult<CommentListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<CommentDto>> Add(CommentAddDto commentAddDto, string createdByName);
        Task<IDataResult<CommentDto>> Update(CommentUpdateDto commentUpdateDto, string modifiedByName);
        Task<IResult> DoActive(int commentId, string modifiedByName);
        Task<IResult> Delete(int commentId, string modifiedByName);
        Task<IResult> HardDelete(int commentId);
    }
}
