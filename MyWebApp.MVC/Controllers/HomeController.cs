using Microsoft.AspNetCore.Mvc;
using MyWebApp.Data.Concrete.EntityFramework.Contexts;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList.Core;
using MyWebApp.Entities.Dtos.ArticleDtos;
using MyWebApp.Entities.Dtos.MessageDtos;
using MyWebApp.Entities.Concrete;
using MyWebApp.Entities.Dtos.CommentDtos;
using MyWebApp.Shared.Helpers.SeoHelper;

namespace MyWebApp.MVC.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IHomePageSliderService _homePageSliderService;
        private readonly ISiteIdentityService _siteIdentityService;
        private readonly IAboutMeService _aboutMeService;
        private readonly IContactInfoService _contactInfoService;
        private readonly IArticleService _articleService;
        private readonly IMessageService _messageService;
        private readonly ICommentService _commentService;

        public HomeController(IHomePageSliderService homePageSliderService, ISiteIdentityService siteIdentityService, IAboutMeService aboutMeService, IContactInfoService contactInfoService, IArticleService articleService, IMessageService messageService, ICommentService commentService)
        {
            _homePageSliderService = homePageSliderService;
            _siteIdentityService = siteIdentityService;
            _aboutMeService = aboutMeService;
            _contactInfoService = contactInfoService;
            _articleService = articleService;
            _messageService = messageService;
            _commentService = commentService;
        }

        [Route("")]
        [Route("anasayfa")]
        public async Task<IActionResult> Index()
        {
            var sliders = await _homePageSliderService.GetAllByNonDeleteAndActive();
            if (sliders.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (sliders.ResultStatus == ResultStatus.Success)
            {
                ViewBag.Home = "active";
                return View(sliders.Data);
            }
            return NotFound();
        }
        [Route("dahafazlasi/{Title}")]
        public async Task<IActionResult> SliderDetail(int id)
        {
            if (id < 0)
            {
                return NotFound();
            }
            var slider = await _homePageSliderService.Get(id);
            if (slider.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (slider.ResultStatus == ResultStatus.Success)
            {
                ViewBag.Home = "active";
                return View(slider.Data);
            }
            return NotFound();
        }

        [Route("hakkimda")]
        public async Task<IActionResult> About()
        {
            var aboutMe = await _aboutMeService.Get(1);
            if (aboutMe.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (aboutMe.ResultStatus == ResultStatus.Success)
            {
                var contactInfo = await _contactInfoService.Get(1);
                ViewBag.ContactInfo = contactInfo.Data.ContactInfo;
                ViewBag.About = "active";
                return View(aboutMe.Data);
            }
            return NotFound();
        }
        [Route("blog")]
        public async Task<IActionResult> Blog(int page = 1)
        {
            ViewBag.Blog = "active";
            var articles = await _articleService.GetAllByNonDeleteAndActiveOrderByDescendingId();
            var articleList = articles.Data.Articles;
            PagedList<Article> List = new PagedList<Article>(articleList.AsQueryable(), page, 3);
            return View(List);
        }
        [Route("blog/{category}")]
        public async Task<IActionResult> BlogWithCategory(int id,int page = 1)
        {
            ViewBag.Blog = "active";
            if (id < 1)
            {
                return NotFound();
            }
            var articles = await _articleService.GetAllByNonDeleteAndActiveWithCategoryId(id);
            if (articles.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (articles.ResultStatus == ResultStatus.Success)
            {
                var articleList = articles.Data.Articles;
                PagedList<Article> List = new PagedList<Article>(articleList.AsQueryable(), page, 3);
                return View(List);
            }
            return NotFound();
        }
        [Route("blog/{name}/{id}")]
        public async Task<IActionResult> BlogDetail(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var article = await _articleService.Get(id);
            if (article.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (article.ResultStatus == ResultStatus.Success)
            {
                ViewBag.ArticleId = id;
                ViewBag.Blog = "active";
                await _articleService.AddViews(id);
                return View(article.Data);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(CommentAddDto commentAddDto)
        {
            var result = await _articleService.Get(commentAddDto.ArticleId);
            var article = result.Data.Article;
            if (ModelState.IsValid)
            {
                var createdName = commentAddDto.FirstName + commentAddDto.LastName;
                await _commentService.Add(commentAddDto, createdName);
                return RedirectToAction("BlogDetail", new { name = SeoHelper.ToSeoUrl(article.Title), id = article.Id });
            }
            return RedirectToAction("BlogDetail", new { name = SeoHelper.ToSeoUrl(article.Title),id = article.Id });
        }
        [Route("iletisim")]
        public async Task<IActionResult> Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(MessageAddDto messageAddDto)
        {
            if (ModelState.IsValid)
            {
                var createdName = messageAddDto.FirstName + messageAddDto.LastName;
                await _messageService.Add(messageAddDto, createdName);
                return RedirectToAction("Contact");
            }
            return View(messageAddDto);
        }
    }
}
