using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner.Data.Access.AbstractionLayer
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public DbContext Context => _context;

        public ITransaction BeginTransaction()
        {
            return new DbTransaction(_context.Database.BeginTransaction());
        }

        public void Add<T>(T obj) where T : class
        {
            _context.Set<T>().Add(obj);
        }

        public Task AddAsync<T>(T obj) where T : class
        {
            var set = _context.Set<T>();
            return set.AddAsync(obj).AsTask();
        }

        public void Attach<T>(T obj) where T : class
        {
            _context.Set<T>().Attach(obj);
        }  

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            _context = null;
        }

        public IQueryable<T> Query<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Remove<T>(T obj) where T : class
        {
            _context.Set<T>().Remove(obj);
        }

        public void Update<T>(T obj) where T : class
        {
            _context.Set<T>().Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        
    }
}
