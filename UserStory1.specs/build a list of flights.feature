Feature: output the list of flights
	In order to market the routes
	As the head of commercial operations
	I want to output the list of available flights

@mytag
Scenario: Output the list
	Given I have a list of flights
	When I request the flight list
	Then I would like to output the complete flight list