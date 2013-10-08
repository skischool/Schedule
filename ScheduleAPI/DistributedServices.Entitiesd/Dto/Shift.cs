using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedServices.Entities.Dto
{
    public class Shift
    {
        public System.DateTime Date { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public int ClientId { get; set; }
        public int PriorityId { get; set; }
        public int SeasonId { get; set; }
        public int ShiftTypeId { get; set; }
        public bool CanAdd { get; set; }
        public bool CanRemove { get; set; }
        public bool CanUpdate { get; set; }
        public bool Assigned { get; set; }
        public int? EmployeeId { get; set; }
        public int Id { get; set; }
        
        public virtual Priority Priority { get; set; }
        public virtual Season Season { get; set; }
        public virtual ShiftType ShiftType { get; set; }
    }
}
