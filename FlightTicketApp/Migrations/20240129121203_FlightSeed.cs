using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FlightTicketApp.Migrations
{
    /// <inheritdoc />
    public partial class FlightSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airport",
                columns: table => new
                {
                    AirportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartureAirport = table.Column<string>(type: "TEXT", nullable: false),
                    ArrivalAirport = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airport", x => x.AirportId);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartureAirportId = table.Column<int>(type: "INTEGER", nullable: false),
                    ArrivalAirportId = table.Column<int>(type: "INTEGER", nullable: false),
                    DepartureDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    DepartureTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ArrivalTime = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    IsOneWayTicket = table.Column<bool>(type: "INTEGER", nullable: false),
                    AvailableSeat = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });

            migrationBuilder.InsertData(
                table: "Airport",
                columns: new[] { "AirportId", "ArrivalAirport", "DepartureAirport" },
                values: new object[,]
                {
                    { 1, "İstanbul/Sabiha Gökçen Airport", "İstanbul/Sabiha Gökçen Airport" },
                    { 2, "İstanbul/İstanbul Airport", "İstanbul/İstanbul Airport" },
                    { 3, "İzmir/Adnan Menderes Airport", "İzmir/Adnan Menderes Airport" },
                    { 4, "Muğla/Dalaman Airport", "Muğla/Dalaman Airport" },
                    { 5, "Antalya/Antalya Airport", "Antalya/Antalya Airport" },
                    { 6, "Mersin/Çukurova Airport", "Mersin/Çukurova Airport" }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "ArrivalAirportId", "ArrivalTime", "AvailableSeat", "DepartureAirportId", "DepartureDate", "DepartureTime", "IsOneWayTicket", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 3, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 2, 3, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 3, 4, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 4, 4, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 5, 5, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 6, 5, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 7, 6, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 8, 6, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 9, 1, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 10, 2, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 11, 1, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 12, 2, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 13, 1, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 14, 2, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 15, 1, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 16, 2, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 17, 4, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 18, 5, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 5), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 19, 6, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 6), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 20, 5, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 1, 31), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 4) },
                    { 21, 6, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 22, 3, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 23, 3, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 5), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 24, 3, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 6), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 25, 4, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 1, 31), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 4) },
                    { 26, 4, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 27, 3, new TimeOnly(14, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 28, 3, new TimeOnly(14, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 29, 4, new TimeOnly(14, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 30, 4, new TimeOnly(14, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 31, 5, new TimeOnly(14, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 32, 5, new TimeOnly(14, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 33, 6, new TimeOnly(14, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 34, 6, new TimeOnly(14, 0, 0), 400, 2, new DateOnly(2024, 2, 5), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 35, 1, new TimeOnly(14, 0, 0), 400, 3, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(524, 2, 5) },
                    { 36, 2, new TimeOnly(14, 0, 0), 400, 3, new DateOnly(2024, 2, 2), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 37, 1, new TimeOnly(14, 0, 0), 400, 4, new DateOnly(2024, 2, 3), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 38, 2, new TimeOnly(14, 0, 0), 400, 4, new DateOnly(2024, 2, 4), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 39, 1, new TimeOnly(14, 0, 0), 400, 5, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 40, 2, new TimeOnly(14, 0, 0), 400, 5, new DateOnly(2024, 2, 2), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 41, 1, new TimeOnly(14, 0, 0), 400, 6, new DateOnly(2024, 2, 3), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 42, 2, new TimeOnly(14, 0, 0), 400, 6, new DateOnly(2024, 2, 4), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 43, 4, new TimeOnly(14, 0, 0), 400, 3, new DateOnly(2024, 2, 4), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 44, 5, new TimeOnly(14, 0, 0), 400, 3, new DateOnly(2024, 2, 5), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 45, 6, new TimeOnly(14, 0, 0), 400, 3, new DateOnly(2024, 2, 6), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 46, 5, new TimeOnly(14, 0, 0), 400, 4, new DateOnly(2024, 1, 31), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 4) },
                    { 47, 6, new TimeOnly(14, 0, 0), 400, 4, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 48, 3, new TimeOnly(14, 0, 0), 400, 6, new DateOnly(2024, 2, 6), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 49, 4, new TimeOnly(14, 0, 0), 400, 5, new DateOnly(2024, 1, 31), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 4) },
                    { 50, 4, new TimeOnly(14, 0, 0), 400, 6, new DateOnly(2024, 2, 1), new TimeOnly(12, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 51, 3, new TimeOnly(16, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 52, 3, new TimeOnly(16, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 53, 4, new TimeOnly(16, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 54, 4, new TimeOnly(16, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 55, 5, new TimeOnly(16, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 5) },
                    { 56, 5, new TimeOnly(16, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 6) },
                    { 57, 6, new TimeOnly(16, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 8) },
                    { 58, 6, new TimeOnly(16, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(14, 0, 0), true, new DateOnly(2024, 2, 10) },
                    { 59, 3, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 6) },
                    { 60, 3, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) },
                    { 61, 4, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 8) },
                    { 62, 4, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 63, 5, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) },
                    { 64, 5, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 6) },
                    { 65, 6, new TimeOnly(12, 0, 0), 400, 1, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 8) },
                    { 66, 6, new TimeOnly(12, 0, 0), 400, 2, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 67, 1, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) },
                    { 68, 2, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 6) },
                    { 69, 1, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 8) },
                    { 70, 2, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 71, 1, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) },
                    { 72, 2, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 2), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 6) },
                    { 73, 1, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 3), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 8) },
                    { 74, 2, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 75, 4, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 76, 5, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 5), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 77, 6, new TimeOnly(12, 0, 0), 400, 3, new DateOnly(2024, 2, 6), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 78, 5, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 1, 31), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 4) },
                    { 79, 6, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) },
                    { 80, 3, new TimeOnly(12, 0, 0), 400, 4, new DateOnly(2024, 2, 4), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 81, 3, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 2, 5), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 82, 3, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 6), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 10) },
                    { 83, 4, new TimeOnly(12, 0, 0), 400, 5, new DateOnly(2024, 1, 31), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 4) },
                    { 84, 4, new TimeOnly(12, 0, 0), 400, 6, new DateOnly(2024, 2, 1), new TimeOnly(10, 0, 0), false, new DateOnly(2024, 2, 5) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airport");

            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
