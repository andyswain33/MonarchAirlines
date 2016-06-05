using System;

namespace FlightReservationsComponent.SerializationModels
{
    class Flight
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
