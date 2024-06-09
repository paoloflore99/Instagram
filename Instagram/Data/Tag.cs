using System.ComponentModel.DataAnnotations;

namespace Instagram.Data
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string NomeTag { get; set; }
        public List<Post> Posts { get; set; }

        public Tag() { }
    }
}
