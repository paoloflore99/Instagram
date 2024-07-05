using Instagram.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Instagram.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private readonly InstagramDbContext _context;

        public WebApiController(InstagramDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> GetAllPosts()
        {
            var posts = InstagramMenager.OllPost();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetPostById(int id)
        {
            var post = InstagramMenager.PostPublic(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public ActionResult<Post> Create(Post post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postCreato = new Post
            {
                Titolo = post.Titolo,
                Descrizione = post.Descrizione,
                Tag = post.Tag,
                Visible = post.Visible
            };

            _context.Posts.Add(postCreato);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPostById), new { id = postCreato.Id }, postCreato);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Post post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postedit = _context.Posts.Find(id);
            if (postedit == null)
            {
                return NotFound();
            }

            postedit.Titolo = post.Titolo;
            postedit.Descrizione = post.Descrizione;

            _context.Entry(postedit).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var postDelete = _context.Posts.Find(id);
            if (postDelete == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(postDelete);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost("like")]
        public IActionResult Like()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SaveChanges();
            return Ok();
        }



    }
}
