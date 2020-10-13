using Ecommerance.Infrastucture.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Interfaces
{
    public interface IUserService
    {
        Task<AccountDTO> GetAccountAsync(Guid userId);
        Task RegisterAsync(Guid userId, string email, string firstName, string lastName, string password, string role = "user");

        Task<String> LoginAsync(string email, string password);

    }
}
