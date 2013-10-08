using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Infrastructure.Data.MainModule.Models.Mapping
{
    public class ShiftMap : EntityTypeConfiguration<Shift>
    {
        public ShiftMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Shifts");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Start).HasColumnName("Start");
            this.Property(t => t.End).HasColumnName("End");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.SeasonId).HasColumnName("SeasonId");
            this.Property(t => t.PriorityId).HasColumnName("PriorityId");
            this.Property(t => t.CanAdd).HasColumnName("CanAdd");
            this.Property(t => t.CanRemove).HasColumnName("CanRemove");
            this.Property(t => t.CanUpdate).HasColumnName("CanUpdate");
            this.Property(t => t.Assigned).HasColumnName("Assigned");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.DateModified).HasColumnName("DateModified");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.ClientToken).HasColumnName("ClientToken");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");

            // Relationships
            this.HasRequired(t => t.Priority)
                .WithMany(t => t.Shifts)
                .HasForeignKey(d => d.PriorityId);
            this.HasRequired(t => t.Season)
                .WithMany(t => t.Shifts)
                .HasForeignKey(d => d.SeasonId);
            this.HasRequired(t => t.ShiftType)
                .WithMany(t => t.Shifts)
                .HasForeignKey(d => d.TypeId);

        }
    }
}
