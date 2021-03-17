using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ch04ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext>options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactID = 1, F_Name = "Mary Ellen", L_Name = "Walton", PhoneNumber = "555-123-4567", EmailAddress = "maryellen@gmail.com", DateAdded = DateTime.Now, CategoryId = 1 },
                new Contact { ContactID = 2, F_Name = "Delores", L_Name = "Del Rio", PhoneNumber = "555-987-6543", EmailAddress = "delores@hotmail.com", DateAdded = DateTime.Now, CategoryId = 2 },
                new Contact { ContactID = 3, F_Name = "Efren", L_Name = "Herrera", PhoneNumber = "555-456-7890", EmailAddress = "efren@aol.com", DateAdded = DateTime.Now, CategoryId = 3 },
                new Contact { ContactID = 4, F_Name = "Sam", L_Name = "Williams", PhoneNumber = "555-454-9870", EmailAddress = "maryellen@gmail.com", DateAdded = DateTime.Now, CategoryId = 2 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Family"},
                new Category { CategoryID = 2, Name = "Friend" },
                new Category { CategoryID = 3, Name = "Work" },
                new Category { CategoryID = 4, Name = "Other" }
                );
        }
    }
}
