using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeadTrack.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Leads",
                columns: new[] { "Id", "Category", "ContactEmail", "ContactFirstName", "ContactFullName", "ContactPhoneNumber", "DateCreated", "Description", "Price", "Status", "Suburb" },
                values: new object[,]
                {
                    { 5121931, "Home Renovations", "another.fake@hipmail.com", "Cris", "Sanderson", "04987654321", new DateTime(2018, 8, 30, 11, 14, 0, 0, DateTimeKind.Unspecified), "There is a two story building at the front of the main house that's about 10x5 that would like to convert into self contained living area.", 32.00m, null, "Quinns Rocks 6030" },
                    { 5141895, "Interior Painters", "fake@mailinator.com", "Pete", null, "041235678", new DateTime(2018, 9, 5, 10, 36, 0, 0, DateTimeKind.Unspecified), "Plaster exposed brick walls (see photos), square off 2 archways (see photos), and expand pantry (see photos).", 49.00m, null, "Woolooware 2230" },
                    { 5577421, "Painters", null, "Bill", null, null, new DateTime(2023, 1, 4, 2, 37, 0, 0, DateTimeKind.Unspecified), "Need to paint 2 aluminum windows and a sliding glass door", 62.00m, null, "Yanderra 2574" },
                    { 5588872, "Interior Painters", null, "Craig", null, null, new DateTime(2023, 1, 4, 1, 15, 0, 0, DateTimeKind.Unspecified), "Internal walls 3 colours", 49.00m, null, "Woolooware 2230" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}
