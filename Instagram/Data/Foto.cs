using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Foto
    {
       
        [Key]
        public int Id { get; set; }
        public byte[]? Imaggine { get; set; }
        public string ImgScr => Imaggine != null ? $"data:image/png;base64,{Convert.ToBase64String(Imaggine)}" : "";
        public List<Post> Posts { get; set; }
        public Foto() { }
      



    }
}
