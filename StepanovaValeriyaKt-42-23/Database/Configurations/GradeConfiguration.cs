using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepanovaValeriyaKt_42_23.Models;

namespace StepanovaValeriyaKt_42_23.Database.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("cd_grade");
            builder.HasKey(p => p.GradeId);
            builder.Property(p => p.GradeId).HasColumnName("grade_id");
            builder.Property(p => p.Value).HasColumnName("c_grade_value");
            builder.Property(p => p.StudentId).HasColumnName("f_student_id");
            builder.Property(p => p.DisciplineId).HasColumnName("f_discipline_id");

            builder.HasOne(p => p.Student)
                   .WithMany(t => t.Grades)
                   .HasForeignKey(p => p.StudentId);

            builder.HasOne(p => p.Discipline)
                   .WithMany(t => t.Grades)
                   .HasForeignKey(p => p.DisciplineId);
        }
    }
}
