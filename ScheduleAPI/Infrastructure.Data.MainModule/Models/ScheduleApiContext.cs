using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Infrastructure.Data.MainModule.Models.Mapping;

namespace Infrastructure.Data.MainModule.Models
{
    public partial class ScheduleApiContext : DbContext
    {
        static ScheduleApiContext()
        {
            Database.SetInitializer<ScheduleApiContext>(null);
        }

        public ScheduleApiContext()
            : base("Name=ScheduleApiContext")
        {
        }

        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ShiftType> ShiftTypes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PriorityMap());
            modelBuilder.Configurations.Add(new SeasonMap());
            modelBuilder.Configurations.Add(new ShiftMap());
            modelBuilder.Configurations.Add(new ShiftTypeMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
