using Api_DDD.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tesis_DDD.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T>where T :Entity
    {
        //lista que devuelve todos los records de una  entidad determinada
        Task<IReadOnlyList<T>> GetAllAsync();

        //devuelve una coleccion de datos  pero con una determinada condicion logica dentro del query
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>>predicate);
        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T,bool>>predicate=null, Func<IQueryable<T> ,
            IOrderedQueryable<T>> orderBy =null, 
            string includeString=null,bool disableTracking=true);

        Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T,object>>>includes=null ,
            bool disableTracking = true);

        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T[]> AddRangeAsync(T[] entities);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        void AddEntity(T entity);
        void AddEntityRange(T[] entities);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        //Task<T> GetByIdWithSpec(ISpecification<T> spec);

        //Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
        //Task<int> CountAsync(ISpecification<T> entity);
    }
}
