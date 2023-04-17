using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp.DAL
{
    public class InMemoryBlogPostDao : IBlogPostDao
    {
        /// <summary>
        /// A list of blogposts
        /// </summary>
        private List<BlogPost> _blogPosts = new List<BlogPost>();

        /// <summary>
        /// Constructor for inserting default blog posts
        /// </summary>
        public InMemoryBlogPostDao()
        {
            _blogPosts.Add(new BlogPost(1, DateTime.Now, "First Blog Post", "This is the first blog post", 1));
            _blogPosts.Add(new BlogPost(2, DateTime.Now, "Second Blog Post", "This is the second blog post", 1));
            _blogPosts.Add(new BlogPost(3, DateTime.Now, "Third Blog Post", "This is the third blog post", 1));
            _blogPosts.Add(new BlogPost(4, DateTime.Now, "Fourth Blog Post", "This is the fourth blog post", 1));
            _blogPosts.Add(new BlogPost(5, DateTime.Now, "Fifth Blog Post", "This is the fifth blog post", 1));
            _blogPosts.Add(new BlogPost(6, DateTime.Now, "Sixth Blog Post", "This is the sixth blog post", 1));
            _blogPosts.Add(new BlogPost(7, DateTime.Now, "Seventh Blog Post", "This is the seventh blog post", 1));
            _blogPosts.Add(new BlogPost(8, DateTime.Now, "Eighth Blog Post", "This is the eighth blog post", 1));
            _blogPosts.Add(new BlogPost(9, DateTime.Now, "Ninth Blog Post", "This is the ninth blog post", 1));
            _blogPosts.Add(new BlogPost(10, DateTime.Now, "Tenth Blog Post", "This is the tenth blog post", 1));
        }

        /// <summary>
        /// Add a new blog post
        /// </summary>
        /// <returns>Blog post id</returns>
        public int AddBlogPost(BlogPost blogPost)
        {
            _blogPosts.Add(blogPost);
            return 42;
        }

        /// <summary>
        /// Get the 10 newest blog posts
        /// </summary>
        /// <returns>10 newest blog posts</returns>
        public IEnumerable<BlogPost> Get10NewestBlogPosts() => _blogPosts.Take(10);

        /// <summary>
        /// Get all blog posts
        /// </summary>
        /// <returns>All blog posts</returns>
        public IEnumerable<BlogPost> GetAll() => _blogPosts;

        /// <summary>
        /// Get specific blog post from id
        /// </summary>
        /// <returns>Blog from id</returns>
        public BlogPost? GetById(int id) => _blogPosts.FirstOrDefault(b => b.Id == id);

        /// <summary>
        /// Update specific blog
        /// </summary>
        /// <returns>True or false if update was successful</returns>
        public bool Update(BlogPost blogPost)
        {
            var postToEdit = GetById(blogPost.Id);
            if(postToEdit == null) { return false; }

            postToEdit.Title = blogPost.Title;
            postToEdit.Content = blogPost.Content;
            return true;
        }
    }
}
