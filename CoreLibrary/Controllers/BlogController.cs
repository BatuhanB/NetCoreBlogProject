using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreLibrary.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
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
    }
}
