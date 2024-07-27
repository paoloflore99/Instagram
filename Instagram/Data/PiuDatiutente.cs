using Microsoft.AspNetCore.Identity;

namespace Instagram.Data
{
    public class PiuDatiutente : IdentityUser
    {
    public string NomeInstagram { get; set; }
    }
}
