using Domain.Models;
using Microsoft.AspNetCore.Identity;

public interface IUserRepository
{
    Task<IdentityUser> GetUserByUsernameAsync(string username);
    Task<bool> CheckPasswordAsync(IdentityUser user, string password);
    Task<IList<string>> GetRolesAsync(IdentityUser user);
}