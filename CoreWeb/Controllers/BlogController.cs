using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;   
            var values = blogManager.GetBlogsByID(id);
            return View(values);
        }
    }
}
