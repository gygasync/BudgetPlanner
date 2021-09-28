using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public class BudgetPlannerContext: DbContext
    {
        public BudgetPlannerContext(DbContextOptions<BudgetPlannerContext> options) : base(options) { }

        public DbSet<Account> Accounts;
        public 
    }
}
