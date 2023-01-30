﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trip.Persistance;

#nullable disable

namespace Trip.Persistance.Migrations
{
    [DbContext(typeof(TripDbContext))]
    [Migration("20230130132332_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Trip.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NoOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Trip.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Cost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("PerDay")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PerKm")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PerTour")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId")
                        .IsUnique();

                    b.ToTable("Cost");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DrLincense")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ParkTime")
                        .HasColumnType("int");

                    b.Property<int>("TourId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("DriverId");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Cost", b =>
                {
                    b.HasOne("Trip.Domain.Entities.Tour", "Tour")
                        .WithOne("Cost")
                        .HasForeignKey("Trip.Domain.Entities.Cost", "TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Route", b =>
                {
                    b.HasOne("Trip.Domain.Entities.Tour", "Tour")
                        .WithMany("routes")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Tour", b =>
                {
                    b.HasOne("Trip.Domain.Entities.Car", "Car")
                        .WithMany("tours")
                        .HasForeignKey("CarId");

                    b.HasOne("Trip.Domain.Entities.Driver", "Driver")
                        .WithMany("tours")
                        .HasForeignKey("DriverId");

                    b.Navigation("Car");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Car", b =>
                {
                    b.Navigation("tours");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Driver", b =>
                {
                    b.Navigation("tours");
                });

            modelBuilder.Entity("Trip.Domain.Entities.Tour", b =>
                {
                    b.Navigation("Cost")
                        .IsRequired();

                    b.Navigation("routes");
                });
#pragma warning restore 612, 618
        }
    }
}
