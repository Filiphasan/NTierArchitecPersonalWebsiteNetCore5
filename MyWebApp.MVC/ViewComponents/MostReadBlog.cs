using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.ArticleDtos;
using MyWebApp.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.ViewComponents
{
    public class MostReadBlog : ViewComponent
    {
        private readonly IArticleService _articleService;

        public MostReadBlog(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var datas = GetArticles().Result;
            return View(datas);
        }
        public async Task<ArticleListDto> GetArticles()
        {
            var articles = await _articleService.Get3MostReadByNonDeleteAndActive();
            return articles.Data;
        }
    }
}
