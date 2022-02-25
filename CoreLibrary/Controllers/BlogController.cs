using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreLibrary.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = bm.GetAllListBlog();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = bm.GetBlogListByID(id);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBm(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetListT()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator validationRules = new BlogValidator();
            ValidationResult result = validationRules.Validate(blog);
            List<SelectListItem> categoryValues = (from x in cm.GetListT()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;
                bm.TAdd(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blog = bm.GetTByID(id);
            bm.TDelete(blog);
            //blog.BlogStatus = false;
            return RedirectToAction("BlogListByWriter");
        }
        [HttpGet]
        public IActionResult GetBlog(int id)
        {
            List<SelectListItem> categoryValues = (from x in cm.GetListT()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            var blogValue = bm.GetTByID(id);
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog blog)
        {
            //var blogs = bm.GetTByID(blog.BlogID);
            //blogs.BlogTitle = blog.BlogTitle;
            //blogs.BlogImage = blog.BlogImage;
            //blogs.BlogThumbnailImage = blog.BlogThumbnailImage;
            //blogs.Category.CategoryID = blog.Category.CategoryID;
            //blogs.BlogContent = blog.BlogContent;
            bm.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }

    }
}
