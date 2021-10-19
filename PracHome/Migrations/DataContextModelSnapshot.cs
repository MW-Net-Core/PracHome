﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracHome.Data;

namespace PracHome.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracHome.Models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StandardName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentStandardRelationId")
                        .HasColumnType("int");

                    b.HasKey("StandardId");

                    b.HasIndex("StudentStandardRelationId");

                    b.ToTable("TblStandards");
                });

            modelBuilder.Entity("PracHome.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StandardId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentStandardRelationId")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("StandardId");

                    b.HasIndex("StudentStandardRelationId");

                    b.ToTable("TblStudents");
                });

            modelBuilder.Entity("PracHome.Models.StudentStandardRelation", b =>
                {
                    b.Property<int>("StudentStandardRelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StandardId")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentStandardRelationId");

                    b.ToTable("StudentStandardRelations");
                });

            modelBuilder.Entity("PracHome.Models.Standard", b =>
                {
                    b.HasOne("PracHome.Models.StudentStandardRelation", null)
                        .WithMany("Standards")
                        .HasForeignKey("StudentStandardRelationId");
                });

            modelBuilder.Entity("PracHome.Models.Student", b =>
                {
                    b.HasOne("PracHome.Models.Standard", "Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracHome.Models.StudentStandardRelation", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentStandardRelationId");

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("PracHome.Models.Standard", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("PracHome.Models.StudentStandardRelation", b =>
                {
                    b.Navigation("Standards");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}