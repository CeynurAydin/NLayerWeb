using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerCore.Model;


namespace NLayerRepository.Seeds
{
    internal class TeacherSeed : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(
               new Teacher { Id = 1, Name = "Ceynur", SurName = "Aydın", GraduateDepartment = "EEM", ExamScore = 74.2, OsymRank = 203, PreferredSection = "Electronic", PreferredCity = "Istanbul" });
              
        }
    }
}
