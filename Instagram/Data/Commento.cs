using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Commento
    {
        [Key]
        public int Id { get; set; }
        public string? Testo { get; set; }
        public DateTime DataCreazione { get; set; }

        // Chiave esterna per Post
        public int PostId { get; set; }
        public Post? Post { get; set; }

        public Commento() { }
    }
}
