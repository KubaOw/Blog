using Microsoft.EntityFrameworkCore;

namespace Blog.Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 

        }
        public DbSet<Answer> Answers { get;set; }
        public DbSet<Question> Questions { get;set; }
        public DbSet<Tag> Tags { get;set; }
        public DbSet<User> Users { get; set; } 
    }
}
    
