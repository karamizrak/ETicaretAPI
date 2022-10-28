using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories
{
    public interface IReadRepository<TEntity>:IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetByWhere(Expression<Func<TEntity,bool>> where );
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity,bool>> where);
        Task<TEntity> GetByIdAsync(Guid id);
    }
}
