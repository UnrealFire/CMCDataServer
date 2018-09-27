using System;
using Microsoft.EntityFrameworkCore;

namespace CMCDataServer.Models
{
    public class CMCDataContext : DbContext
    {
        public DbSet<CurrencyDB> Currencies { get; set; }
        public DbSet<GlobalDataDB> GlobalData { get; set; }

        public CMCDataContext(DbContextOptions<CMCDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
