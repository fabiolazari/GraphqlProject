using GraphqlProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphqlProject.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
