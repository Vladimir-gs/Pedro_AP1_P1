using Microsoft.EntityFrameworkCore;

namespace Pedro_AP1_P1.DAL
{
    class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        : base(options) {}
    }
}