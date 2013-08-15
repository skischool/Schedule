using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class Shift
    {
        public System.DateTime Date { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public int TypeId { get; set; }
        public int ClientId { get; set; }
        public int SeasonId { get; set; }
        public int PriorityId { get; set; }
        public bool CanAdd { get; set; }
        public bool CanRemove { get; set; }
        public bool CanUpdate { get; set; }
        public bool Assigned { get; set; }
        public int Id { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Priority Priority { get; set; }
        public virtual Season Season { get; set; }
        public virtual ShiftType ShiftType { get; set; }
    }
}
