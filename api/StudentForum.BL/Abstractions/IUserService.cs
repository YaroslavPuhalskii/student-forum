using StudentForum.BL.Models.Authorization;
using StudentForum.Data.Models;
using System.Threading.Tasks;

namespace StudentForum.BL.Abstractions
{
    public interface IUserService
    {
        Task<User> Authenticate(AuthInfo authorizeInfo);

        Task<User> Create(RegisterInfo registerInfo);

        Task<User> GetById(int id);
    }
}
