Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this
	
@BasicReliability
Scenario: Calculating Current Failure Intensity
	Given I have a calculator
	When initial failure intensity is "10" and program already experienced "50" failures and will experience "100" failures
	Then the current failure intensity should be "5"

@BasicReliability
Scenario: Calculating Average Expected Failures
	Given I have a calculator
	When initial failure intensity is "10" and the program will experience "100" failures and it ran for "10" CPU hours
	Then the average number of expected failures should be "63"