using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public class Trigger: BaseModel<long>
    {
        public string Name { get; set; }
        public string Action { get; set; }
    }
}
