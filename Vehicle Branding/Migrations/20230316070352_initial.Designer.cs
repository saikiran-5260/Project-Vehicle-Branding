﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vehicle_Branding.Data;

#nullable disable

namespace Vehicle_Branding.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230316070352_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vehicle_Branding.Model.VehicleAndType", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelCapacity")
                        .HasColumnType("int");

                    b.Property<int>("FuelReserveCapacity")
                        .HasColumnType("int");

                    b.Property<int>("MilegePerLiter")
                        .HasColumnType("int");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.Property<string>("VIN_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vehicle_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("VehicleAndTypes");
                });

            modelBuilder.Entity("Vehicle_Branding.Model.VehicleColor", b =>
                {
                    b.Property<int>("vehicleColor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vehicleColor_Id"));

                    b.Property<string>("Vehicle_Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("vehicleColor_Id");

                    b.ToTable("VehicleColors");
                });

            modelBuilder.Entity("Vehicle_Branding.Model.VehicleModel", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelCapacity")
                        .HasColumnType("int");

                    b.Property<int>("FuelReserveCapacity")
                        .HasColumnType("int");

                    b.Property<int>("MilegePerLiter")
                        .HasColumnType("int");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("int");

                    b.Property<string>("VIN_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Vehicle_Branding.Model.VehicleTransmission", b =>
                {
                    b.Property<int>("Vehicle_Transmission_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vehicle_Transmission_Id"));

                    b.Property<string>("Vehicle_Transmission_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Vehicle_Transmission_Id");

                    b.ToTable("VehicleTransmission");
                });

            modelBuilder.Entity("Vehicle_Branding.Model.VehicleType1", b =>
                {
                    b.Property<int>("Vehicle_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vehicle_ID"));

                    b.Property<string>("Vehicle_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Vehicle_ID");

                    b.ToTable("VehicleType1");
                });
#pragma warning restore 612, 618
        }
    }
}
