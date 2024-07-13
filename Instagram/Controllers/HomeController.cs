using Humanizer.Localisation;
using Instagram.Data;
using Instagram.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using Instagram.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


//using Instagram.Models;
namespace Instagram.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult esempio()
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {

            }
            return View();
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
                return RedirectToAction(nameof(Index));
            }     
        }



        [HttpGet]
        public IActionResult Update(int id)
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {
                Post postedit = context.Posts.Where(Post =>  Post.Id == id).FirstOrDefault();
                if(postedit == null)
                {
                    return NotFound();
                }
                else
                {
                    InstagramModel model = new InstagramModel();
                    model.Post = postedit;
                    return View(model);
                }
            }
                
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Post post)
        {
            if (!ModelState.IsValid)
            {
                return View("Update" , post);
            }
            using (InstagramDbContext context = new InstagramDbContext())
            {
                Post postedit = context.Posts.Where(Post => Post.Id == id).FirstOrDefault();
                if(postedit != null)
                {
                    postedit.Titolo = post.Titolo;
                    postedit.Descrizione = post.Descrizione;
                    context.SaveChanges();
                    return View("Index");
                }
                else
                {
                    //return RedirectToAction("PostIDPublico", new { id = postedit.Id });
                    return RedirectToAction("Index", post);
                }

            }
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {
                Post postDelete = context.Posts.Where(Post => Post.Id == id).FirstOrDefault();
                if(postDelete != null)
                {
                    context.Posts.Remove(postDelete);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
                
            }
        }




       
        [HttpPost]
        public IActionResult Like()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            using (InstagramDbContext context = new InstagramDbContext())
            {
                context.SaveChanges();
                return View();
            }
               
        }




        [HttpPost]
        public IActionResult CommentoUtente()
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

