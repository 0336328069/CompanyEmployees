using Infrastructure.Repository.Specific;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public static class RepositoryRegister
    {
        public static void AddRepositories(this IServiceCollection services) {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
