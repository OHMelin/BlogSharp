using BlogSharp.DAL;
using BlogSharp.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogSharp.MVC.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Dependency injection
        /// </summary>
        IBlogPostDao _blogPostDao;

        public HomeController(IBlogPostDao blogPostDao)
        {
            _blogPostDao = blogPostDao;
        }

        /// <summary>
        /// Index page
        /// </summary>
        /// <returns>10 newest blogs</returns>
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