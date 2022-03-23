using System;
using System.Collections.Generic;

namespace StudentForum.Data.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateTime { get; set; }

        public User User { get; set; }

        public ICollection<File> Files { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public News()
        {
            Comments = new HashSet<Comment>();
            Files = new HashSet<File>();
        }
    }
}
