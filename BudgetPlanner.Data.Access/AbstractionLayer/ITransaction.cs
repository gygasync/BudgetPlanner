using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BudgetPlanner.Data.Access.AbstractionLayer
{
    public interface ITransaction: IDisposable, IAsyncDisposable
    {
        void Commit();
        void Rollback();
        Task CommitAsync(CancellationToken cancellationToken = default);
        Task RollbackAsync(CancellationToken cancellationToken = default);
    }
}
