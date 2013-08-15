using System;
using System.Collections.Generic;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class Season
    {
        public Season()
        {
            this.Shifts = new List<Shift>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
