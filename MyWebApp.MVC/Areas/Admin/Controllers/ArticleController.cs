using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Entities.Dtos.ArticleDtos;
using MyWebApp.Service.Abstract;
using MyWebApp.Shared.Utilities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;

        public ArticleController(IArticleService articleService, ICategoryService categoryService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAll();
            if (articles.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (articles.ResultStatus == ResultStatus.Success)
            {
                return View(articles.Data);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var categories = await _categoryService.GetAllByNonDeleteAndActive();
            
            ViewBag.CategoryList = categories.Data.Categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleAddDto articleAddDto, IFormFile fileImg)
        {
            if (ModelState.IsValid)
            {
                if (fileImg != null)
                {
                    string imgExtension = Path.GetExtension(fileImg.FileName);
                    string imgName = Guid.NewGuid() + imgExtension;
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/uploads/img/{imgName}");
                    using var streamImg = new FileStream(imgPath, FileMode.Create);
                    await fileImg.CopyToAsync(streamImg);
                    articleAddDto.Thumbnail = $"/uploads/img/{imgName}";
                }
                await _articleService.Add(articleAddDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllByNonDeleteAndActive();
            ViewBag.CategoryList = categories.Data.Categories;
            return View(articleAddDto);
        }

        public async Task<IActionResult> Details(int id)
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
                return View(article.Data);
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            var article = await _articleService.GetUpdateDto(id);
            if (article.ResultStatus == ResultStatus.Error)
            {
                return NotFound();
            }
            if (article.ResultStatus == ResultStatus.Success)
            {
                var categories = await _categoryService.GetAllByNonDeleteAndActive();
                ViewBag.CategoryList = categories.Data.Categories;
                return View(article.Data);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ArticleUpdateDto articleUpdateDto, IFormFile fileImg)
        {
            if (ModelState.IsValid)
            {
                if (fileImg != null)
                {
                    string imgExtension = Path.GetExtension(fileImg.FileName);
                    string imgName = Guid.NewGuid() + imgExtension;
                    string imgPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/uploads/img/{imgName}");
                    using var streamImg = new FileStream(imgPath, FileMode.Create);
                    await fileImg.CopyToAsync(streamImg);
                    articleUpdateDto.Thumbnail = $"/uploads/img/{imgName}";
                }
                await _articleService.Update(articleUpdateDto, "Hasan Erdal");
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllByNonDeleteAndActive();
            ViewBag.CategoryList = categories.Data.Categories;
            return View(articleUpdateDto);
        }

        public async Task<IActionResult> HardDelete(int id)
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
                return View(article.Data);
            }
            return NotFound();
        }

        public async Task<IActionResult> DoHardDelete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            await _articleService.HardDelete(id);
            return RedirectToAction("Index");
        }
    }
}
