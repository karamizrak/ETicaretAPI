using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories
{
    public interface IReadRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        IQueryable<TEntity> GetByWhere(Expression<Func<TEntity, bool>> where, bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> where, bool tracking = true);
        Task<TEntity> GetByIdAsync(Guid id, bool tracking = true);
    }
}