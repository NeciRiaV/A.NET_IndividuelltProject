using A.NET___IndividuelltProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.NET___IndividuelltProject.API.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<HourRapport> HourRapports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data for Employee
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeID = 1,
                    FirstName = "Anas",
                    LastName = "Qlok",
                    Birth = "1985/03-16",
                    PhoneNumber = "07367826378",
                    Email = "AnasQlok@gmail.com",
                    Adress = "Skanselgatan 16",
                    ContractStart = new DateTime(2020, 08, 26),
                    ProjectID = 2

                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Hannah",
                    LastName = "Lahtinen",
                    Birth = "1994/09-13",
                    PhoneNumber = "0732435479",
                    Email = "HannaLahtinen94@gmail.com",
                    Adress = "Drottningsgatan 1",
                    ContractStart = new DateTime(2021, 10, 02),
                    ProjectID = 1,
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeID = 3,
                    FirstName = "Jennifer",
                    LastName = "Gergi",
                    Birth = "1997/11-23",
                    PhoneNumber = "0729997367",
                    Email = "JGergi97@hotmail.com",
                    Adress = "Kungsgatan 8",
                    ContractStart = new DateTime(2021, 01, 02),
                    ProjectID = 3,
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeID = 4,
                    FirstName = "Markus",
                    LastName = "Winborg",
                    Birth = "1993/02-11",
                    PhoneNumber = "0704006201",
                    Email = "Winborg.Markus@hotmail.com",
                    Adress = "Kungsgatan 6",
                    ContractStart = new DateTime(2020, 10, 02),
                    ProjectID = 1,
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeID = 5,
                    FirstName = "Mattias",
                    LastName = "Karlsson",
                    Birth = "1995/06-21",
                    PhoneNumber = "0727776769",
                    Email = "Mattias.K.1995@hotmail.com",
                    Adress = "Storgatan 13",
                    ContractStart = new DateTime(2019, 08, 17),
                    ProjectID = 2,
                });

            //Seed data for Project
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectID = 1,
                    ProjectName = "The Sims 5",
                    Description = "The next version of The Sims, has to include open world.",
                    InitiationDate = new DateTime(2022, 04, 02),
                    FinishDate = new DateTime(2025, 04, 20)
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectID = 2,
                    ProjectName = "MediHelp",
                    Description = "A tool that specializes in scanning the human body " +
                    "and creates a life-size 3D projection of the scan.",
                    InitiationDate = new DateTime(2022, 03, 28),
                    FinishDate = new DateTime(2029, 10, 10)
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectID = 3,
                    ProjectName = "NatureWide",
                    Description = "A tool to take photos of herbs, plants and animals, " +
                    "and get information such as basic info, properties, medicinal info and more.",
                    InitiationDate = new DateTime(2022, 03, 30),
                    FinishDate = new DateTime(2026, 05, 05)
                });

            //Seed data for HourRapport
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 1,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 28, 8, 0, 0),
                    End = new DateTime(2022, 3, 28, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 2,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 28, 8, 0, 0),
                    End = new DateTime(2022, 3, 28, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 3,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 29, 8, 0, 0),
                    End = new DateTime(2022, 3, 29, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 4,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 29, 8, 30, 0),
                    End = new DateTime(2022, 3, 29, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 5,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 30, 8, 0, 0),
                    End = new DateTime(2022, 3, 30, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 6,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 30, 8, 0, 0),
                    End = new DateTime(2022, 3, 30, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 7,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 30, 8, 0, 0),
                    End = new DateTime(2022, 3, 30, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 8,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 31, 8, 0, 0),
                    End = new DateTime(2022, 3, 31, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 9,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 31, 8, 30, 0),
                    End = new DateTime(2022, 3, 31, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 10,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 3, 31, 8, 0, 0),
                    End = new DateTime(2022, 3, 31, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 11,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 12,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 1, 8, 30, 0),
                    End = new DateTime(2022, 4, 1, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 13,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 1, 8, 0, 0),
                    End = new DateTime(2022, 4, 1, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 14,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 2, 8, 0, 0),
                    End = new DateTime(2022, 4, 2, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 15,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 2, 8, 0, 0),
                    End = new DateTime(2022, 4, 2, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 16,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 2, 8, 0, 0),
                    End = new DateTime(2022, 4, 2, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 17,
                    EmployeeID = 2,
                    ProjectID = 1,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 2, 8, 0, 0),
                    End = new DateTime(2022, 4, 2, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 18,
                    EmployeeID = 4,
                    ProjectID = 1,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 2, 8, 30, 0),
                    End = new DateTime(2022, 4, 2, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 19,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 3, 8, 0, 0),
                    End = new DateTime(2022, 4, 3, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 20,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 3, 8, 0, 0),
                    End = new DateTime(2022, 4, 3, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 21,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 3, 8, 30, 0),
                    End = new DateTime(2022, 4, 3, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 22,
                    EmployeeID = 2,
                    ProjectID = 1,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 3, 8, 0, 0),
                    End = new DateTime(2022, 4, 3, 17, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 23,
                    EmployeeID = 4,
                    ProjectID = 1,
                    WeekNumber = 13,
                    Start = new DateTime(2022, 4, 3, 8, 30, 0),
                    End = new DateTime(2022, 4, 3, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 24,
                    EmployeeID = 1,
                    ProjectID = 2,
                    WeekNumber = 14,
                    Start = new DateTime(2022, 4, 4, 8, 0, 0),
                    End = new DateTime(2022, 4, 4, 16, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 25,
                    EmployeeID = 5,
                    ProjectID = 2,
                    WeekNumber = 14,
                    Start = new DateTime(2022, 4, 4, 8, 0, 0),
                    End = new DateTime(2022, 4, 4, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 26,
                    EmployeeID = 3,
                    ProjectID = 3,
                    WeekNumber = 14,
                    Start = new DateTime(2022, 4, 4, 9, 0, 0),
                    End = new DateTime(2022, 4, 4, 18, 0, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 27,
                    EmployeeID = 2,
                    ProjectID = 1,
                    WeekNumber = 14,
                    Start = new DateTime(2022, 4, 4, 7, 30, 0),
                    End = new DateTime(2022, 4, 4, 16, 30, 0)
                });
            modelBuilder.Entity<HourRapport>().
                HasData(new HourRapport
                {
                    HourRapportID = 28,
                    EmployeeID = 4,
                    ProjectID = 1,
                    WeekNumber = 14,
                    Start = new DateTime(2022, 4, 4, 7, 30, 0),
                    End = new DateTime(2022, 4, 4, 15, 0, 0)
                });
        }
    }
}
