using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class ShiftType
    {
        public ShiftType()
        {
            this.Shifts = new List<Shift>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.Guid ClientToken { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
