using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Account 
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        //img

        public Account() { }
    }
}
