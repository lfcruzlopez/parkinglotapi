﻿using ParkingLotApi.Models;

namespace ParkingLotApi.Contracts;

public interface IGenericRepository<T> where T: class
{
    Task<T?> GetAsync(Guid? id);

    Task<List<T>> GetAllAsync();

    Task<T> AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(Guid id);

    Task<bool> ExistsAsync(Guid id);
}