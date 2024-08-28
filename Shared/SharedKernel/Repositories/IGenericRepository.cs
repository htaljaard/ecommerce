using System;
using SharedKernel.Entities;

namespace SharedKernel.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<Result<T>> GetByIdAsync(Guid id);
    Task<Result<T>> GetAllAsync();
    Task<Result<T>> AddAsync(T entity);
    Task<Result<T>> UpdateAsync(T entity);
    Task<Result<bool>> DeleteAsync(T entity);
}
