using EasyTalentsData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyTalentsData.Data
{
    public class EasyTalentsContext: DbContext
    {
        public EasyTalentsContext(DbContextOptions<EasyTalentsContext> options)
            : base(options)
        { }

        public DbSet<Talent> Talents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Talent>().ToTable("Talent");
        }
    }
}
