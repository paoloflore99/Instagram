using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        
        public Account() { }
    }
}
