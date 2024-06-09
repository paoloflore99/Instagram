using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Instagram.Data
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Titolo { get; set; }
        [Required(ErrorMessage = "Foto obligatoria")]
        public byte[] Imaggine { get; set; }
        public string ImgScr => Imaggine != null ? $"data:image/png;base64,{Convert.ToBase64String(Imaggine)}" : "";
        public ICollection<Commento>? Commenti { get; set; }
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }
        public bool Visible { get; set; }
        public Post() { }

        public Post(string titolo , bool visibile) 
        { 
            this.Titolo = titolo;
            this.Visible = visibile;
        }
    }
}
