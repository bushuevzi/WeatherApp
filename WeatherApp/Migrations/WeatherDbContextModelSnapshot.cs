﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApp.Models;

namespace WeatherApp.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    partial class WeatherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherApp.Models.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WeatherApp.Models.Weather", b =>
                {
                    b.Property<Guid>("WeatherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FeelsLike")
                        .HasColumnType("float");

                    b.Property<string>("PrecType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PressureMm")
                        .HasColumnType("float");

                    b.Property<double>("Temp")
                        .HasColumnType("float");

                    b.Property<double?>("TempWater")
                        .HasColumnType("float");

                    b.Property<string>("WindDir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WindGust")
                        .HasColumnType("float");

                    b.Property<double>("WindSpeed")
                        .HasColumnType("float");

                    b.HasKey("WeatherId");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("WeatherApp.Models.WeatherHystory", b =>
                {
                    b.Property<Guid>("WeatherHystoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("WeatherDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WeatherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WeatherHystoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("WeatherId");

                    b.ToTable("WeatherHystories");
                });

            modelBuilder.Entity("WeatherApp.Models.WeatherHystory", b =>
                {
                    b.HasOne("WeatherApp.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("WeatherApp.Models.Weather", "Weather")
                        .WithMany()
                        .HasForeignKey("WeatherId");
                });
#pragma warning restore 612, 618
        }
    }
}
