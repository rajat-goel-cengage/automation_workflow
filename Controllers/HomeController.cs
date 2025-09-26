using Microsoft.AspNetCore.Mvc;
using BlogWebsite.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogContext _context;

        public HomeController(BlogContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Show the latest 3 blog posts on the home page
            var latestBlogs = await _context.Blogs
                .OrderByDescending(b => b.CreatedDate)
                .Take(3)
                .ToListAsync();

            return View(latestBlogs);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}