using MessagePack;

namespace Instagram.Data
{
    public class Utente
    {
       
        public int Id { get; set; }
        public string? Name { get; set; }
        public string NameAcount { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? PostId { get; set; }
        public Post? Post { get; set; }
        public DateTime DataCreazioneAccount { get; set; }
        public Utente() { }
    }
}
