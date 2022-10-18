using Microsoft.EntityFrameworkCore;
using TP02.Models;

namespace TP02.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Bl> Bls { get; set; }

        public DbSet<Container> Containers { get; set; }
    }
}
