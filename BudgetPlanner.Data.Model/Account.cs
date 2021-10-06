using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public class Account: BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
