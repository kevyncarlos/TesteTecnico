﻿namespace API.Data.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
        T AddOrUpdate(T entity);
        IQueryable<T> GetAll(string[]? includes = null);
        T? GetById(int id, string[]? includes = null);
        bool Delete(int id);
        void SaveChanges();
    }
}
