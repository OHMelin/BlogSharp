namespace BlogSharp.DAL
{
    public interface IBlogPostDao
    {
        /// <summary>
        /// Gets the 10 newest blog posts
        /// </summary>
        /// <returns>List of 10 newest blog posts</returns>
        IEnumerable<BlogPost> Get10NewestBlogPosts();

        /// <summary>
        /// Add a blog post to the list
        /// </summary>
        /// <returns>Blog post id</returns>
        int AddBlogPost(BlogPost blogPost);

        /// <summary>
        /// Get all blog posts
        /// </summary>
        /// <returns>List of all blog posts</returns>
        IEnumerable<BlogPost> GetAll();

        /// <summary>
        /// Gets a specific blog using id
        /// </summary>
        /// <returns>A specific blog object</returns>
        BlogPost? GetById(int id);

        /// <summary>
        /// Updates a specific blogpost
        /// </summary>
        /// <returns>If update was successful, true or false</returns>
        bool Update(BlogPost blogPost);

        bool Delete(BlogPost blogPost);
    }
}