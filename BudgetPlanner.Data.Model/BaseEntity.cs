using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BudgetPlanner.Data.Models
{
    public abstract class BaseEntity<Tkey>
    {
        [Key]
        public Tkey Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public DateTimeOffset DateCreated { get; set; }
        [Required]
        public bool IsDisabled { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}
