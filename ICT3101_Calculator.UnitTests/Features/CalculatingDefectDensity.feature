Feature: CalculatingDefectDensity
	In order to determine defect density
	As a System Quality Engineer
	I want to be able to calculate this
	
@DefectDensity
Scenario: Calculating Defect Density
	Given I have a calculator
	When number of defects is "100" and the program has "50" KLOC
	Then the defect density should be "2" defects/KLOC

@DefectDensity
Scenario: Calculating New SSI
	Given I have a calculator
	When the previous SSI is "50" KLOC and the CSI is "20" KLOC and there are "4" KLOC of changed code  
	Then the new SSI should be "66" KLOC