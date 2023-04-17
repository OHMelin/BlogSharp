namespace BlogSharp.DAL
{
    public interface IBlogPostDao
    {
        IEnumerable<BlogPost> Get10NewestBlogPosts();
    }
}