﻿// <auto-generated />
using System;
using Mc2.CrudTest.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mc2.CrudTest.Database.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mc2.CrudTest.Domain.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BankAccountNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Customer", "Customer");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BankAccountNumber = "6037997435104287",
                            PhoneNumber = "0913906453"
                        });
                });

            modelBuilder.Entity("Mc2.CrudTest.Domain.Customer", b =>
                {
                    b.OwnsOne("Mc2.CrudTest.Domain.Email", "Email", b1 =>
                        {
                            b1.Property<long>("CustomerId")
                                .HasColumnType("bigint");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(300)
                                .HasColumnType("nvarchar(300)")
                                .HasColumnName("Email");

                            b1.HasKey("CustomerId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasFilter("[Email] IS NOT NULL");

                            b1.ToTable("Customer", "Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");

                            b1.HasData(
                                new
                                {
                                    CustomerId = 1L,
                                    Value = "karimy.ehsan@gmail.com"
                                });
                        });

                    b.OwnsOne("Mc2.CrudTest.Domain.Name", "Name", b1 =>
                        {
                            b1.Property<long>("CustomerId")
                                .HasColumnType("bigint");

                            b1.Property<DateTime>("DateOfBirth")
                                .HasMaxLength(300)
                                .HasColumnType("datetime2")
                                .HasColumnName("DateOfBirth");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("nvarchar(200)")
                                .HasColumnName("LastName");

                            b1.HasKey("CustomerId");

                            b1.HasIndex("FirstName", "LastName", "DateOfBirth")
                                .IsUnique()
                                .HasFilter("[FirstName] IS NOT NULL AND [LastName] IS NOT NULL AND [DateOfBirth] IS NOT NULL");

                            b1.ToTable("Customer", "Customer");

                            b1.WithOwner()
                                .HasForeignKey("CustomerId");

                            b1.HasData(
                                new
                                {
                                    CustomerId = 1L,
                                    DateOfBirth = new DateTime(1987, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                                    FirstName = "Ehsan",
                                    LastName = "karimi"
                                });
                        });

                    b.Navigation("Email");

                    b.Navigation("Name");
                });
#pragma warning restore 612, 618
        }
    }
}