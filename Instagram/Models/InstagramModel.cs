using Instagram.Data;

namespace Instagram.Models
{
    public class InstagramModel
    {
        public Post Post { get; set; }
        public List<Tag>? Tags { get; set; }
        public IFormFile? ImgFile { get; set; }
        //public Foto Foto { get; set; }
        public InstagramModel() { }
        public byte[] SetFileImg()
        {
            if (ImgFile == null)
            {
                return null;
            }

            return null;
        }

        public byte[] imgFi()
        {
            if (ImgFile == null)
            {
                return null;
            }
            using var stream = new MemoryStream();
            this.ImgFile?.CopyTo(stream);
            Post.Imaggine = stream.ToArray();
            return Post.Imaggine;
        }

    }
}
