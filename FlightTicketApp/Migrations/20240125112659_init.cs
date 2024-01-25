using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightTicketApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartureAirport = table.Column<string>(type: "TEXT", nullable: false),
                    ArrivalAirport = table.Column<string>(type: "TEXT", nullable: false),
                    DepartureDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateOnly>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "ArrivalAirport", "DepartureAirport", "DepartureDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, "İzmir/Adnan Menderes Airport", "İstanbul/Sabiha Gökçen Airport", new DateOnly(2024, 1, 25), new DateOnly(2024, 1, 28) },
                    { 2, "İzmir/Adnan Menderes Airport", "İstanbul/İstanbul Airport", new DateOnly(2024, 1, 26), new DateOnly(2024, 1, 29) },
                    { 3, "Muğla/Dalaman Airport", "İstanbul/Sabiha Gökçen Airport", new DateOnly(2024, 1, 27), new DateOnly(2024, 1, 30) },
                    { 4, "Muğla/Dalaman Airport", "İstanbul/İstanbul Airport", new DateOnly(2024, 1, 28), new DateOnly(2024, 1, 31) },
                    { 5, "İstanbul/Sabiha Gökçen Airport", "İzmir/Adnan Menderes Airport", new DateOnly(2024, 1, 28), new DateOnly(2024, 2, 1) },
                    { 6, "İstanbul/İstanbul Airport", "İzmir/Adnan Menderes Airport", new DateOnly(2024, 1, 29), new DateOnly(2024, 2, 2) },
                    { 7, "Muğla/Dalaman Airport", "İzmir/Adnan Menderes Airport", new DateOnly(2024, 1, 30), new DateOnly(2024, 2, 3) },
                    { 8, "İzmir/Adnan Menderes Airport", "Muğla/Dalaman Airport", new DateOnly(2024, 1, 31), new DateOnly(2024, 2, 4) },
                    { 9, "İstanbul/Sabiha Gökçen Airport", "Muğla/Dalaman Airport", new DateOnly(2024, 2, 1), new DateOnly(2024, 2, 5) },
                    { 10, "İstanbul/İstanbul Airport", "Muğla/Dalaman Airport", new DateOnly(2024, 2, 2), new DateOnly(2024, 2, 6) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
