using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Play.Common
{
    // TODO: T IEntity den türemiş olmalı
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T entity);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
        Task RemoveAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}