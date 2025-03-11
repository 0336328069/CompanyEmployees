using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<IdentityUser> GetUserByUsernameAsync(string username);
        Task<string> AuthenticateAsync(string username, string password);

        Task<string> RegisterAsync(string username, string password, string role = "User");
    }
}
