using Microsoft.EntityFrameworkCore;
using StudentForum.DAL.Abstractions;
using StudentForum.Data.Models;

namespace StudentForum.DAL.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        { }
    }
}
