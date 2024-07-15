using Microsoft.EntityFrameworkCore;
using Project.FGStore.Areas.Admin.Models.Categories;
using Project.FGStore.Areas.Admin.Models.Products;

namespace Project.FGStore.Areas.Admin.Data
{
    public class StoreDbContext: DbContext
    {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
