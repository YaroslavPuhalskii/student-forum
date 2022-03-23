using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentForum.Data.Models;

namespace StudentForum.Data.Infrastructure.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id");

            builder.Property(x => x.Text)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("text");

            builder.HasOne(x => x.News)
                .WithMany(x => x.Comments)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Comments)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
