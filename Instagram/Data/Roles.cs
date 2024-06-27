using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Roles
    {
       
        public int Id { get; set; }
        public string Ruolo { get; set; }
        public ICollection<UtenteRoles>? UtentiRuoli { get; set; } = new List<UtenteRoles>();
        public Roles() { }
    }
}
