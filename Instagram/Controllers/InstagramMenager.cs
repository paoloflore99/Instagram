using Instagram.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Instagram.Controllers
{
    public class InstagramMenager
    {
        public static List<Post> OllPost()
        {

            using (InstagramDbContext context = new InstagramDbContext())
            {
                List<Post> posts = context.Posts.ToList();
                return context.Posts.ToList();
            }
        }

        public static Post PostPublic(int id)
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {
                return context.Posts.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
