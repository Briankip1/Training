using Domain.Tests;
using FluentAssertions;
namespace FlightTest
{
    public class FlightSpecifications

    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Domain.Tests.Flight(seatCapacity: 3);
            flight.Book("brian@home.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);

        }
    }
}