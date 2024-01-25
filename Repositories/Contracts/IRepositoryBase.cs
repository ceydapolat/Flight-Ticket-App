﻿using System.Linq.Expressions;

namespace Repositories;

public interface IRepositoryBase<T>
{
    public void Create(T entity);
    IQueryable<T> FindAll(bool trackChanges);
    public T? FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    public void Remove(T entity);
    public void Update(T entity);
    IQueryable<T> Where(Expression<Func<T, bool>> expression);
}
