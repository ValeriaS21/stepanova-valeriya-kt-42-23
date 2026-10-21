using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepanovaValeriyaKt_42_23.Models;

namespace StepanovaValeriyaKt_42_23.Database.Configurations
{
    public class SpecialnostConfiguration : IEntityTypeConfiguration<Specialnost>
    {
        public void Configure(EntityTypeBuilder<Specialnost> builder)
        {
            builder.ToTable("cd_specialnost");
            builder.HasKey(p => p.SpecialnostId);
            builder.Property(p => p.SpecialnostId).HasColumnName("specialnost_id");
            builder.Property(p => p.Title).HasColumnName("c_specialnost_title");
            builder.Property(p => p.Code).HasColumnName("c_specialnost_code");
        }
    }
}
