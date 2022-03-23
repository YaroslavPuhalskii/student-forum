using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentForum.Data.Models;

namespace StudentForum.Data.Infrastructure.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("File");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Image)
                .HasColumnName("image");

            builder.Property(x => x.Format)
                .HasColumnName("format");
        }
    }
}
