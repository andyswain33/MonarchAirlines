using FlightReservationsComponent.SerializationModels;
using System;
using System.Collections.Generic;

namespace FlightReservationsComponent
{
    class FlightReservations
    {
        List<Flight> flights = new List<Flight> {
            new Flight {
                DepartureAirport = "Luton",
                ArrivalAirport = "Paris",
                DepartureTime = new DateTime(2016,06,01,08,30,00),
                ArrivalTime = new DateTime(2016,06,01,09,25,00) },
            new Flight {
                DepartureAirport = "Luton",
                ArrivalAirport = "Dublin",
                DepartureTime = new DateTime(2016,06,01,08,45,00),
                ArrivalTime = new DateTime(2016,06,01,09,35,00) },
            new Flight {
                DepartureAirport = "Luton",
                ArrivalAirport = "Madrid",
                DepartureTime = new DateTime(2016,06,01,09,10,00),
                ArrivalTime = new DateTime(2016,06,01,11,15,00) },
            new Flight {
                DepartureAirport = "Luton",
                ArrivalAirport = "Hamburg",
                DepartureTime = new DateTime(2016,06,01,09,25,00),
                ArrivalTime = new DateTime(2016,06,01,10,20,00) }
        };

        public object Flights
        {
            get
            {
                return flights;
            }
        }

        public List<Flight> AddFlight(Flight flight)
        {
            flights.Add(flight);
            return flights;
        }
    }
}
