using Infra.Model;
using Microsoft.EntityFrameworkCore;
using Negocio.Context;
using Negocio.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Negocio.Data
{
    public abstract class EfRepository<TEntity> : IEfRepository<TEntity> where TEntity : BaseModel, new()
    {
        protected readonly SimpleContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public EfRepository(SimpleContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<ICollection<TEntity>> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<ICollection<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await Save();
        }

        public virtual async Task Create(TEntity entity)
        {
            _dbSet.Add(entity);
            await Save();
        }

        public virtual async Task Delete(object id)
        {
            //var entity = new TEntity { Id = (Guid)id };
            //_dbSet.Remove(entity);
            await Save();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}