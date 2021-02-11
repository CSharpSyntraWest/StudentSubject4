﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StudentSubjects.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20210211105920_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentId")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            BirthDate = new DateTime(1947, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jos",
                            LastName = "De Klos"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            BirthDate = new DateTime(1927, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joke",
                            LastName = "De Klos"
                        },
                        new
                        {
                            Id = new Guid("0a07190b-2eb6-476b-ac9c-2ead04b2f0d6"),
                            BirthDate = new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            LastName = "Jansens"
                        });
                });

            modelBuilder.Entity("Entities.Models.StudentSubject", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubject");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            SubjectId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            StudentId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            SubjectId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                        },
                        new
                        {
                            StudentId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            SubjectId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            StudentId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            SubjectId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                        });
                });

            modelBuilder.Entity("Entities.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SubjectId")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Description = "Csharp programming language",
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Description = "Sql Server for beginners",
                            Name = "Database"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Description = "Web applications in ASP.NET Core",
                            Name = "Web apps"
                        });
                });

            modelBuilder.Entity("Entities.Models.StudentSubject", b =>
                {
                    b.HasOne("Entities.Models.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Entities.Models.Subject", b =>
                {
                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}