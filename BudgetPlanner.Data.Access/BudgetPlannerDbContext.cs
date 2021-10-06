using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Access
{
    public class BudgetPlannerDbContext : DbContext
    {
        public BudgetPlannerDbContext()
        {

        }

        public BudgetPlannerDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
