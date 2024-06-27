using Humanizer.Localisation;
using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Utente
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string NameAcount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        [Required]
        public DateTime DataCreazioneAccount { get; set; }
        public ICollection<UtenteRoles>? UtentiRuoli { get; set; } = new List<UtenteRoles>();
        public Utente() 
        {

            Posts = new List<Post>();
            DataCreazioneAccount = DateTime.Now;
        }
    }
}
