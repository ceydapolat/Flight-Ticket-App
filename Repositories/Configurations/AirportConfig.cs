using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories;

public class AirportConfig : IEntityTypeConfiguration<Airport>
{
     public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasKey(f => f.AirportId);

        builder.HasData(
            new Airport() {AirportId = 1, ArrivalAirport = "İstanbul/Sabiha Gökçen Airport", DepartureAirport = "İstanbul/Sabiha Gökçen Airport"},
            new Airport() {AirportId = 2, ArrivalAirport = "İstanbul/İstanbul Airport", DepartureAirport = "İstanbul/İstanbul Airport"},
            new Airport() {AirportId = 3, ArrivalAirport = "İzmir/Adnan Menderes Airport", DepartureAirport = "İzmir/Adnan Menderes Airport"},
            new Airport() {AirportId = 4, ArrivalAirport = "Muğla/Dalaman Airport", DepartureAirport = "Muğla/Dalaman Airport"},
            new Airport() {AirportId = 5, ArrivalAirport = "Antalya/Antalya Airport", DepartureAirport = "Antalya/Antalya Airport"},
            new Airport() {AirportId = 6, ArrivalAirport = "Mersin/Çukurova Airport", DepartureAirport = "Mersin/Çukurova Airport"}
        );
    }
}
