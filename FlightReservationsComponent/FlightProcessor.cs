namespace FlightReservationsComponent
{
    public class FlightProcessor
    {
        FlightReservations reservations = new FlightReservations();

        public bool ReservationsInitialized()
        {
            if (reservations.Flights != null)
            {
                return true;
            }
            
            return false;
        }
    }
}
