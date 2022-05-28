﻿namespace Play.Common
{
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<IReadOnlyCollection<T>> GetAsync();
        Task<T> GetAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}