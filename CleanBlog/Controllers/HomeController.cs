using CleanBlog.Data;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataSeeding _dataSeeding;
        private readonly BlogDbContext _blogDbContext;

        public HomeController(DataSeeding dataSeeding, BlogDbContext blogDbContext)
        {
            _dataSeeding = dataSeeding;
            _blogDbContext = blogDbContext;
        }

        public IActionResult Index()
        {
            _dataSeeding.SeedData();
            return View();
        }
    }
}
