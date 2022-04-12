using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A.NET___IndividuelltProject.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InitiationDate = table.Column<DateTime>(nullable: false),
                    FinishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Birth = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: false),
                    ContractStart = table.Column<DateTime>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourRapports",
                columns: table => new
                {
                    HourRapportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    WeekNumber = table.Column<int>(nullable: false),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourRapports", x => x.HourRapportID);
                    table.ForeignKey(
                        name: "FK_HourRapports_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "Description", "FinishDate", "InitiationDate", "ProjectName" },
                values: new object[] { 1, "The next version of The Sims, has to include open world.", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sims 5" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "Description", "FinishDate", "InitiationDate", "ProjectName" },
                values: new object[] { 2, "A tool that specializes in scanning the human body and creates a life-size 3D projection of the scan.", new DateTime(2029, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "MediHelp" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectID", "Description", "FinishDate", "InitiationDate", "ProjectName" },
                values: new object[] { 3, "A tool to take photos of herbs, plants and animals, and get information such as basic info, properties, medicinal info and more.", new DateTime(2026, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "NatureWide" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Adress", "Birth", "ContractStart", "Email", "FirstName", "LastName", "PhoneNumber", "ProjectID" },
                values: new object[,]
                {
                    { 2, "Drottningsgatan 1", "1994/09-13", new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "HannaLahtinen94@gmail.com", "Hannah", "Lahtinen", "0732435479", 1 },
                    { 4, "Kungsgatan 6", "1993/02-11", new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winborg.Markus@hotmail.com", "Markus", "Winborg", "0704006201", 1 },
                    { 1, "Skanselgatan 16", "1985/03-16", new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnasQlok@gmail.com", "Anas", "Qlok", "07367826378", 2 },
                    { 5, "Storgatan 13", "1995/06-21", new DateTime(2019, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mattias.K.1995@hotmail.com", "Mattias", "Karlsson", "0727776769", 2 },
                    { 3, "Kungsgatan 8", "1997/11-23", new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "JGergi97@hotmail.com", "Jennifer", "Gergi", "0729997367", 3 }
                });

            migrationBuilder.InsertData(
                table: "HourRapports",
                columns: new[] { "HourRapportID", "EmployeeID", "End", "ProjectID", "Start", "WeekNumber" },
                values: new object[,]
                {
                    { 17, 2, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 16, 3, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 13, 3, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 10, 3, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 7, 3, new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 25, 5, new DateTime(2022, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 20, 5, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 15, 5, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 12, 5, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 9, 5, new DateTime(2022, 3, 31, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 31, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 6, 5, new DateTime(2022, 3, 30, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 4, 5, new DateTime(2022, 3, 29, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 29, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 2, 5, new DateTime(2022, 3, 28, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 24, 1, new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 19, 1, new DateTime(2022, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 14, 1, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 11, 1, new DateTime(2022, 4, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 8, 1, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 5, 1, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 3, 1, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 1, 1, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 28, 4, new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 4, 7, 30, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 23, 4, new DateTime(2022, 4, 3, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 3, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 18, 4, new DateTime(2022, 4, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 27, 2, new DateTime(2022, 4, 4, 16, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 4, 7, 30, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 22, 2, new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 21, 3, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 4, 3, 8, 30, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 26, 3, new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectID",
                table: "Employees",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_HourRapports_EmployeeID",
                table: "HourRapports",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HourRapports");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
