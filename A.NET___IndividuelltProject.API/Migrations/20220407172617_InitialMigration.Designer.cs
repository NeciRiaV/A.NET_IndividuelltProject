﻿// <auto-generated />
using System;
using A.NET___IndividuelltProject.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace A.NET___IndividuelltProject.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220407172617_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("A.NET___IndividuelltProject.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Birth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Adress = "Skanselgatan 16",
                            Birth = "1985/03-16",
                            ContractStart = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "AnasQlok@gmail.com",
                            FirstName = "Anas",
                            LastName = "Qlok",
                            PhoneNumber = "07367826378",
                            ProjectID = 2
                        },
                        new
                        {
                            EmployeeID = 2,
                            Adress = "Drottningsgatan 1",
                            Birth = "1994/09-13",
                            ContractStart = new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "HannaLahtinen94@gmail.com",
                            FirstName = "Hannah",
                            LastName = "Lahtinen",
                            PhoneNumber = "0732435479",
                            ProjectID = 1
                        },
                        new
                        {
                            EmployeeID = 3,
                            Adress = "Kungsgatan 8",
                            Birth = "1997/11-23",
                            ContractStart = new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "JGergi97@hotmail.com",
                            FirstName = "Jennifer",
                            LastName = "Gergi",
                            PhoneNumber = "0729997367",
                            ProjectID = 3
                        },
                        new
                        {
                            EmployeeID = 4,
                            Adress = "Kungsgatan 6",
                            Birth = "1993/02-11",
                            ContractStart = new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Winborg.Markus@hotmail.com",
                            FirstName = "Markus",
                            LastName = "Winborg",
                            PhoneNumber = "0704006201",
                            ProjectID = 1
                        },
                        new
                        {
                            EmployeeID = 5,
                            Adress = "Storgatan 13",
                            Birth = "1995/06-21",
                            ContractStart = new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mattias.K.1995@hotmail.com",
                            FirstName = "Mattias",
                            LastName = "Karlsson",
                            PhoneNumber = "0727776769",
                            ProjectID = 2
                        });
                });

            modelBuilder.Entity("A.NET___IndividuelltProject.Models.HourRapport", b =>
                {
                    b.Property<int>("HourRapportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("HourRapportID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("HourRapports");

                    b.HasData(
                        new
                        {
                            HourRapportID = 1,
                            EmployeeID = 1,
                            End = new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 2,
                            EmployeeID = 5,
                            End = new DateTime(2022, 3, 28, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 3,
                            EmployeeID = 1,
                            End = new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 4,
                            EmployeeID = 5,
                            End = new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 29, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 5,
                            EmployeeID = 1,
                            End = new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 6,
                            EmployeeID = 5,
                            End = new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 7,
                            EmployeeID = 3,
                            End = new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 8,
                            EmployeeID = 1,
                            End = new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 9,
                            EmployeeID = 5,
                            End = new DateTime(2022, 3, 31, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 3, 31, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 10,
                            EmployeeID = 3,
                            End = new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 11,
                            EmployeeID = 1,
                            End = new DateTime(2022, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 12,
                            EmployeeID = 5,
                            End = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 1, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 13,
                            EmployeeID = 3,
                            End = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 14,
                            EmployeeID = 1,
                            End = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 15,
                            EmployeeID = 5,
                            End = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 16,
                            EmployeeID = 3,
                            End = new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 17,
                            EmployeeID = 2,
                            End = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 18,
                            EmployeeID = 4,
                            End = new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 2, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 19,
                            EmployeeID = 1,
                            End = new DateTime(2022, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 20,
                            EmployeeID = 5,
                            End = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 21,
                            EmployeeID = 3,
                            End = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 4, 3, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 22,
                            EmployeeID = 2,
                            End = new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 23,
                            EmployeeID = 4,
                            End = new DateTime(2022, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 3, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 13
                        },
                        new
                        {
                            HourRapportID = 24,
                            EmployeeID = 1,
                            End = new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 14
                        },
                        new
                        {
                            HourRapportID = 25,
                            EmployeeID = 5,
                            End = new DateTime(2022, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 2,
                            Start = new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 14
                        },
                        new
                        {
                            HourRapportID = 26,
                            EmployeeID = 3,
                            End = new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 3,
                            Start = new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 14
                        },
                        new
                        {
                            HourRapportID = 27,
                            EmployeeID = 2,
                            End = new DateTime(2022, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 4, 7, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 14
                        },
                        new
                        {
                            HourRapportID = 28,
                            EmployeeID = 4,
                            End = new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectID = 1,
                            Start = new DateTime(2022, 4, 4, 7, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekNumber = 14
                        });
                });

            modelBuilder.Entity("A.NET___IndividuelltProject.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitiationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            Description = "The next version of The Sims, has to include open world.",
                            FinishDate = new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InitiationDate = new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "The Sims 5"
                        },
                        new
                        {
                            ProjectID = 2,
                            Description = "A tool that specializes in scanning the human body and creates a life-size 3D projection of the scan.",
                            FinishDate = new DateTime(2029, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InitiationDate = new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "MediHelp"
                        },
                        new
                        {
                            ProjectID = 3,
                            Description = "A tool to take photos of herbs, plants and animals, and get information such as basic info, properties, medicinal info and more.",
                            FinishDate = new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InitiationDate = new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProjectName = "NatureWide"
                        });
                });

            modelBuilder.Entity("A.NET___IndividuelltProject.Models.Employee", b =>
                {
                    b.HasOne("A.NET___IndividuelltProject.Models.Project", "Project")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("A.NET___IndividuelltProject.Models.HourRapport", b =>
                {
                    b.HasOne("A.NET___IndividuelltProject.Models.Employee", "Employee")
                        .WithMany("HourRapports")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
