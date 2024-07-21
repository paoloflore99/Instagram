using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Instagram.Data
{
    public class Post
    { 
        [Key]
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "massimo 100 caratteri")]
        public string? Titolo { get; set; }
        [StringLength(1000, ErrorMessage = "massimo 1000 caratteri")]
        public string? Descrizione { get; set; }
        public ICollection<Commento>? Commenti { get; set; }
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }
        public byte[]? Imaggine { get; set; }
        public string ImgScr => Imaggine != null ? $"data:image/png;base64,{Convert.ToBase64String(Imaggine)}" : "";
        public bool Visible { get; set; }
        public ICollection<Like>? Likes { get; set; }

        public Post() { }

        public Post(string titolo ,string Descrizione, bool visibile) 
        { 
            this.Titolo = titolo;
            this.Descrizione = Descrizione;
            this.Visible = visibile;
        }
    }
}
