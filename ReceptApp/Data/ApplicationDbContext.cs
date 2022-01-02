using Microsoft.EntityFrameworkCore;
using ReceptApp.Models;

namespace ReceptApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
    }
}
