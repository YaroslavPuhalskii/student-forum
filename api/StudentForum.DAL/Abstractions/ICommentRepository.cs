using StudentForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForum.DAL.Abstractions
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
    }
}
