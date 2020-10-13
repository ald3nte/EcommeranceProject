using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Repositories
{
    public class UserRepository :  EfRepository<User>, IUserRepository
    {
        private readonly ILogger<ProductDefinitionRepository> _logger;
        private readonly AppDbContext _appDbContext;

        public UserRepository(ILogger<ProductDefinitionRepository> logger, AppDbContext appDbContext) :base(appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public async Task<User> GetAsync(string email)
        {
            return await _appDbContext.Set<User>().FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
