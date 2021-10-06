﻿Feature: UsingCalculatorAdditions
	Simple calculator for adding two numbers

@Addition
Scenario Outline: Add zeros for special cases
    Given I have a calculator
    When I have entered "<value1>" and "<value2>" into the calculator and press add
    Then the result should be "<value3>"
    Examples:
    |value1 |value2 |value3 |
    |1 |11 |7 |
    |10 |11 |11 |
    |11 |11 |15 |