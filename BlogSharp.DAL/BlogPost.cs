namespace BlogSharp.DAL
{
    public class BlogPost
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }

        /// <summary>
        /// Constructor which is only used to build on top of the other constructor
        /// </summary>
        public BlogPost(int id, DateTime creationDate, string title, string content, int authorId) : this
            (creationDate, title, content, authorId)
        {
            Id = id;
        }

        public BlogPost(DateTime creationDate, string title, string content, int authorId)
        {
            CreationDate = creationDate;
            Title = title;
            Content = content;
            AuthorId = authorId;
        }

        /// <summary>
        /// Empty constructor to avoid error on edit
        /// </summary>
        public BlogPost()
        {

        }
    }


}