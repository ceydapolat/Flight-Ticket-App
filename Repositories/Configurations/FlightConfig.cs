using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories;

public class FlightConfig : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasKey(f => f.FlightId);

        /* builder.Property(f => f.DepartureAirport).IsRequired();
        builder.Property(f => f.ArrivalAirport).IsRequired();
        builder.Property(f => f.DepartureDate).IsRequired();
        builder.Property(f => f.ReturnDate).IsRequired(); */

        builder.HasData(
            new Flight() { FlightId = 1, DepartureAirport = "İstanbul/Sabiha Gökçen Airport", ArrivalAirport = "İzmir/Adnan Menderes Airport", DepartureDate = new DateOnly(2024, 01, 25), ReturnDate = new DateOnly(2024, 01, 28) },
                new Flight() { FlightId = 2, DepartureAirport = "İstanbul/İstanbul Airport", ArrivalAirport = "İzmir/Adnan Menderes Airport", DepartureDate = new DateOnly(2024, 01, 26), ReturnDate = new DateOnly(2024, 01, 29) },
                new Flight() { FlightId = 3, DepartureAirport = "İstanbul/Sabiha Gökçen Airport", ArrivalAirport = "Muğla/Dalaman Airport", DepartureDate = new DateOnly(2024, 01, 27), ReturnDate = new DateOnly(2024, 01, 30) },
                new Flight() { FlightId = 4, DepartureAirport = "İstanbul/İstanbul Airport", ArrivalAirport = "Muğla/Dalaman Airport", DepartureDate = new DateOnly(2024, 01, 28), ReturnDate = new DateOnly(2024, 01, 31) },
                new Flight() { FlightId = 5, DepartureAirport = "İzmir/Adnan Menderes Airport", ArrivalAirport = "İstanbul/Sabiha Gökçen Airport", DepartureDate = new DateOnly(2024, 01, 28), ReturnDate = new DateOnly(2024, 02, 01) },
                new Flight() { FlightId = 6, DepartureAirport = "İzmir/Adnan Menderes Airport", ArrivalAirport = "İstanbul/İstanbul Airport", DepartureDate = new DateOnly(2024, 01, 29), ReturnDate = new DateOnly(2024, 02, 02) },
                new Flight() { FlightId = 7, DepartureAirport = "İzmir/Adnan Menderes Airport", ArrivalAirport = "Muğla/Dalaman Airport", DepartureDate = new DateOnly(2024, 01, 30), ReturnDate = new DateOnly(2024, 02, 03) },
                new Flight() { FlightId = 8, DepartureAirport = "Muğla/Dalaman Airport", ArrivalAirport = "İzmir/Adnan Menderes Airport", DepartureDate = new DateOnly(2024, 01, 31), ReturnDate = new DateOnly(2024, 02, 04) },
                new Flight() { FlightId = 9, DepartureAirport = "Muğla/Dalaman Airport", ArrivalAirport = "İstanbul/Sabiha Gökçen Airport", DepartureDate = new DateOnly(2024, 02, 01), ReturnDate = new DateOnly(2024, 02, 05) },
                new Flight() { FlightId = 10, DepartureAirport = "Muğla/Dalaman Airport", ArrivalAirport = "İstanbul/İstanbul Airport", DepartureDate = new DateOnly(2024, 02, 02), ReturnDate = new DateOnly(2024, 02, 06) }
        );
    }
}
