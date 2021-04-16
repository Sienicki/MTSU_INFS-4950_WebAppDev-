using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Takes_A_Village.Models
{
    public class ProfessionContext : DbContext
    {
        public ProfessionContext (DbContextOptions<ProfessionContext>options) : base(options)
        {

        }
        public DbSet<Profession> Professions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Profession>().HasData(
                new Profession { ProfessionId = 1, Name = "Carpenter" }
                );
        }
        
    }
}
