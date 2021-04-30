using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace It_Takes_A_Village.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options) : base(options)
        {

        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Profession> Professions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>().HasData(
                new Member { MemberId = 1, F_Name = "Steve", L_Name = "Rogers", PhoneNumber = "555-1234", EmailAddress = "Cap@Avengers.com", ProfessionId = 1, Hobby = "Drawing", DateAdded = DateTime.Now }
                );

            modelBuilder.Entity<Profession>().HasData(
                new Profession { ProfessionId = 1, Title = "Avenger" }
                );
        }

    }
}

