using Api_DDD.Domain.Common;
using System.Collections;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Infrastructure.Persistence;

namespace Tesis_DDD.Infrastructure.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private Hashtable _repositories;
        private readonly TesisDbContext _context;

        public UnitOfWork(TesisDbContext context)
        {
            _context = context;
        }

        public TesisDbContext TesisDbContext => _context;

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            try
            {
                _context.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : Entity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repository = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repository);
            }
            return (IRepository<TEntity>)_repositories[type];
        }

    }
}
