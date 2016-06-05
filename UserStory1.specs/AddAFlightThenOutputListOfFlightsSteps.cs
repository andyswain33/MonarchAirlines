using FlightReservationsComponent;
using TechTalk.SpecFlow;

namespace UserStory1.specs
{
    [Binding]
    public class AddAFlightThenOutputListOfFlightsSteps
    {
        private FlightProcessor processor = new FlightProcessor();

        [Given(@"I have a list of flights")]
        public bool GivenIHaveAListOfFlights()
        {
            return processor.ReservationsInitialized();
        }

        [When(@"I add a new flight")]
        public void WhenIAddANewFlight()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I would like to output the complete flight list")]
        public void ThenIWouldLikeToOutputTheCompleteFlightList()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
