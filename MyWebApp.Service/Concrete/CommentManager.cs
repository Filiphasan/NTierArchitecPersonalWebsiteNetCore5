using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.CommentDtos;
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
    public class CommentManager : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CommentManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IDataResult<CommentDto>> Add(CommentAddDto commentAddDto, string createdByName)
        {
            var comment = _mapper.Map<Comment>(commentAddDto);
            comment.CreatedByName = createdByName;
            comment.ModifiedByName = createdByName;
            comment.ModifiedTime = DateTime.Now;
            var addedComment = await _unitOfWork.Comment.AddAsync(comment);
            await _unitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, "İşlem başarılı..", new CommentDto
            {
                Comment = addedComment,
                Message = "İşlem başarılı..",
                ResultStatus = ResultStatus.Success
            });
        }

        public async Task<IResult> Delete(int commentId, string modifiedByName)
        {
            var comment = await _unitOfWork.Comment.GetAsync(x => x.Id == commentId);
            if (comment != null)
            {
                comment.IsDeleted = true;
                comment.ModifiedTime = DateTime.Now;
                comment.ModifiedByName = modifiedByName;
                await _unitOfWork.Comment.UpdateAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "İşlem başarılı..");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IResult> DoActive(int commentId, string modifiedByName)
        {
            var comment = await _unitOfWork.Comment.GetAsync(x => x.Id == commentId);
            if (comment != null)
            {
                comment.IsActive = true;
                await _unitOfWork.Comment.UpdateAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{comment.FirstName} isimli kişinin yorumu başarılı bir şekilde onaylanmıştır.");
            }
            return new Result(ResultStatus.Error,"Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<CommentDto>> Get(int commentId)
        {
            var comment = await _unitOfWork.Comment.GetAsync(x => x.Id == commentId,x => x.Article);
            if (comment != null)
            {
                return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto
                {
                    Comment = comment,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new CommentDto
            {
                Comment = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAll()
        {
            var comments = await _unitOfWork.Comment.GetAllAsync(null,x => x.Article);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new CommentListDto
            {
                ResultStatus = ResultStatus.Error,
                Comments = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllByNonDelete()
        {
            var comments = await _unitOfWork.Comment.GetAllAsync(x => x.IsDeleted == false, x => x.Article);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new CommentListDto
            {
                ResultStatus = ResultStatus.Error,
                Comments = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<CommentListDto>> GetAllByNonDeleteAndActive()
        {
            var comments = await _unitOfWork.Comment.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true, x => x.Article);
            if (comments.Count > -1)
            {
                return new DataResult<CommentListDto>(ResultStatus.Success, new CommentListDto
                {
                    Comments = comments,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<CommentListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new CommentListDto
            {
                ResultStatus = ResultStatus.Error,
                Comments = null,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<CommentUpdateDto>> GetUpdateDto(int commentId)
        {
            var comment = await _unitOfWork.Comment.GetAsync(x => x.Id == commentId, x => x.Article);
            if (comment != null)
            {
                var commentUpdateDto = _mapper.Map<CommentUpdateDto>(comment);
                return new DataResult<CommentUpdateDto>(ResultStatus.Success,commentUpdateDto);
            }
            return new DataResult<CommentUpdateDto>(ResultStatus.Error,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int commentId)
        {
            var comment = await _unitOfWork.Comment.GetAsync(x => x.Id == commentId);
            if (comment != null)
            {
                await _unitOfWork.Comment.DeleteAsync(comment);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "İşlem başarılı..");
            }
            return new Result(ResultStatus.Error, "Hata kayıt bulunamadı!");
        }

        public async Task<IDataResult<CommentDto>> Update(CommentUpdateDto commentUpdateDto, string modifiedByName)
        {
            var comment = _mapper.Map<Comment>(commentUpdateDto);
            comment.ModifiedByName = modifiedByName;
            var updatedComment = await _unitOfWork.Comment.UpdateAsync(comment);
            await _unitOfWork.SaveAsync();
            return new DataResult<CommentDto>(ResultStatus.Success, new CommentDto
            {
                Comment = updatedComment,
                ResultStatus = ResultStatus.Success,

            });
        }
    }
}
