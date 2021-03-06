﻿// <auto-generated />
using System;
using Ch04ContactManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ch04ContactManager.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20210311003549_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ch04ContactManager.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Family"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Friend"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Ch04ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactID = 1,
                            CategoryId = 1,
                            DateAdded = new DateTime(2021, 3, 10, 18, 35, 48, 734, DateTimeKind.Local).AddTicks(2057),
                            EmailAddress = "maryellen@gmail.com",
                            F_Name = "Mary Ellen",
                            L_Name = "Walton",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            ContactID = 2,
                            CategoryId = 2,
                            DateAdded = new DateTime(2021, 3, 10, 18, 35, 48, 737, DateTimeKind.Local).AddTicks(3658),
                            EmailAddress = "delores@hotmail.com",
                            F_Name = "Delores",
                            L_Name = "Del Rio",
                            PhoneNumber = "555-987-6543"
                        },
                        new
                        {
                            ContactID = 3,
                            CategoryId = 3,
                            DateAdded = new DateTime(2021, 3, 10, 18, 35, 48, 737, DateTimeKind.Local).AddTicks(3688),
                            EmailAddress = "efren@aol.com",
                            F_Name = "Efren",
                            L_Name = "Herrera",
                            PhoneNumber = "555-456-7890"
                        },
                        new
                        {
                            ContactID = 4,
                            CategoryId = 2,
                            DateAdded = new DateTime(2021, 3, 10, 18, 35, 48, 737, DateTimeKind.Local).AddTicks(3692),
                            EmailAddress = "maryellen@gmail.com",
                            F_Name = "Sam",
                            L_Name = "Williams",
                            PhoneNumber = "555-454-9870"
                        });
                });

            modelBuilder.Entity("Ch04ContactManager.Models.Contact", b =>
                {
                    b.HasOne("Ch04ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
