﻿using IG.ClubSystem.Contracts.Repositories;
using IG.ClubSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace IG.ClubSystem.Persistence.Repositories;

public class Repository<TEntity>(ApplicationDbContext context) : IRepository<TEntity>
    where TEntity : class, IId, new()
{
    private bool _disposed;

    /// <inheritdoc />
    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await context.Set<TEntity>().AddAsync(entity, cancellationToken);
    }

    /// <inheritdoc />
    public void Update(TEntity entity)
    {
        context.Set<TEntity>().Attach(entity);
        context.Entry(entity).State = EntityState.Modified;
    }

    /// <inheritdoc />
    public async Task Delete(Guid id, CancellationToken cancellationToken)
    {
        var entity = await context.Set<TEntity>().FindAsync(id, cancellationToken);
        if (entity is null)
            throw new ArgumentNullException(nameof(id), $"There is no entity with id: {id}");
        context.Remove(entity);
    }

    /// <inheritdoc />
    public async Task<TEntity> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        var entity = await context.Set<TEntity>().FindAsync(id, cancellationToken);

        return entity ?? throw new ArgumentNullException(nameof(id), $"No existe una entidad con el Id: {id}");
    }

    /// <inheritdoc />
    public IQueryable<TEntity> GetAsQueryableAsync(Guid id)
    {
        return context.Set<TEntity>().Where(entity => entity.Id == id).AsQueryable();
    }

    /// <inheritdoc />
    public IQueryable<TEntity> GetAll()
    {
        return context.Set<TEntity>().AsQueryable();
    }

    /// <inheritdoc />
    public async Task SaveAsync(CancellationToken cancellationToken)
    {
        await context.SaveChangesAsync(cancellationToken);
    }


    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
            if (disposing)
                context.Dispose();
        _disposed = true;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
