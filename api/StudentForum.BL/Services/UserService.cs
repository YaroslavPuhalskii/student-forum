using StudentForum.BL.Abstractions;
using StudentForum.BL.Helpers.Settings;
using StudentForum.BL.Models.Authorization;
using StudentForum.DAL.Abstractions;
using StudentForum.Data.Models;
using System;
using System.Threading.Tasks;

namespace StudentForum.BL.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }

        public async Task<User> Authenticate(AuthInfo authorizeInfo)
        {
            var user = await UnitOfWork.GetUser.GetByEmail(authorizeInfo.Email);

            if (user == null)
            {
                throw new ArgumentNullException();
            }

            if (!BCrypt.Net.BCrypt.Verify(authorizeInfo.Password, user.Password))
            {
                throw new ArgumentNullException("Invalid Credentials");
            }

            return user;
        }

        public async Task<User> Create(RegisterInfo registerInfo)
        {
            if (registerInfo == null)
            {
                throw new ArgumentNullException();
            }

            var user = new User
            {
                FirstName = registerInfo.FirstName,
                LastName = registerInfo.LastName,
                Email = registerInfo.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(registerInfo.Password),
                Role = Role.User
            };

            UnitOfWork.GetUser.Insert(user);
            await UnitOfWork.SaveAsync();

            return user;
        }

        public async Task<User> GetById(int id)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            return await UnitOfWork.GetUser.GetById(id);
        }
    }
}
