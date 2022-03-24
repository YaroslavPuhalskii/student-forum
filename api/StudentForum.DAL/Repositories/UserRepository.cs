using Microsoft.EntityFrameworkCore;
using StudentForum.DAL.Abstractions;
using StudentForum.Data.Models;
using System;
using System.Threading.Tasks;

namespace StudentForum.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        { }

        public async Task<User> GetByEmail(string email)
        {
            if (email == null)
            {
                throw new ArgumentNullException();
            }

            return await GetDbSet.FirstOrDefaultAsync(u => u.Email.Equals(email));
        }
    }
}
