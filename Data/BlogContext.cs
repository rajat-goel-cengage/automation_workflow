using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasKey(b => b.Id);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Content)
                .IsRequired();

            modelBuilder.Entity<Blog>()
                .Property(b => b.Author)
                .HasMaxLength(100);

            modelBuilder.Entity<Blog>()
                .Property(b => b.Summary)
                .HasMaxLength(500);
        }
    }
}