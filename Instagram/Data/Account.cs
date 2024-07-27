using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{               

    public class Account 
    {
        
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string NomeAcount { get; set; }
        //public string UserId { get; set; }
        //public User User { get; set; }
        //public ICollection<Post> Posts { get; set; } = new List<Post>();
        //img

        public Account() { }
    }
}
