using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.BioBoard.Domain.Entites;

namespace PS.BioBoard.Infrastructure.Persistence.Configurations
{
    public class PersonConfigurations : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            ConfigurePersonsTable(builder);
        }

        private void ConfigurePersonsTable(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Bio)
                .HasMaxLength(1000);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(11);

            builder.Property(p => p.ImageUrl)
                .HasMaxLength(100);
        }

    }
}
