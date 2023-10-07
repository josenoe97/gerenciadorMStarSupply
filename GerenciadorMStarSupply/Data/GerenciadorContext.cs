using GerenciadorMStarSupply.Models;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorMStarSupply.Data
{
    public class GerenciadorContext : DbContext
    {
        public GerenciadorContext(DbContextOptions<GerenciadorContext> opts) 
            : base(opts)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
