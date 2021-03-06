﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using test2retake.Models;

namespace test2retake.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200626104637_TablesCreated")]
    partial class TablesCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("test2retake.Models.Action", b =>
                {
                    b.Property<int>("IdAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NeedSpecialEquipment")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAction");

                    b.ToTable("Action");
                });

            modelBuilder.Entity("test2retake.Models.FireFighter", b =>
                {
                    b.Property<int>("IdFireFighter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("IdFireFighter");

                    b.ToTable("FireFighter");
                });

            modelBuilder.Entity("test2retake.Models.FireFighter_Action", b =>
                {
                    b.Property<int>("IdFireFighter")
                        .HasColumnType("int");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.HasKey("IdFireFighter", "IdAction");

                    b.HasIndex("IdAction");

                    b.ToTable("FireFighter_Action");
                });

            modelBuilder.Entity("test2retake.Models.FireTruck", b =>
                {
                    b.Property<int>("IdFireTruck")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<bool>("SpecialEquipment")
                        .HasColumnType("bit");

                    b.HasKey("IdFireTruck");

                    b.ToTable("FireTruck");
                });

            modelBuilder.Entity("test2retake.Models.FireTruck_Action", b =>
                {
                    b.Property<int>("IdFireTruckAction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAction")
                        .HasColumnType("int");

                    b.Property<int>("IdFireTruck")
                        .HasColumnType("int");

                    b.HasKey("IdFireTruckAction");

                    b.HasIndex("IdAction");

                    b.HasIndex("IdFireTruck");

                    b.ToTable("FireTruck_Action");
                });

            modelBuilder.Entity("test2retake.Models.FireFighter_Action", b =>
                {
                    b.HasOne("test2retake.Models.Action", "Action")
                        .WithMany("FireFighter_Actions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("test2retake.Models.FireFighter", "FireFighter")
                        .WithMany("FireFighter_Actions")
                        .HasForeignKey("IdFireFighter")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("test2retake.Models.FireTruck_Action", b =>
                {
                    b.HasOne("test2retake.Models.Action", "Action")
                        .WithMany("FireTruck_Actions")
                        .HasForeignKey("IdAction")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("test2retake.Models.FireTruck", "FireTruck")
                        .WithMany("FireTruck_Actions")
                        .HasForeignKey("IdFireTruck")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
