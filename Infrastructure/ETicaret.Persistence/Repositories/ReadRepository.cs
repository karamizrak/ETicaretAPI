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

namespace ETicaret.Persistence.Repositories
{
    public class ReadRepository<TEntity> : IReadRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ETicaretApiDbContext _context;

        public ReadRepository(ETicaretApiDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var q = Table.AsQueryable();
            if (!tracking)
                q = q.AsNoTracking();
            return q;
        }


        public IQueryable<TEntity> GetByWhere(Expression<Func<TEntity, bool>> where, bool tracking = true)
        {
            var q = Table.Where(where);
            if (!tracking)
                q = q.AsNoTracking();
            return q;
        }


        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> where, bool tracking = true)
        {
            var q = Table.AsQueryable();
            if (!tracking)
                q = q.AsNoTracking();

            return await q.FirstOrDefaultAsync(where);
        }


        public async Task<TEntity> GetByIdAsync(Guid id, bool tracking = true)
        {
            var q = Table.AsQueryable();
            if (!tracking)
                q = q.AsNoTracking();

            return await q.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}