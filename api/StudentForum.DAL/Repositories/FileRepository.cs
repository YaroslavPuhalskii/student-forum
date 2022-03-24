using Microsoft.EntityFrameworkCore;
using StudentForum.DAL.Abstractions;
using StudentForum.Data.Models;

namespace StudentForum.DAL.Repositories
{
    public class FileRepository : BaseRepository<File>, IFileRepository
    {
        public FileRepository(DbContext context) : base(context)
        { }
    }
}
