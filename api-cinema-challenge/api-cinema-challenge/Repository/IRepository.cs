using System;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(int id);
    Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes);
    Task<IEnumerable<T>> GetAllFilter(Expression<Func<T, bool>> filter);
}
