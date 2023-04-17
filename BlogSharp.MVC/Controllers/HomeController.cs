using BlogSharp.DAL;
using BlogSharp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogSharp.MVC.Controllers
{
    public class HomeController : Controller
    {
        IBlogPostDao _blogPostDao;

        public HomeController(IBlogPostDao blogPostDao)
        {
            _blogPostDao = blogPostDao;
        }

        public IActionResult Index()
        {
            return View(_blogPostDao.Get10NewestBlogPosts());
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}