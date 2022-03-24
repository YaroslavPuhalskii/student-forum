using StudentForum.Data.Models;
using System.IdentityModel.Tokens.Jwt;

namespace StudentForum.BL.Abstractions
{
    public interface ITokenService
    {
        string Generete(User user);

        JwtSecurityToken Verify(string jwt);
    }
}
