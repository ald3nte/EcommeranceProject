using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Extensions
{
    public static class RepositoryExtensions
    {
        public static async Task<User> GetOrFailAsync(this IUserRepository repository, Guid id)
        {
            var @obj = await repository.GetByIdAsync(id);
            if (@obj == null)
            {
                throw new Exception($"Object named: '{id}' does not exist");
            }
            return @obj;
        }
    }
}
