using Ecommerance.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Core.Repositories
{
    public interface IUserRepository :IAsyncRepository<User>
    {
        Task<User> GetAsync(string email);
    }
}
