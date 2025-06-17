﻿namespace CMMSAPP.Domain.Repositories;

public interface IEFRepository<TEntity> where TEntity : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }

    IQueryable<TEntity> Table { get; }
    IQueryable<TEntity> TableNoTracking { get; }

    Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<bool> AnyAsync(CancellationToken cancellationToken);
    Task<int> CountAsync(CancellationToken cancellationToken);

    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<TEntity> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task SaveChangeAsync(CancellationToken cancellationToken = default);
}
