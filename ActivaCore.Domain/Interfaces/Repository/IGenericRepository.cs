using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ActivaCore.Domain
{
    public interface IGenericRepository<TEntity>
    {
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        //IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        IEnumerable<TEntity> Get();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Update(Guid id, TEntity entityToUpdate);

        void Update( TEntity entityToUpdate);
        void Save();
    }
}

