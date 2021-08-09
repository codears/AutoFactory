using Infra.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Negocio.Data.Interfaces
{
    public interface IEfRepository<TEntity> : IDisposable where TEntity: IBaseModel
    {
        Task Create(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<ICollection<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Delete(object id);
        Task<ICollection<TEntity>> Get(Expression<Func<TEntity, bool>> predicate);
        Task<int> Save();
    }
}