using Instagram.Data;
using Instagram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Instagram.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {
                List<Tag> tags = new List<Tag>(); 
                InstagramModel model = new InstagramModel();
                model.Post = new Post();
                model.Tags = tags;
                return View("Create" , model);
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int esmpio)
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
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
