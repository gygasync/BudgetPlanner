using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public class Rule: BaseModel<long>
    {
        public string Name { get; set; }
        public virtual ICollection<Account> Parameters { get; set; }
        public virtual ICollection<decimal> Variables { get; set; }
        public virtual Trigger Trigger { get; set; }
        
    }
}
