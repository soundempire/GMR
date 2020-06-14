﻿using System;
using System.Linq;
using System.Threading.Tasks;

namespace GMR.DAL
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> GetAll(long? parentIdFilter = null);

        Task<T> GetAsync(long id);

        Task<T> CreateAsync(T item);

        Task<T> UpdateAsync(T item);

        Task DeleteAsync(long id);

        Task SaveAsync();
    }
}
