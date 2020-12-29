using MyWebApp.Entities.Dtos.ArticleDtos;
using MyWebApp.Shared.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Service.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int articleId);
        Task<IDataResult<ArticleUpdateDto>> GetUpdateDto(int articleId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDelete();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActiveWithCategoryId(int categoryId);
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActiveOrderByDescendingId();
        Task<IDataResult<ArticleListDto>> Get3MostReadByNonDeleteAndActive();
        Task<IDataResult<ArticleDto>> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<IDataResult<ArticleDto>> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> AddViews(int articleId);
        Task<IResult> Delete(int articleId, string modifiedByName);
        Task<IResult> HardDelete(int articleId);
    }
}
