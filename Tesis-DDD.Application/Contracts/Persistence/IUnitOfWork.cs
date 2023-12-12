using Api_DDD.Domain.Common;

namespace Tesis_DDD.Application.Contracts.Persistence
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : Entity;
        Task<int> Complete();
    }
}
