using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaret.Persistence.Repositories
{

    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ETicaretApiDbContext _context;

        public WriteRepository(ETicaretApiDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<bool> AddASync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeASync(List<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public bool Remove(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> Remove(Guid id)
        {
            var ent = await Table.FirstOrDefaultAsync(x => x.Id == id);
            return Remove(ent);
        }

        public bool RemoveRange(List<TEntity> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public bool UpdateAsync(TEntity entity)
        {
            EntityEntry<TEntity> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

    }
}
