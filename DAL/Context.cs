using Microsoft.EntityFrameworkCore;
using Pedro_AP1_P1.Models;

namespace Pedro_AP1_P1.DAL
{
    class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options) {}

        public DbSet<Aportes> Aportes { get; set; }
    }
}