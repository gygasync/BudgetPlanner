using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Model
{
    public class Account: BaseModel<long>
    {
        public string Name { get; set; }
        public virtual User User { get; set; }
        public decimal Amount { get; set; }
    }
}
