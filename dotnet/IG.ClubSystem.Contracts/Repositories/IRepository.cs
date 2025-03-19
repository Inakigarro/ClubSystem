using IG.ClubSystem.Domain;

namespace IG.ClubSystem.Contracts.Repositories;

public interface IRepository<TEntity>: IDisposable
    where TEntity : class, IId, new()
{
}
