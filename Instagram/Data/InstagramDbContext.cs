using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Instagram.Data
{
    public class InstagramDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Commento>? Comments { get; set; }  
        public DbSet<Tag>? Tags { get; set; }
        public DbSet<Like> Like { get; set; }
       // public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Instagram;" + "Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
