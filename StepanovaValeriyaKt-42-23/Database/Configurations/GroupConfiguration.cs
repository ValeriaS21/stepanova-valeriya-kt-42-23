using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StepanovaValeriyaKt_42_23.Database.Helpers;
using StepanovaValeriyaKt_42_23.Models;

namespace StepanovaValeriyaKt_42_23.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "cd_group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(p => p.GroupId)
                .HasName($"pk_{TableName}_group_id");

            builder.Property(p => p.GroupId)
                    .ValueGeneratedOnAdd();

            builder.Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasComment("Идентификатор записи группы");

            builder.Property(p => p.GroupName)
                .IsRequired()
                .HasColumnName("c_group_name")
                .HasColumnType(ColumnType.String).HasMaxLength(100)
                .HasComment("Название группы");

        

            // 1. Добавляем курс
            builder.Property(p => p.Course)
                .HasColumnName("c_group_course")
                .HasComment("Курс");

            // 2. Добавляем колонку для связи со специальностью
            builder.Property(p => p.SpecialnostId)
                .HasColumnName("f_specialnost_id")
                .HasComment("Идентификатор специальности");

            builder.ToTable(TableName);

            // 3. Настраиваем саму связь (одна специальность - много групп)
            builder.HasOne(p => p.Specialnost)
                .WithMany(t => t.Groups)
                .HasForeignKey(p => p.SpecialnostId)
                .HasConstraintName("fk_f_specialnost_id")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}