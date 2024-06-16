namespace Instagram.Data
{
    public class Like
    {
        public int Id { get; set; }
        public DateTime DataLike { get; set; }
        public int NumeroLike { get; set; } 
        public ICollection<Like> Likes { get; set; } = new List<Like>();
        public int PostId { get; set; }
        public Post Post { get; set; }

        public Like() { }
        public Like(int id, DateTime dataLike, int numeroLike, ICollection<Like> likes, int postId, Post post)
        {
            Id = id;
            DataLike = dataLike;
            NumeroLike = numeroLike;
            Likes = likes;
            PostId = postId;
            Post = post;
        }
    }
}
