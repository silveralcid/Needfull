﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241029153058_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Domain.Assessment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<byte>("ActualizationAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("AutonomyAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("ConnectionAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<byte>("EsteemAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("LivelihoodAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("PurposeAvgRating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Assessments");
                });
#pragma warning restore 612, 618
        }
    }
}
