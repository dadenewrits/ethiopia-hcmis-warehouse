using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace HCMIS.Concrete.Models.Mapping
{
    public class ABCMap : EntityTypeConfiguration<ABC>
    {
        public ABCMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Value)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ABC");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
