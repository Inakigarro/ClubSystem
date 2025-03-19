using IG.ClubSystem.Contracts.Repositories;
using IG.ClubSystem.Domain;

namespace IG.ClubSystem.Persistence.Repositories;

public class Repository<TEntity>(ApplicationDbContext context): IRepository<TEntity>
    where TEntity : class, IId, new()
{
    private bool _disposed;

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
