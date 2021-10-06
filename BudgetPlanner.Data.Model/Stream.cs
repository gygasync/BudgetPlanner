using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public class Stream: BaseEntity<long>
    {
        public string Name { get; set; }
        public virtual Account Account { get; set; }
        public decimal? Movement { get; set; }
        public virtual ICollection<Stream> SubStreams { get; set; }

    }
}
