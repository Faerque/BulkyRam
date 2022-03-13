using BulkyRamWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyRamWeb.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }


    }
}
