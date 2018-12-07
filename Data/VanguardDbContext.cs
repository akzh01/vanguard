using System;
using Microsoft.EntityFrameworkCore;
using Vanguard.Models;

namespace Vanguard.Data
{
    public class VanguardDbContext : DbContext
    {
        public DbSet<News> News { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Users> Users { get; set; }

        public VanguardDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
