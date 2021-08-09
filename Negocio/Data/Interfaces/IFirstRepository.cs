using Infra.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Data.Interfaces
{
    public interface IFirstRepository 
    {
        Task Create(FirstModel entity);
        Task<FirstModel> GetById(Guid id);
        Task<ICollection<FirstModel>> GetAll();
        Task Update(FirstModel entity);
        Task Delete(object id);
        Task<ICollection<FirstModel>> Get(Expression<Func<FirstModel, bool>> predicate);
        Task<int> Save();
    }
}