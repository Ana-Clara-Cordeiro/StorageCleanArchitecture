using Microsoft.EntityFrameworkCore;
using Storage.Domain.Entities;
using Storage.Infrastructure.Persistence.Mappers;
using Storage.Infrastructure.Persistence.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<VoluntarioModel> Voluntarios { get; set; }

        public DbSet<ChavesModel> Chaves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VoluntarioMapper());
            modelBuilder.ApplyConfiguration(new ChavesMapper());
        }
    }
}
