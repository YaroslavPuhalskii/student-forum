using StudentForum.Data.Specifications;

namespace StudentForum.Data.Models
{
    public class File
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }

        public FileFormat Format { get; set; }
    }
}
