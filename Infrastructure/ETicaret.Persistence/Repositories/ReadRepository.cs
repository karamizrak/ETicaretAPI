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
    public class ReadRepository<TEntity> :IReadRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ETicaretApiDbContext _context;

        public ReadRepository(ETicaretApiDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();
        public IQueryable<TEntity> GetAll() => Table;
        

        public IQueryable<TEntity> GetByWhere(Expression<Func<TEntity, bool>> where) => Table.Where(where);


        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> where) => await Table.FirstOrDefaultAsync(where);
        

        public async Task<TEntity> GetByIdAsync(Guid id)=>await Table.FirstOrDefaultAsync(x => x.Id == id);
        
    }
}
