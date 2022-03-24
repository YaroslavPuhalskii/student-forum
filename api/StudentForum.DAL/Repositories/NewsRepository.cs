using Microsoft.EntityFrameworkCore;
using StudentForum.DAL.Abstractions;
using StudentForum.Data.Models;

namespace StudentForum.DAL.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        public NewsRepository(DbContext context) : base(context)
        { }
    }
}
