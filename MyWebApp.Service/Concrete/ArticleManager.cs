using AutoMapper;
using MyWebApp.Data.Abstract;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.ArticleDtos;
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
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<ArticleDto>> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            var article = _mapper.Map<Article>(articleAddDto);
            article.CreatedByName = createdByName;
            article.ModifiedByName = createdByName;
            var addedArticle = await _unitOfWork.Article.AddAsync(article);
            await _unitOfWork.SaveAsync();
            return new DataResult<ArticleDto>(ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başarılı bir şekilde kayıt edilmiştir!", new ArticleDto
            {
                Article = addedArticle,
                ResultStatus = ResultStatus.Success,
                Message = $"{articleAddDto.Title} başlıklı makale başarılı bir şekilde kayıt edilmiştir!"
            });
        }

        public async Task<IResult> AddViews(int articleId)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == articleId);
            if (article != null)
            {
                article.ViewsCount = article.ViewsCount + 1;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success);
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IResult> Delete(int articleId, string modifiedByName)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == articleId);
            if (article != null)
            {
                article.IsDeleted = true;
                article.ModifiedByName = modifiedByName;
                article.ModifiedTime = DateTime.Now;
                await _unitOfWork.Article.UpdateAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{article.Title} başlıklı makale başarılı bir şekilde silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == articleId, x => x.Category,x => x.Comments);
            if (article != null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article = article,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error, "Hata, kayıt bulunamadı!", new ArticleDto
            {
                Article = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıt bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> Get3MostReadByNonDeleteAndActive()
        {
            var articles = await _unitOfWork.Article.Get3MostReadAsync(x => x.IsDeleted == false && x.IsActive == true, x => x.Category, x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(null, x => x.Category, x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDelete()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(x => x.IsDeleted == false, x => x.Category, x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActive()
        {
            var articles = await _unitOfWork.Article.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true, x => x.Category, x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActiveOrderByDescendingId()
        {
            var articles = await _unitOfWork.Article.GetAllOrderByDescIdAsync(x => x.IsDeleted == false && x.IsActive == true,x => x.Category,x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleteAndActiveWithCategoryId(int categoryId)
        {
            var articles = await _unitOfWork.Article.GetAllAsync(x => x.IsDeleted == false && x.IsActive == true && x.CategoryId==categoryId, x => x.Category, x => x.Comments);
            if (articles.Count > -1)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Hata, kayıtlar bulunamadı!", new ArticleListDto
            {
                Articles = null,
                ResultStatus = ResultStatus.Error,
                Message = "Hata, kayıtlar bulunamadı!"
            });
        }

        public async Task<IDataResult<ArticleUpdateDto>> GetUpdateDto(int articleId)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == articleId,x => x.Category, x => x.Comments);
            if (article != null)
            {
                var articleUpdateDto = _mapper.Map<ArticleUpdateDto>(article);
                return new DataResult<ArticleUpdateDto>(ResultStatus.Success,articleUpdateDto);
            }
            return new DataResult<ArticleUpdateDto>(ResultStatus.Success,"Hata, kayıt bulunamadı!",null);
        }

        public async Task<IResult> HardDelete(int articleId)
        {
            var article = await _unitOfWork.Article.GetAsync(x => x.Id == articleId);
            if (article != null)
            {
                await _unitOfWork.Article.DeleteAsync(article);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, $"{article.Title} başlıklı makale başarılı bir şekilde veritabanından silinmiştir.");
            }
            return new Result(ResultStatus.Error, "Hata, kayıt bulunamadı!");
        }

        public async Task<IDataResult<ArticleDto>> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            var article = _mapper.Map<Article>(articleUpdateDto);
            article.ModifiedByName = modifiedByName;
            var updatedArticle = await _unitOfWork.Article.UpdateAsync(article);
            await _unitOfWork.SaveAsync();
            return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
            {
                Article = updatedArticle,
                ResultStatus = ResultStatus.Success
            });
        }
    }
}
