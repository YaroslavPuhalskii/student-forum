using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentForum.Data.Models;

namespace StudentForum.Data.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("first_name");

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("last_name");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("email");

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password");

            builder.Property(x => x.Role)
                .HasColumnName("role")
                .HasMaxLength(20);
        }
    }
}
