using StudentForum.Data.Models;
using System.Threading.Tasks;

namespace StudentForum.DAL.Abstractions
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);
    }
}
