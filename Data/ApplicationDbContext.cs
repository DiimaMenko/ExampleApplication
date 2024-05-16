using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HomeListsHelper.Models;

namespace HomeListsHelper.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HomeListsHelper.Models.ProductItem>? ProductItem { get; set; }

        public DbSet<HomeListsHelper.Models.Category>? Category { get; set; }

        public DbSet<HomeListsHelper.Models.ItemsList> ItemsLists { get; set; }
    }
}