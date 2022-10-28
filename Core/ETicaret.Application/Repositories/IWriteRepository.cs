using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity 
    {
        Task<bool> AddASync(TEntity entity);
        Task<bool> AddRangeASync(List<TEntity> entities);
        bool Remove(TEntity entity);
        Task<bool> Remove(Guid id);
        bool RemoveRange(List<TEntity> entities);
        bool UpdateAsync(TEntity entity);
        Task<int> SaveAsync();


    }
}
