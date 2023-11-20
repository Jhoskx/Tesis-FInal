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
        Task<T> AddAsync(T Entity);
        Task<T[]> AddRangeAsync(T[] Entities);
        Task<T> UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        void AddEntity(T Entity);
        void AddEntityRange(T[] Entities);
        void UpdateEntity(T Entity);
        void DeleteEntity(T Entity);
        //Task<T> GetByIdWithSpec(ISpecification<T> spec);

        //Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec);
        //Task<int> CountAsync(ISpecification<T> entity);
    }
}
