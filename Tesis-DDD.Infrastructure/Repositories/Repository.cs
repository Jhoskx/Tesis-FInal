﻿using Api_DDD.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tesis_DDD.Application.Contracts.Persistence;
using Tesis_DDD.Infrastructure.Persistence;
using Tesis_DDD.Infrastructure.Specification;

namespace Tesis_DDD.Infrastructure.Repositories
{
    public  class Repository<T>:IRepository<T> where T :Entity
    {
        protected readonly TesisDbContext _context;
        public Repository(TesisDbContext context) => _context = context;

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T[]> AddRangeAsync(T[] entities)
        {
            _context.Set<T>().AddRange(entities);
            await _context.SaveChangesAsync();
            return entities;
        }

        public void AddEntity(T entity) => _context.Set<T>().Add(entity);
        public void AddEntityRange(T[] entities) => _context.Set<T>().AddRange(entities);
        public IQueryable<T> ApplySpecification(ISpecification<T> spec) => SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);

        public async Task<int> CountAsync(ISpecification<T> spec) => await ApplySpecification(spec).CountAsync();

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public void DeleteEntity(T entity) => _context.Set<T>().Remove(entity);
        public async Task<IReadOnlyList<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        public async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
        {
            try
            {
                return await ApplySpecification(spec).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } //=> await ApplySpecification(spec).ToListAsync();

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate) => await _context.Set<T>().Where(predicate).ToListAsync();

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeString = null, bool disableTracking = true)
        {
            IQueryable<T> query = _context.Set<T>();
            if (disableTracking) query = query.AsNoTracking();
            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);
            if (predicate != null) query = query.Where(predicate);
            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _context.Set<T>();
            if (disableTracking) query = query.AsNoTracking();
            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));
            if (predicate != null) query = query.Where(predicate);
            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();


        }
        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<T> GetByIdWithSpec(ISpecification<T> spec) => await ApplySpecification(spec).FirstOrDefaultAsync();

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public void UpdateEntity(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => await _context.Set<T>().FirstOrDefaultAsync(predicate);
    }
}

