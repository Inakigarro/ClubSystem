using IG.ClubSystem.Domain;

namespace IG.ClubSystem.Contracts.Repositories;

public interface IRepository<TEntity>: IDisposable
    where TEntity : class, IId, new()
{
    /// <summary>
    /// Adds an entity to the context.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    /// <param name="cancellationToken">The request's cancellation token.</param>
    Task AddAsync(TEntity entity, CancellationToken cancellationToken);

    /// <summary>
    /// Updates an entity in the context.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    void Update(TEntity entity);

    /// <summary>
    /// Deletes an entity from the context.
    /// </summary>
    /// <param name="id">The entity id to delete.</param>
    /// <param name="cancellationToken">The request's cancellation token.</param>
    Task Delete(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Gets an entity by its id.
    /// </summary>
    /// <param name="id">The entity id to look for.</param>
    /// <param name="cancellationToken">The request's cancellation token.</param>
    /// <returns>The corresponding entity.</returns>
    Task<TEntity> GetAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Gets an entity by its id as queryable.
    /// </summary>
    /// <param name="id">The entity id to look for.</param>
    /// <returns>The corresponding entity.</returns>
    IQueryable<TEntity> GetAsQueryableAsync(Guid id);

    /// <summary>
    /// Gets all the entities from the context.
    /// </summary>
    IQueryable<TEntity> GetAll();

    /// <summary>
    /// Saves all the changes to the context.
    /// </summary>
    /// <param name="cancellationToken">The request's cancellation token.</param>
    Task SaveAsync(CancellationToken cancellationToken);
}
