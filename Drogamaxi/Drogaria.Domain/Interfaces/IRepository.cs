﻿using System.Linq.Expressions;

namespace Drogaria.Domain.Interfaces
{
    public interface IRepository { }

    public interface IRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity Objeto);
        Task Delete(TEntity Objeto);
        TEntity? GetById(long Id);
        List<TEntity> GetAll();
        Task Update(TEntity Objeto);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

    }
}
