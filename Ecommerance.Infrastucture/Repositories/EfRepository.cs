using Ecommerance.Core.Domain;
using Ecommerance.Infrastucture.Interfaces;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerance.Infrastucture.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : Entity
    {
        private readonly AppDbContext _appDbContext;

        public EfRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _appDbContext.Set<T>().FindAsync(id);
        }
        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _appDbContext.Set<T>().ToListAsync();
        }


        public async Task<T> AddAsync(T entity)
        {
            await _appDbContext.Set<T>().AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            _appDbContext.Set<T>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }


    }
}
