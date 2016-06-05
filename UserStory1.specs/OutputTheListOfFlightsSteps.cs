using FlightReservationsComponent;
using System;
using TechTalk.SpecFlow;

namespace UserStory1.specs
{
    [Binding]
    public class OutputTheListOfFlightsSteps
    {
        private FlightProcessor processor = new FlightProcessor();

        [Given(@"I have a list of flights")]
        public bool GivenIHaveAListOfFlights()
        {
            return processor.ReservationsInitialized();
        }

        [When(@"I request the flight list")]
        public void WhenIRequestTheFlightList()
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
