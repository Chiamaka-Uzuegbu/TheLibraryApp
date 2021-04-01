﻿// <auto-generated />
using System;
using LibraryApp.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryApp.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryApp.Core.Entities.BookDetails", b =>
                {
                    b.Property<int>("BookDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AvailabilityStatus")
                        .HasColumnType("bit");

                    b.Property<int>("CheckOutDetailsId")
                        .HasColumnType("int");

                    b.Property<decimal>("CoverPrice")
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookDetailsId");

                    b.HasIndex("CheckOutDetailsId");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.CheckOutDetails", b =>
                {
                    b.Property<int>("CheckOutDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalIdentityNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CheckOutDetailsId");

                    b.ToTable("CheckOuts");
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.BookDetails", b =>
                {
                    b.HasOne("LibraryApp.Core.Entities.CheckOutDetails", "CheckOutDetails")
                        .WithMany("ListOfBooks")
                        .HasForeignKey("CheckOutDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CheckOutDetails");
                });

            modelBuilder.Entity("LibraryApp.Core.Entities.CheckOutDetails", b =>
                {
                    b.Navigation("ListOfBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
