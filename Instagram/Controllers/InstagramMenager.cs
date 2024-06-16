using Instagram.Data;

namespace Instagram.Controllers
{
    public class InstagramMenager
    {
        public static List<Post> OllPost()
        {
            using (InstagramDbContext context = new InstagramDbContext())
            {

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
