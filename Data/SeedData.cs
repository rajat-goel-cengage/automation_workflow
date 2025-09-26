using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogWebsite.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>());

            // Look for any blogs.
            if (context.Blogs.Any())
            {
                return;   // DB has been seeded
            }

            context.Blogs.AddRange(
                new Blog
                {
                    Title = "Welcome to My Blog",
                    Content = "This is my first blog post! Welcome to my personal blog where I'll be sharing my thoughts, experiences, and insights about various topics. Stay tuned for more interesting content.",
                    Author = "Admin",
                    Summary = "Welcome post introducing the blog",
                    CreatedDate = DateTime.Now.AddDays(-5),
                    UpdatedDate = DateTime.Now.AddDays(-5)
                },
                new Blog
                {
                    Title = "Getting Started with ASP.NET Core",
                    Content = "ASP.NET Core is a powerful, cross-platform framework for building modern web applications. In this post, I'll walk you through the basics of creating your first ASP.NET Core application. We'll cover project structure, dependency injection, and MVC patterns.",
                    Author = "Tech Writer",
                    Summary = "Learn the basics of ASP.NET Core development",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    UpdatedDate = DateTime.Now.AddDays(-3)
                },
                new Blog
                {
                    Title = "The Future of Web Development",
                    Content = "Web development is constantly evolving. In this post, we'll explore emerging trends like Progressive Web Apps, Jamstack architecture, and the growing importance of performance optimization. What should developers focus on in the coming years?",
                    Author = "Future Thinker",
                    Summary = "Exploring trends and future directions in web development",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    UpdatedDate = DateTime.Now.AddDays(-1)
                }
            );

            context.SaveChanges();
        }
    }
}