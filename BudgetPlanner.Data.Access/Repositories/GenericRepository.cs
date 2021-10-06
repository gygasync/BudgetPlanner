using BudgetPlanner.Data.Access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BudgetPlanner.Data.Access.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly BudgetPlannerDbContext _context;

        public GenericRepository(BudgetPlannerDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsQueryable();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
