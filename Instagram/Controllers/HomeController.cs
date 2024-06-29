﻿using Instagram.Data;
using Instagram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//using Instagram.Models;
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
            return View(InstagramMenager.OllPost());
        }

        public IActionResult PostIdPublico(int id)
        {
                return View(InstagramMenager.PostPublic(id));      
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
        public IActionResult Create(Post post)
        {
            if(!ModelState.IsValid)
            {
                return NotFound();
            }
            using (InstagramDbContext context = new InstagramDbContext())
            {
                Post postCreato = new Post();
                postCreato.Titolo = post.Titolo;
                postCreato.Descrizione = post.Descrizione;
                postCreato.Tag = post.Tag;
                //postCreato.Commenti = post.Commenti;
                postCreato.Visible = post.Visible;
                context.Posts.Add(postCreato);
                context.SaveChanges();
                return View("Index");
            }     
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {
                Post postedit = context.Posts.Where(Post =>  Post.Id == id).FirstOrDefault();
                if(postedit != null)
                {
                    return NotFound();
                }
                else
                {
                    return View("Update");
                }
            }
                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            using (InstagramDbContext context = new InstagramDbContext())
            {
                return View("Index");
            }
        }

            public IActionResult Delete()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CreateAc()
        {
            /*
            using (InstagramDbContext context = new InstagramDbContext())
            {
                InstagramModel model = new InstagramModel();
                model.Utentes = new Utente();
                return View("Account", model);                
            }
            */
            Utente nuovoUtente = new Utente();
            return View("Account", nuovoUtente);

        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateAc(Utente utente)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            using (InstagramDbContext context = new InstagramDbContext())
            {
                InstagramModel model = new InstagramModel();
                Utente NuovoUtente = new Utente();
                NuovoUtente.Name = utente.Name;
                NuovoUtente.NameAcount = utente.NameAcount;
                NuovoUtente.Email = utente.Email;
                NuovoUtente.Password = utente.Password;
                context.Utente.Add(NuovoUtente);
                context.SaveChanges();
                return View("Index");
            }

        }*/

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

           //5 2      3           3             2          2         2
        //(20AB5 - 10 A B ) : ( -5AB ) - ( 6A +B) + 12AB+4A ( 9+ B) +B = 


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

