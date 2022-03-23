using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentForum.Data.Models;

namespace StudentForum.Data.Infrastructure.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("News");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("title");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("description");

            builder.Property(x => x.CreateTime)
                .IsRequired()
                .HasColumnName("create_time");

            builder.HasOne(x => x.User)
                .WithMany(x => x.News)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
