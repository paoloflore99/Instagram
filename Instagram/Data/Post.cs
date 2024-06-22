using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Instagram.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Titolo { get; set; }
        public byte[]? Imaggine { get; set; }
        public string? ImgScr => Imaggine != null ? $"data:image/png;base64,{Convert.ToBase64String(Imaggine)}" : "";
        public string? Descrizione { get; set; }
        public ICollection<Commento>? Commenti { get; set; }
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }
        public bool Visible { get; set; }
        public List<Utente>? Utente { get; set; }
        public ICollection<Like>? Likes { get; set; } = new List<Like>();
        public Post() { }

        public Post(string titolo ,string Descrizione, bool visibile) 
        { 
            this.Titolo = titolo;
            this.Descrizione = Descrizione;
            this.Visible = visibile;
        }
    }
}
