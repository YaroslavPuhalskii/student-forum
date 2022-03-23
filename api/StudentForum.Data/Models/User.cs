using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StudentForum.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public File File { get; set; }

        public string Role { get; set; }

        public ICollection<News> News { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            News = new HashSet<News>();
            Comments = new HashSet<Comment>();
        }
    }
}
