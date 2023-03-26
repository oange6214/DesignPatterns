using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Database
{
    public partial class RecipeContext : DbContext
    {
        public virtual DbSet<Recipe> Recipe { get; set; }


        public RecipeContext()
        {

        }

        public RecipeContext(DbContextOptions<RecipeContext> options)
        : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
