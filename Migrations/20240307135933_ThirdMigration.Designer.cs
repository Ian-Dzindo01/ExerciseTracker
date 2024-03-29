﻿// <auto-generated />
using System;
using ExerciseTracker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExerciseTracker.Migrations
{
    [DbContext(typeof(ExerciseDbContext))]
    [Migration("20240307135933_ThirdMigration")]
    partial class ThirdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("ExerciseTracker.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Repetitions")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
