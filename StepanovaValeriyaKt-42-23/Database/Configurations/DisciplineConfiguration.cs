using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepanovaValeriyaKt_42_23.Models;

namespace StepanovaValeriyaKt_42_23.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("cd_discipline");
            builder.HasKey(p => p.DisciplineId);
            builder.Property(p => p.DisciplineId).HasColumnName("discipline_id");
            builder.Property(p => p.Name).HasColumnName("c_discipline_name");
            builder.Property(p => p.IsDeleted).HasColumnName("c_discipline_is_deleted");
        }
    }
}
