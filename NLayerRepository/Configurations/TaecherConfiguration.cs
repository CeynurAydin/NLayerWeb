using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerCore.Model;


namespace NLayerRepository.Configurations
{
    public class TaecherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SurName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.GraduateDepartment).IsRequired();
            builder.Property(x => x.ExamScore).IsRequired();
            builder.Property(x => x.OsymRank).IsRequired();
            builder.Property(x => x.PreferredSection).IsRequired();
            builder.Property(x => x.PreferredCity).IsRequired();

            builder.ToTable("Teachers");
        }
    }
}
