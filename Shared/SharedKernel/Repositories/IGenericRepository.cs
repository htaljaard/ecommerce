using System;
using SharedKernel.Entities;

namespace SharedKernel.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<Result<T>> GetByIdAsync(Guid id);
    Task<Result<T>> GetAsync(int top, int skip);
    Result<IEnumerable<T>> GetByQuery(Func<T, bool> query);

    Task<Result<T>> AddAsync(T entity);
    Task<Result<T>> UpdateAsync(T entity);
    Task<Result<bool>> DeleteAsync(T entity);
}
