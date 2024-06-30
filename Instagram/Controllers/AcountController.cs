using Instagram.Data;
using Instagram.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagram.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateAc()
        {
            Utente nuovoUtente = new Utente();
            return View("Account", nuovoUtente);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAc(Utente utente)
        {
            if (!ModelState.IsValid)
            {
                return View("Account", utente);
            }

            using (InstagramDbContext context = new InstagramDbContext())
            {
                context.Utente.Add(utente);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

    }
}
