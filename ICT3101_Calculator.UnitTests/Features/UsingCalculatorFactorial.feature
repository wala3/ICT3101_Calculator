Feature: UsingCalculatorFactorial
    In order to conquer factorials
    As a factorial enthusiast
    I want to understand a variety of factorial operations

@Factorial
Scenario: Factorial of a positive number
    Given I have a calculator
    When I have entered "4" into the calculator and press factorial
    Then the factorial result should be "24"

@Factorial
Scenario: Factorial of zero
    Given I have a calculator
    When I have entered "0" into the calculator and press factorial
    Then the factorial function should throw argument exception