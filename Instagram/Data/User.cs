using Microsoft.AspNetCore.Identity;

namespace Instagram.Data
{
    public class User : IdentityUser
    {
        public Account Account { get; set; }
    }
}
