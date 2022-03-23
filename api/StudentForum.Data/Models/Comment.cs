namespace StudentForum.Data.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public News News { get; set; }

        public User User { get; set; }
    }
}
