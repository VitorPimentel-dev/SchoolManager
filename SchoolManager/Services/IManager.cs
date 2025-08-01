﻿
namespace SchoolManager.Services
{
    internal interface IManager<T>
    {
        bool TryAdd(T entity);
        Dictionary<int, T> GetAll();
        void PrintAll();
    }
}
