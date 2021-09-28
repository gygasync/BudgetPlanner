using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Model
{
    public abstract class BaseModel<Tkey>
    {
        public Tkey Id { get; set; }
        public Guid Guid { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public bool IsDisabled { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}
