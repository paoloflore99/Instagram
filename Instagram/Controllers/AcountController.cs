using Microsoft.AspNetCore.Mvc;

namespace Instagram.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
