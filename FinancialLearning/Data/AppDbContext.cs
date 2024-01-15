using FinancialLearning.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FinancialLearning.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<FinancialPost> FinancialPosts { get; set; }
        public DbSet<Topic> Topics { get; set; }



    }
}